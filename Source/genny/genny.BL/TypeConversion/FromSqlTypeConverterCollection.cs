using genny.Interfaces.CodeGeneration;

namespace genny.BL.TypeConversion;

public class FromSqlTypeConverterCollection : IFromSqlTypeConverterCollection
{
    protected readonly string _defaultType;
    protected readonly List<IFromSqlTypeConverter> _converters = new();

    public FromSqlTypeConverterCollection(string defaultType = "", IFromSqlTypeConverter[]? converters = null)
    {
        _defaultType = defaultType;
        if ( converters != null) 
        {
            _converters.AddRange(converters);
        }
    }

    public string? GetTypeForSqlType(string dataType, int maxLength, int precision, int scale, bool isPrimaryKey)
    {
        foreach (var converter in _converters)
        {
            var value = converter.GetTypeForSqlType(dataType, maxLength, precision, scale, isPrimaryKey);
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }
        }

        return _defaultType;
    }

    public void Add(IFromSqlTypeConverter fromSqlTypeConverter)
    {
        _converters.Add(fromSqlTypeConverter);
    }
}