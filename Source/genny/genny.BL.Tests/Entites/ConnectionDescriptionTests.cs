using genny.BL.Entities;
using Xunit;

namespace genny.BL.Tests.Entites;

public class ConnectionDescriptionTests
{
    [Fact]
    public void Construction_test()
    {
        var connectionDescription = new ConnectionDescription(
            "Name", "Connection");
        
        Assert.Equal("Name", connectionDescription.ConnectionStringName);
        Assert.Equal("Connection", connectionDescription.ConnectionString);
    }
}
