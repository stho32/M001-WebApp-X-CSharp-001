using genny.BL.CodeGeneration;
using genny.BL.TypeConversion;
using genny.BL.ViewModels;
using genny.Interfaces.CodeGeneration;
using genny.Interfaces.Repositories;
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

    [Parameter]
    public string? SelectedObject
    {
        get => _viewModel?.SelectedObject;
        set
        {
            if (_viewModel != null)
                _viewModel.SelectedObject = value;
        }
    }

    private CodeGeneratorViewModel? _viewModel;
    
    protected override void OnInitialized()
    {
        if (RepositoryFactory == null)
            throw new NullReferenceException(nameof(RepositoryFactory));
        
        var connections = RepositoryFactory.ConnectionDescriptionRepository.GetList();

        var generatorCollection = new List<ICodeGenerator>();
        
        generatorCollection.Add(new EntityInterfaceCodeGenerator(
            new CSharpFromSqlTypeConverterCollection()
            ));
        
        _viewModel = new CodeGeneratorViewModel(
            connections.FirstOrDefault()?.ConnectionStringName, 
            connections,
            RepositoryFactory.DatabaseObjectRepository,
            generatorCollection.ToArray());
        
        base.OnInitialized();
    }
}