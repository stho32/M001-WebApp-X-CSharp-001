using genny.BL.TypeConversion;
using Xunit;

namespace genny.BL.Tests.TypeConversion;

public class FromSqlFromSqlTypeConverterTests 
{
    [Fact]
    public void When_given_the_input_type_the_output_type_is_returned()
    {
        var converter = new FromSqlTypeConverter("Input", "Output");
        Assert.Equal("Output", converter.GetTypeForSqlType("Input", 0, 0, 0, false));
    }

    [Fact]
    public void When_the_input_type_is_not_correct_then_null_is_returned()
    {
        var converter = new FromSqlTypeConverter("NotTheRightInput", "Output");
        Assert.Null(converter.GetTypeForSqlType("Input", 0, 0, 0, false));
    }
}