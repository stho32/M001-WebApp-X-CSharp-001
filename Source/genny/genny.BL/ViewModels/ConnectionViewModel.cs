using genny.Interfaces.ViewModels;

namespace genny.BL.ViewModels;

public class ConnectionViewModel : IConnectionViewModel
{
    public string ConnectionStringName { get; }

    public ConnectionViewModel(string connectionStringName)
    {
        ConnectionStringName = connectionStringName;
    }
}

