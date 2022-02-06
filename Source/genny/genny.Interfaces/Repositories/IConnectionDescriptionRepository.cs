using genny.Interfaces.Entities;

namespace genny.Interfaces.Repositories;

public interface IConnectionDescriptionRepository
{
    IConnectionDescription[] GetList();
}