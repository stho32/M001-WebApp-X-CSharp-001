namespace genny.BL.TypeConversion;

public class CSharpFromSqlTypeConverterCollection : FromSqlTypeConverterCollection
{
    public CSharpFromSqlTypeConverterCollection() :
        base("unknown")
    {
        _converters.Add(new FromSqlTypeConverter("int", "int"));
        _converters.Add(new FromSqlTypeConverter("nvarchar", "string"));
        _converters.Add(new FromSqlTypeConverter("varchar", "string"));
        _converters.Add(new FromSqlTypeConverter("datetime", "DateTime"));
        _converters.Add(new FromSqlTypeConverter("uniqueidentifier", "Guid"));
        _converters.Add(new FromSqlTypeConverter("bit", "bool"));
        _converters.Add(new FromSqlTypeConverter("decimal", "double"));
        _converters.Add(new FromSqlTypeConverter("varbinary", "byte[]"));
        _converters.Add(new FromSqlTypeConverter("image", "byte[]"));
    }
}