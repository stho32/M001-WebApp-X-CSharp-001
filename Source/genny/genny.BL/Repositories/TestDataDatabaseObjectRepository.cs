using genny.BL.Entities;
using genny.Interfaces.Entities;
using genny.Interfaces.Repositories;

namespace genny.BL.Repositories;

public class TestDataDatabaseObjectRepository : IDatabaseObjectRepository
{
    public IDatabaseObject[] GetList(string connectionString)
    {
        if (connectionString == "Anwendung2Connection")
        {
            var result = new List<IDatabaseObject>();

            result.Add(new DatabaseObject("dbo", "Table", Array.Empty<IDatabaseColumn>()));
            result.Add(new DatabaseObject("dbo", "View", Array.Empty<IDatabaseColumn>()));

            return result.ToArray();
        }

        return Array.Empty<IDatabaseObject>();
    }
}