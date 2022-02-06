using genny.BL.Entities;
using genny.Interfaces.Entities;
using Xunit;

namespace genny.BL.Tests.Entites;

public class DatabaseObjectTests
{
    [Fact]
    public void ConstructionTest()
    {
        var o = new DatabaseObject(
            "Schema",
            "Name",
            Array.Empty<IDatabaseColumn>()
        );
        
        Assert.Equal("Schema", o.Schema);
        Assert.Equal("Name", o.Name);
        Assert.Empty(o.Columns);
    } 
}