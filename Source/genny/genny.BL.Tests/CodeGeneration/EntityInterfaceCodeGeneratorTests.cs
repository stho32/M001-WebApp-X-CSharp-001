using genny.BL.Entities;
using genny.Interfaces.CodeGeneration;
using genny.Interfaces.Entities;
using Xunit;

namespace genny.BL.Tests.CodeGeneration;

public class EntityInterfaceCodeGeneratorTests
{
    private ICodeGenerator getGenerator()
    {
        return new EntityInterfaceCodeGenerator();
    }

    [Fact]
    public void Without_any_fields_the_Generator_just_creates_an_empty_interface()
    {
        var generator = getGenerator();

        var dbobject = new DatabaseObject("dbo", "Contact", Array.Empty<IDatabaseColumn>());

        var code = generator.GetCode(dbobject);

        Assert.Equal(@"
public interface IContact
{
}
".Trim(), code);
    }

}