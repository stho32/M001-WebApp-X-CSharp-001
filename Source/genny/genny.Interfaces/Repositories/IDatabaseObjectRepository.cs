using genny.Interfaces.Entities;

namespace genny.Interfaces.Repositories;

public interface IDatabaseObjectRepository
{
    IDatabaseObject[] GetList(string connectionString);
}