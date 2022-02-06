using genny.Interfaces;
using genny.Interfaces.Entities;

namespace genny.BL.Entities;

public class ConnectionDescription : IConnectionDescription
{
    public string ConnectionStringName { get; }
    public string ConnectionString { get; }

    public ConnectionDescription(string connectionStringName, string connectionString)
    {
        ConnectionStringName = connectionStringName;
        ConnectionString = connectionString;
    }
}