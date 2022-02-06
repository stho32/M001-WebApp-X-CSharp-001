using genny.BL;
using genny.BL.ExtensionMethods;
using genny.BL.ViewModels;
using genny.Interfaces;
using genny.Interfaces.Repositories;
using genny.Interfaces.ViewModels;
using Microsoft.AspNetCore.Components;

namespace genny.Blazor.Pages;

public partial class CodeGenerator 
{
    [Inject]
    protected IRepositoryFactory? RepositoryFactory { get; set; }
    
    [Parameter]
    public string? SelectedConnection
    {
        get => _viewModel?.SelectedConnection;
        set
        {
            if (_viewModel != null) 
                _viewModel.SelectedConnection = value;
        }
    }

    private CodeGeneratorViewModel? _viewModel;
    
    protected override void OnInitialized()
    {
        if (RepositoryFactory == null)
            throw new NullReferenceException(nameof(RepositoryFactory));
        
        var connections = RepositoryFactory.ConnectionDescriptionRepository.GetList();
        
        _viewModel = new CodeGeneratorViewModel(
            connections.FirstOrDefault()?.ConnectionStringName, 
            connections.ToViewModels());
        
        base.OnInitialized();
    }
}