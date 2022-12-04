var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    return Results.Ok("Hello World");
});
app.MapGet("/{nome}", (string nome) => 
{
    return Results.Ok($"Hello {nome}");
});

app.MapPost("/", (User user) => 
{
    return Results.Ok($"Hello {user}");
});


app.Run();

public class User
{
    public int id { get; set; }
    public string UserName { get; set; }  
    
}