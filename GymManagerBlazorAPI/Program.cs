using AdventureBUS.Serivces.Implement;
using AdventureBUS.Serivces.Interface;
using AdventureDAL.Implement;
using AdventureDAL.Interface;
using AdventureManagerBlazorAPI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IGuideService, GuideService>();
builder.Services.AddScoped<IParticipantService, ParticipantService>();
builder.Services.AddScoped<IOrganismService, OrganismService>();;
builder.Services.AddScoped<IDialogService, DialogService>();
builder.Services.AddScoped<IParticipantInteractionService, ParticipantInteractionService>();
builder.Services.AddScoped<IAdventureService, AdventureService>();
builder.Services.AddScoped<IApiService, ApiService>();
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7191") });

await builder.Build().RunAsync();
