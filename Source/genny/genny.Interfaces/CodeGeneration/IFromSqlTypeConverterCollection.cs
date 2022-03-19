namespace genny.Interfaces.CodeGeneration;

public interface IFromSqlTypeConverterCollection : IFromSqlTypeConverter
{
    void Add(IFromSqlTypeConverter fromSqlTypeConverter);
}