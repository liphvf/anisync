using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using AnySync.Brazor.Data;
using AnySync.Brazor.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using AnySync.Brazor.AppSettings;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<KitsuService>();
string? connectionString = builder.Configuration.GetSection("DatabaseConnectionString")?.Value;

// var applicationSettings = new ApplicationSettings();
// builder.Configuration.Bind(applicationSettings);
// builder.Services.AddSingleton(applicationSettings);

builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql(connectionString
, o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)).UseSnakeCaseNamingConvention());

builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<DatabaseContext>();
    context.Database.EnsureCreated();
    // DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
