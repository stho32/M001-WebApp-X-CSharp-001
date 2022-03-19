using genny.BL.TypeConversion;
using genny.Interfaces.CodeGeneration;
using Xunit;

namespace genny.BL.Tests.TypeConversion;

public class FromSqlTypeConverterCollectionTests
{
    private IFromSqlTypeConverterCollection getCollection(string defaultValue = "")
    {
        var collection = new FromSqlTypeConverterCollection(defaultValue);
        return collection;
    }

    [Fact]
    public void A_collection_can_convert_multiple_types()
    {
        var collection = getCollection();
        collection.Add(new FromSqlTypeConverter("varchar", "string"));
        collection.Add(new FromSqlTypeConverter("int", "int"));

        Assert.Equal("string", collection.GetTypeForSqlType("varchar", 200, 0, 0, false));
        Assert.Equal("int", collection.GetTypeForSqlType("int", 200, 0, 0, false));
    }

    [Fact]
    public void When_the_collection_does_not_know_the_origin_type_it_replaces_it_with_a_default_value()
    {
        var collection = getCollection(defaultValue: "someDefaultType");

        Assert.Equal("someDefaultType", collection.GetTypeForSqlType("unknownType", 0, 0, 0, false));
    }
}