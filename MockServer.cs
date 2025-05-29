#:sdk Microsoft.NET.Sdk.Web
#:package Microsoft.AspNetCore.OpenApi 10.0.0-preview.4.25258.110
#:package Scalar.AspNetCore 2.4.4

using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Scalar.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference("/");

var mockdata = File.ReadAllText("people.json");
var people = JsonSerializer.Deserialize<List<Person>>(mockdata, JsonSerializerOptions.Web) ?? [];

app.MapGet("/people", (string? search) =>
{
    var matchingPeople = string.IsNullOrEmpty(search)
        ? people
        : [.. people.Where(p => p.FullName.Contains(search, StringComparison.OrdinalIgnoreCase))];

    return TypedResults.Ok(matchingPeople);  
});

app.Run();

record Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Address { get; set; }

    [JsonIgnore]
    public string FullName => $"{FirstName} {LastName}";
}