using System.Text;
using genny.Interfaces.CodeGeneration;
using genny.Interfaces.Entities;

namespace genny.BL.CodeGeneration;

public class EntityInterfaceCodeGenerator : CodeGeneratorBase
{
    private readonly IFromSqlTypeConverterCollection _typeConverters;

    public EntityInterfaceCodeGenerator(IFromSqlTypeConverterCollection typeConverters)
    {
        _typeConverters = typeConverters;
    }

    public override string GetCode(IDatabaseObject databaseObject)
    {
        var result = new StringBuilder();

        result.AppendLine($"public interface I{databaseObject.Name}");
        result.AppendLine("{");

        foreach (var column in databaseObject.Columns)
        {
            var type = _typeConverters.GetTypeForSqlType(column.DataType, column.MaxLength, column.Precision, column.Scale, column.IsPrimaryKey);
            result.AppendLine("    " + type + " " + column.Name + " { get; }");
        }

        result.AppendLine("}");

        return result.ToString().Trim();
    }
}
