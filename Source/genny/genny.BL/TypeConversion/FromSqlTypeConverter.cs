using genny.Interfaces.CodeGeneration;

namespace genny.BL.TypeConversion;

public class FromSqlTypeConverter : IFromSqlTypeConverter
{
    private readonly string _sourceTypeName;
    private readonly string _targetTypeName;

    public FromSqlTypeConverter(
        string sourceTypeName,
        string targetTypeName
    )
    {
        _sourceTypeName = sourceTypeName.ToLower();
        _targetTypeName = targetTypeName;
    }
    
    public string? GetTypeForSqlType(string dataType, int maxLength, int precision, int scale, bool isPrimaryKey)
    {
        if (dataType.ToLower() == _sourceTypeName)
        {
            return _targetTypeName;
        }

        return null;
    }
}