using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Store.Service.Contract;
using Store.Web;
using Store.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IProductService, ApiProductServer>();


builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5043/api/")
});
builder.Services.AddMudServices();


await builder.Build().RunAsync();
