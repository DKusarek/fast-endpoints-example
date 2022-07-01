// See https://aka.ms/new-console-template for more information
using FastEndpoints;
using FastEndpoints.Swagger;

Console.WriteLine("Hello, World!");

var builder = WebApplication.CreateBuilder();

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();
var app = builder.Build();

app.UseAuthorization();
app.UseFastEndpoints();
app.UseOpenApi();
app.UseSwaggerUi3(x => x.ConfigureDefaults());

app.Run();