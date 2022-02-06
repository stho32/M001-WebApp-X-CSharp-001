using genny.BL.Entities;
using genny.Interfaces.Entities;
using genny.Interfaces.Repositories;

namespace genny.BL.Repositories;

public class TestDataConnectionDescriptionRepository : IConnectionDescriptionRepository
{
    public IConnectionDescription[] GetList()
    {
        var result = new List<IConnectionDescription>();

        result.Add(new ConnectionDescription("Anwendung1", "a-connection-string"));
        result.Add(new ConnectionDescription("Anwendung2", "Anwendung2Connection"));
        result.Add(new ConnectionDescription("Anwendung3", "another-connection-string"));

        return result.ToArray();
    }
}