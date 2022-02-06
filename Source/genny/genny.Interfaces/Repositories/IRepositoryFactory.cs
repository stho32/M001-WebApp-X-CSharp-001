namespace genny.Interfaces.Repositories;

public interface IRepositoryFactory
{
    IConnectionDescriptionRepository ConnectionDescriptionRepository { get; }
    IDatabaseObjectRepository DatabaseObjectRepository { get; }
}