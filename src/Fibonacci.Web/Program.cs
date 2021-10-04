using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello TOTO, how are you today?");
app.MapGet("/Fibonacci", async () => await Fibonacci.Compute.ExecuteAsync(new[]{"44","43"}));

app.Run();
