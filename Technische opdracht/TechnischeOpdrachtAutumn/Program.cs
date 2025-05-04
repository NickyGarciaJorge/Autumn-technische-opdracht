using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using TechnischeOpdrachtAutumn.Components;
using TechnischeOpdrachtAutumn.Helpers;
using TechnischeOpdrachtAutumn.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<UserRegistrationState>();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<RegistrationService>();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

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
