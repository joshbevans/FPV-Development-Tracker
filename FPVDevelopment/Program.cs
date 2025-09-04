using FPVDevelopment.Components;
using FPVDevelopment.Components.Data;
using FPVDevelopment.Components.Data.Classes;
using FPVDevelopment.Components.Services;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("Default")
    ?? throw new NullReferenceException("No connection string");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContextFactory<FPVDbContext>((DbContextOptionsBuilder options) => 
    options.UseSqlServer(connectionString));

builder.Services.AddSingleton<CompletedRunService>();
builder.Services.AddSingleton<DroneService>();
builder.Services.AddSingleton<MapService>();
builder.Services.AddSingleton<UserService>();

builder.Services.AddSingleton<CurrentUser>();
builder.Services.AddMudServices();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
