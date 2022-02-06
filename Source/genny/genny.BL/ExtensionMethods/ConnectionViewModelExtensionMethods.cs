using genny.BL.ViewModels;
using genny.Interfaces;
using genny.Interfaces.Entities;
using genny.Interfaces.ViewModels;

namespace genny.BL.ExtensionMethods;

public static class ConnectionViewModelExtensionMethods
{
    public static IConnectionViewModel[] ToViewModels(this IConnectionDescription[] connectionDescriptions)
    {
        var result = new List<IConnectionViewModel>();
        
        foreach (var connectionDescription in connectionDescriptions)
        {
            result.Add(new ConnectionViewModel(connectionDescription.ConnectionStringName));
        }

        return result.ToArray();
    }
}