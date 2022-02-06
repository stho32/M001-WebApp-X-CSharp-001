using genny.BL.Repositories;
using Xunit;

namespace genny.BL.Tests.Repositories;

public class TestDataDatabaseObjectRepositoryTests
{
    [Fact]
    public void Gives_us_something_to_play_with()
    {
        var repository = new TestDataDatabaseObjectRepository();
        var data = repository.GetList("Anwendung2Connection");
        Assert.Equal(2, data.Length);
    }

    [Fact]
    public void It_does_not_give_us_elements_when_requesting_for_a_connection_Other_than_Anwendung2()
    {
        var repository = new TestDataDatabaseObjectRepository();
        var data = repository.GetList("Anwendung1Connection");
        Assert.Empty(data);
    }
}