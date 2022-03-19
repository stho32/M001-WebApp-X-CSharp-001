using genny.Interfaces.Entities;

namespace genny.BL.Entities;

public class DatabaseColumn : IDatabaseColumn
{
    public string Name { get; }
    public string DataType { get; }
    public int MaxLength { get; }
    public int Precision { get; }
    public int Scale { get; }
    public bool IsPrimaryKey { get; }

    public DatabaseColumn(string name, string dataType, int maxLength, int precision, int scale, bool isPrimaryKey)
    {
        Name = name;
        DataType = dataType;
        MaxLength = maxLength;
        Precision = precision;
        Scale = scale;
        IsPrimaryKey = isPrimaryKey;
    }
}