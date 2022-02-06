using genny.BL.ViewModels;
using Xunit;

namespace genny.BL.Tests.ViewModels;

public class ConnectionViewModelTests
{
    [Fact]
    public void Construction_test()
    {
        var o = new ConnectionViewModel("Hello");

        Assert.Equal("Hello", o.ConnectionStringName);
    }
}