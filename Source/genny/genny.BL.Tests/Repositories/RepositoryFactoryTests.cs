using genny.BL.Repositories;
using Xunit;

namespace genny.BL.Tests.Repositories;

public class RepositoryFactoryTests
{
    [Fact]
    public void gives_us_access_to_the_repositories_we_passed_at_the_beginning()
    {
        var factory = new RepositoryFactory(
            new TestDataConnectionDescriptionRepository(),
            new TestDataDatabaseObjectRepository());
        
        Assert.IsType<TestDataConnectionDescriptionRepository>(factory.ConnectionDescriptionRepository);
    }
}