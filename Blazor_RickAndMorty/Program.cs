using Blazor_RickAndMorty;
using Blazor_RickAndMorty.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registrar o HttpClient com o base address padr�o
builder.Services.AddHttpClient<IRickAndMortyService, RickAndMortyService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

// N�o � necess�rio registrar HttpClient separadamente se voc� j� fez isso acima
// builder.Services.AddHttpClient();

await builder.Build().RunAsync();
