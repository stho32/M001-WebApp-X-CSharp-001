namespace genny.Interfaces.Repositories;

public interface IRepositoryFactory
{
    IConnectionDescriptionRepository ConnectionDescriptionRepository { get; }
}