#:package Bogus 35.6.3
using System.Text.Json;
using Bogus;

if(!int.TryParse(args.FirstOrDefault(), out var count))
{
  count = 50; 
}   



Console.WriteLine($"Generating {count} fake people...");

var people = new Faker<Person>()
    .RuleFor(p => p.FirstName, f => f.Name.FirstName())
    .RuleFor(p => p.LastName, f => f.Name.LastName())
    .RuleFor(p => p.Email, (f, p) => f.Internet.Email(p.FirstName, p.LastName))
    .RuleFor(p => p.Address, f => f.Address.FullAddress())
    .Generate(count);

    var json = JsonSerializer.Serialize(people, new JsonSerializerOptions
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    });

    File.WriteAllText("people.json", json); 

    Console.WriteLine($"Generated {count} fake people and saved to 'people.json'.");

record Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Address { get; set; }
}