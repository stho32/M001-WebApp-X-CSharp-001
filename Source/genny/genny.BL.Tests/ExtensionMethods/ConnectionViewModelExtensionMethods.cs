using genny.BL.Entities;
using genny.BL.ExtensionMethods;
using genny.Interfaces.Entities;
using Xunit;

namespace genny.BL.Tests.ExtensionMethods;

public class ConnectionViewModelExtensionMethods 
{
    [Fact]
    public void ToViewModels_Converts_Entities_To_ViewModels()
    {
        IConnectionDescription[] connectionDescriptions = new IConnectionDescription[]
        {
            new ConnectionDescription("Name1", "String1"),
            new ConnectionDescription("Name2", "String2")
        };

        var viewModels = connectionDescriptions.ToViewModels();
        
        Assert.Equal("Name1", viewModels[0].ConnectionStringName);
        Assert.Equal("Name2", viewModels[1].ConnectionStringName);
    } 
}