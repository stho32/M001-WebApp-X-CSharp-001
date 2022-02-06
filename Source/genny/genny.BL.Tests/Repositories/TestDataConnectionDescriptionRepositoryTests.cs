using genny.BL.Repositories;
using Xunit;

namespace genny.BL.Tests.Repositories;

public class TestDataConnectionDescriptionRepositoryTests
{
    [Fact]
    public void Gives_us_three_samples_for_connection_data()
    {
        var repository = new TestDataConnectionDescriptionRepository();
        var data = repository.GetList();
        Assert.Equal(3, data.Length);
    } 
}