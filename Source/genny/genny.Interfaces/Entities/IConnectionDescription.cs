namespace genny.Interfaces.Entities;

public interface IConnectionDescription
{
    string ConnectionStringName { get; }
    string ConnectionString { get; }
}
