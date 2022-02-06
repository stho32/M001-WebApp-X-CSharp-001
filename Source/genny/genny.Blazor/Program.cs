using genny.BL.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using genny.Blazor;
using genny.Interfaces.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddSingleton<IRepositoryFactory>(x => new RepositoryFactory(
    new TestDataConnectionDescriptionRepository(),
    new TestDataDatabaseObjectRepository()
    ));

await builder.Build().RunAsync();