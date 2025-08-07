var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var apiGroup = app.MapGroup("/apis");

apiGroup.MapGet("/api1", () => GetAPI1.Retorno)
        .WithName("GetAPI1");

apiGroup.MapGet("/api2", () => GetAPI2.Retorno)
        .WithName("GetAPI2");

app.Run();

record GetAPI1()
{
    public static object Retorno => new { message = "Resposta da API 1" };
}

record GetAPI2()
{
    public static object Retorno => new { message = "Resposta da API 2" };
}
