using genny.BL.ExtensionMethods;
using genny.Interfaces.Entities;
using genny.Interfaces.Repositories;
using genny.Interfaces.ViewModels;

namespace genny.BL.ViewModels;

public class CodeGeneratorViewModel : ICodeGeneratorViewModel
{
    private readonly IConnectionDescription[] _connections;
    private readonly IDatabaseObjectRepository _databaseObjectRepository;
    private string? _selectedConnection;

    public string? SelectedConnection
    {
        get => _selectedConnection;
        set {
            _selectedConnection = value;
            LoadDatabaseObjects(_selectedConnection);
        } 
    }

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
        IDatabaseObjectRepository databaseObjectRepository)
    {
        _connections = connections;
        _databaseObjectRepository = databaseObjectRepository;
        AvailableConnections = _connections.ToViewModels();
        SelectedConnection = selectedConnection;
    }
}