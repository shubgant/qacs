using DotNetCore.CAP;
using EventSubscriber.Models;
using Microsoft.EntityFrameworkCore;
using EventSubscriber.EventSubscribers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EventBusContextContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EventBusDBConnectionString")));


builder.Services.AddCap(options =>
{
    options.UseEntityFramework<EventBusContextContext>();

    options.UseRabbitMQ(options =>
    {
        options.ConnectionFactoryOptions = options =>
        {
            //options.Ssl.Enabled = false;
            options.HostName = "localhost";
            //options.UserName = "guest";
            //options.Password = "guest";
            //options.Port = 5672;
        };
    });
});


builder.Services.AddScoped<OrderPlacedEventSubscriber>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.Run();


