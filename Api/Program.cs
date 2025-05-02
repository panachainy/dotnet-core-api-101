using Api.Modules.Weather.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

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

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}


app.MapGet("/api/healthz", () =>
{
    return Results.Ok("Healthy");
});

app.MapControllers();

app.Run();
