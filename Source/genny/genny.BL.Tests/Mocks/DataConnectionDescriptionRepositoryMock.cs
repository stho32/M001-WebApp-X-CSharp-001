using genny.BL.Entities;
using genny.Interfaces.Entities;
using genny.Interfaces.Repositories;

namespace genny.BL.Tests.Mocks;

public class DataConnectionDescriptionRepositoryMock : IConnectionDescriptionRepository
{
    public IConnectionDescription[] GetList()
    {
        return new IConnectionDescription[]
        {
            new ConnectionDescription("Test01", "Connection01")
        };
    }
}