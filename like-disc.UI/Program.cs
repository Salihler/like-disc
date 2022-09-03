using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using like_disc.Ui.Data;
using like_disc.Service.Services.HttpServices;
using like_disc.Core.Contexts.HttpClients;
using like_disc.Core.Models;
using like_disc.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient<TokenService>();
builder.Services.AddHttpClient<AlbumService>();

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton(typeof(ISpotifyService<>), typeof(SpotifyService<>));
builder.Services.AddSingleton<ITokenService, TokenService>();
builder.Services.AddSingleton<IAlbumService, AlbumService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
