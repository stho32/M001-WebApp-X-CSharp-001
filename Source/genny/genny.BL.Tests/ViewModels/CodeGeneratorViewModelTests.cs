using genny.BL.Entities;
using genny.BL.Repositories;
using genny.BL.Tests.Mocks;
using genny.BL.ViewModels;
using genny.Interfaces.Entities;
using genny.Interfaces.Repositories;
using Xunit;

namespace genny.BL.Tests.ViewModels;

public class CodeGeneratorViewModelTests
{
    private IRepositoryFactory TestFactory()
    {
        return new RepositoryFactory(
            new DataConnectionDescriptionRepositoryMock(),
            new DatabaseObjectRepositoryMock()
            );
    }
    
    [Fact]
    public void When_constructed_without_a_preselected_connection_no_database_objects_are_listed()
    {
        var factory = TestFactory();
        
        var codegen = new CodeGeneratorViewModel(
            "",
            factory.ConnectionDescriptionRepository.GetList(),
            factory.DatabaseObjectRepository,
            null
        );
        
        Assert.Empty(codegen.DatabaseObjects);
    }

    [Fact]
    public void When_constructed_the_selectedConnection_Information_is_kept()
    {
        var factory = TestFactory();
        
        var codegen = new CodeGeneratorViewModel(
            "Test01",
            factory.ConnectionDescriptionRepository.GetList(),
            factory.DatabaseObjectRepository,
            null
        );
        
        Assert.Equal("Test01", codegen.SelectedConnection);
    }

    [Fact]
    public void When_a_connection_is_selected_then_the_database_objects_are_retrieved()
    {
        var factory = TestFactory();
        
        var codegen = new CodeGeneratorViewModel(
            "Test01",
            factory.ConnectionDescriptionRepository.GetList(),
            factory.DatabaseObjectRepository,
            null
        );
        
        Assert.NotEmpty(codegen.DatabaseObjects);
    }

    [Fact]
    public void The_initialization_of_the_available_connections_works()
    {
        var factory = TestFactory();
        
        var codegen = new CodeGeneratorViewModel(
            "",
            new IConnectionDescription[]
            {
                new ConnectionDescription("Alpha", "AlphaConnection"),
                new ConnectionDescription("Beta", "BetaConnection"),
            },
            factory.DatabaseObjectRepository,
            null
        );
        
        Assert.Equal("Alpha", codegen.AvailableConnections[0].ConnectionStringName);
        Assert.Equal("Beta", codegen.AvailableConnections[1].ConnectionStringName);
    }
}