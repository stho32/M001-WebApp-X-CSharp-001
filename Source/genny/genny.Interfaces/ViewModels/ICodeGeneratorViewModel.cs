namespace genny.Interfaces.ViewModels;

public interface ICodeGeneratorViewModel
{
    string? SelectedConnection { get; set; }
    IConnectionViewModel[] AvailableConnections { get; }
}