using genny.Interfaces.ViewModels;

namespace genny.BL.ViewModels;

public class CodeGeneratorViewModel : ICodeGeneratorViewModel
{
    public string? SelectedConnection { get; set; }
    public IConnectionViewModel[] AvailableConnections { get; }

    public CodeGeneratorViewModel(string? selectedConnection, IConnectionViewModel[] availableConnections)
    {
        SelectedConnection = selectedConnection;
        AvailableConnections = availableConnections;
    }
}