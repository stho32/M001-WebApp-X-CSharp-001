using genny.BL.CodeGeneration;
using genny.BL.Entities;
using genny.BL.TypeConversion;
using genny.Interfaces.CodeGeneration;
using genny.Interfaces.Entities;
using Xunit;

namespace genny.BL.Tests.CodeGeneration;

public class EntityInterfaceCodeGeneratorTests
{
    private ICodeGenerator getGenerator()
    {
        return new EntityInterfaceCodeGenerator(
            new CSharpFromSqlTypeConverterCollection());
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

    [Fact]
    public void When_there_is_a_column_defined_it_pops_up_as_a_property()
    {
        var generator = getGenerator();

        var column = new DatabaseColumn("SomeColumn", "varchar", 200, 0, 0, false);
        var dbobject = new DatabaseObject("dbo", "Contact", new IDatabaseColumn[] {column});

        var code = generator.GetCode(dbobject);

        Assert.Equal(@"
public interface IContact
{
    string SomeColumn { get; }
}
".Trim(), code);
    }

}