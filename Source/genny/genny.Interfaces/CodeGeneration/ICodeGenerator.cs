using genny.Interfaces.Entities;

namespace genny.Interfaces.CodeGeneration;

public interface ICodeGenerator
{
    string GetCode(IDatabaseObject databaseObject);
}
