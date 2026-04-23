var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMongoClient>(
    new MongoClient(builder.Configuration["Mongo:ConnectionString"])
);

var app = builder.Build();

app.MapGet("/products", () => new[] { "Product1", "Product2" });

app.Run();