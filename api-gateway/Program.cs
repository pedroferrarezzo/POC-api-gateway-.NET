var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddHttpClient("default", client =>
{
    client.BaseAddress = new Uri("http://localhost:5000");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/api1", async (IHttpClientFactory httpClientFactory) =>
{
    var client = httpClientFactory.CreateClient("default");
    var response = await client.GetAsync("/apis/api1");
    var content = await response.Content.ReadAsStringAsync();
    return Results.Ok(content);
});

app.MapGet("/api2", async (IHttpClientFactory httpClientFactory) =>
{
    var client = httpClientFactory.CreateClient("default");
    var response = await client.GetAsync("/apis/api2");
    var content = await response.Content.ReadAsStringAsync();
    return Results.Ok(content);
});

app.Run();