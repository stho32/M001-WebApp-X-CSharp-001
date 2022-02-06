using genny.Interfaces.Entities;

namespace genny.BL.Entities;

public class DatabaseObject : IDatabaseObject
{
    public string Schema { get; }
    public string Name { get; }
    public IDatabaseColumn[] Columns { get; }

    public DatabaseObject(string schema, string name, IDatabaseColumn[] columns)
    {
        Schema = schema;
        Name = name;
        Columns = columns;
    }
}