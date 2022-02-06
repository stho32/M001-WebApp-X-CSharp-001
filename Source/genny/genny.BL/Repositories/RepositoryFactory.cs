using genny.Interfaces;
using genny.Interfaces.Repositories;

namespace genny.BL.Repositories;

public class RepositoryFactory : IRepositoryFactory
{
    public RepositoryFactory(
        IConnectionDescriptionRepository connectionDescriptionRepository,
        IDatabaseObjectRepository databaseObjectRepository)
    {
        ConnectionDescriptionRepository = connectionDescriptionRepository;
        DatabaseObjectRepository = databaseObjectRepository;
    }

    public IConnectionDescriptionRepository ConnectionDescriptionRepository { get; }
    public IDatabaseObjectRepository DatabaseObjectRepository { get; }
    
}