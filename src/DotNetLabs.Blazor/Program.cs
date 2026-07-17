using DotNetLabs.Blazor;
using DotNetLabs.Blazor.Services.Labs.CancellationTokenLab;
using DotNetLabs.Blazor.Services.Labs.OptionsPatternLab;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<CancellationTokenLabRunner>();
builder.Services.AddScoped<OptionsPatternLabRunner>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
