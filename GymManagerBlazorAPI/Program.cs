using AdventureManagerBlazorAPI;
using AdventureManagerBlazorAPI.Serivces.Implement;
using AdventureManagerBlazorAPI.Serivces.Interface;
using GymManagerBlazorAPI;
using GymManagerBlazorAPI.Serivces.Implement;
using GymManagerBlazorAPI.Serivces.Interface;
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
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7191") });

await builder.Build().RunAsync();
