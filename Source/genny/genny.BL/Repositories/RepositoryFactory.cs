using genny.Interfaces;
using genny.Interfaces.Repositories;

namespace genny.BL.Repositories;

public class RepositoryFactory : IRepositoryFactory
{
    public RepositoryFactory(IConnectionDescriptionRepository connectionDescriptionRepository)
    {
        ConnectionDescriptionRepository = connectionDescriptionRepository;
    }

    public IConnectionDescriptionRepository ConnectionDescriptionRepository { get; }
}