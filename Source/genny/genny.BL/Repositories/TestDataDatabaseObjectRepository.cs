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

            result.Add(new DatabaseObject("dbo", "Contact", 
                new []
                {
                    new DatabaseColumn("Id", "int", 0, 0, 0, true),
                    new DatabaseColumn("Salutation", "varchar", 200, 0, 0, false),
                    new DatabaseColumn("Firstname", "varchar", 200, 0, 0, false),
                    new DatabaseColumn("Surname", "varchar", 200, 0, 0, false)
                }));

            result.Add(new DatabaseObject("dbo", "ContactStatistics", new[]
            {
                new DatabaseColumn("Id", "int", 0, 0, 0, true),
                new DatabaseColumn("Salutation", "varchar", 200, 0, 0, false),
                new DatabaseColumn("Firstname", "varchar", 200, 0, 0, false),
                new DatabaseColumn("Surname", "varchar", 200, 0, 0, false)
            }));

            return result.ToArray();
        }

        return Array.Empty<IDatabaseObject>();
    }
}