using System.Text;
using genny.Interfaces.Entities;

namespace genny.BL.Tests.CodeGeneration;

public class EntityInterfaceCodeGenerator : CodeGeneratorBase
{
    public override string GetCode(IDatabaseObject databaseObject)
    {
        var result = new StringBuilder();

        result.AppendLine($"public interface I{databaseObject.Name}");
        result.AppendLine("{");
        result.AppendLine("}");

        return result.ToString().Trim();
    }
}
