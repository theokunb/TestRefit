using Ocelot.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var app = builder.Build();

services.AddOcelot();

app.MapGet("/", () => "Hello World!");

app.Run();
