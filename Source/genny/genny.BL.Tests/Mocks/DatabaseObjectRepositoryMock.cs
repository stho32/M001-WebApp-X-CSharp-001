using genny.BL.Entities;
using genny.Interfaces.Entities;
using genny.Interfaces.Repositories;

namespace genny.BL.Tests.Mocks;

internal class DatabaseObjectRepositoryMock : IDatabaseObjectRepository
{
    public IDatabaseObject[] GetList(string connectionString)
    {
        return new IDatabaseObject[]
        {
            new DatabaseObject("dbo", "Table", Array.Empty<IDatabaseColumn>()),
            new DatabaseObject("dbo", "View", Array.Empty<IDatabaseColumn>()),
        };
    }
}