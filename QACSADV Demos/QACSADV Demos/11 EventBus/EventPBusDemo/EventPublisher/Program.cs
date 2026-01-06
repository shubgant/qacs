using DotNetCore.CAP;
using EventPublisher.Models;
using Microsoft.EntityFrameworkCore;

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


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapPost("/order", async (ICapPublisher capPublisher, Order order) => {
    await capPublisher.PublishAsync("OrderPlaced", order);
});

app.Run();

//Code to install rabbitMQ:
//docker run -d --hostname my-rabit --name ecomm-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:management

