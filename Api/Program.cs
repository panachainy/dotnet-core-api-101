using Api.Modules.Weather.Controllers;
using Api.Modules.Weather.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IWeatherService, WeatherService>();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    Console.WriteLine("[IsDevelopment]: ", app.Environment.IsDevelopment());
    app.MapOpenApi();
}


// FIXME: Not sure we should have redirect http -> https here or network level?
// if (!app.Environment.IsDevelopment())
// {
//     app.UseHttpsRedirection();
// }


app.MapGet("/api/healthz", () =>
{
    return Results.Ok("Healthy");
});

app.MapControllers();

app.Run();
