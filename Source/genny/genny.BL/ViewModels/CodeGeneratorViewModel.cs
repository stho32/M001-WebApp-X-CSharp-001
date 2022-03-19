using System.Text;
using genny.BL.ExtensionMethods;
using genny.Interfaces.CodeGeneration;
using genny.Interfaces.Entities;
using genny.Interfaces.Repositories;
using genny.Interfaces.ViewModels;

namespace genny.BL.ViewModels;

public class CodeGeneratorViewModel : ICodeGeneratorViewModel
{
    private readonly IConnectionDescription[] _connections;
    private readonly IDatabaseObjectRepository _databaseObjectRepository;
    private readonly ICodeGenerator[] _codeGenerators;
    private string? _selectedConnection;

    public string? SelectedConnection
    {
        get => _selectedConnection;
        set {
            _selectedConnection = value;
            LoadDatabaseObjects(_selectedConnection);
        } 
    }

    private string? _selectedObject;

    public string? SelectedObject
    {
        get => _selectedObject;
        set
        {
            _selectedObject = value;
            LoadGeneratedCode(_selectedObject);
        }
    }

    private void LoadGeneratedCode(string? selectedObject)
    {
        if (string.IsNullOrWhiteSpace(selectedObject))
        {
            return;
        }

        var databaseObject = 
            DatabaseObjects.FirstOrDefault(x => 
                string.Equals(x.Fullname, selectedObject, StringComparison.CurrentCultureIgnoreCase));

        if (databaseObject == null)
        {
            GeneratedCode = "Leider konnte ich das gewählte Datenbankobjekt nicht finden.";
            return;
        }

        var result = new StringBuilder();

        foreach (var generator in _codeGenerators)
        {
            result.AppendLine(generator.GetCode(databaseObject));
            result.AppendLine("");
        }

        GeneratedCode = result.ToString();
    }

    public string GeneratedCode { get; set; }

    private void LoadDatabaseObjects(string? selectedConnection)
    {
        DatabaseObjects = Array.Empty<IDatabaseObject>();

        if (!string.IsNullOrEmpty(selectedConnection))
        {
            var connection = _connections.FirstOrDefault(
                x => x.ConnectionStringName == selectedConnection
                );

            if (connection != null)
            {
                DatabaseObjects = _databaseObjectRepository.GetList(connection.ConnectionString);                
            }
        }
    }

    public IConnectionViewModel[] AvailableConnections { get; }
    public IDatabaseObject[] DatabaseObjects { get; private set; } = Array.Empty<IDatabaseObject>();

    public CodeGeneratorViewModel(
        string? selectedConnection,
        IConnectionDescription[] connections,
        IDatabaseObjectRepository databaseObjectRepository, 
        ICodeGenerator[] codeGenerators)
    {
        _connections = connections;
        _databaseObjectRepository = databaseObjectRepository;
        _codeGenerators = codeGenerators;
        AvailableConnections = _connections.ToViewModels();
        SelectedConnection = selectedConnection;
        GeneratedCode = "";
    }
}