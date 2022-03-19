using genny.Interfaces.CodeGeneration;
using genny.Interfaces.Entities;

namespace genny.BL.Tests.CodeGeneration;

public abstract class CodeGeneratorBase : ICodeGenerator
{
    public abstract string GetCode(IDatabaseObject databaseObject);
}