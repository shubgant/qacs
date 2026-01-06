using DependencyInjectionDemo.Services;
using DependencyInjectionDemo.Models;


var builder = WebApplication.CreateBuilder(args);

// Bind configuration to a strongly typed class
//builder.Services.Configure<GreetingSettings>(
//    builder.Configuration.GetSection("GreetingSettings"));

// Add services to the container.
builder.Services.AddScoped<IGreetingService, GreetingService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
