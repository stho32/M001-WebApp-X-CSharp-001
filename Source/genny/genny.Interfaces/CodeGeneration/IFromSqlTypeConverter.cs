namespace genny.Interfaces.CodeGeneration;

public interface IFromSqlTypeConverter
{
    string? GetTypeForSqlType(string dataType, int maxLength, int precision, int scale, bool isPrimaryKey);
}

public interface IFromSqlTypeConverterCollection : IFromSqlTypeConverter
{
}