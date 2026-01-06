using DependencyInjectionDemo.Models;
using Microsoft.Extensions.Options;

namespace DependencyInjectionDemo.Services
{
    public class GreetingService : IGreetingService
    {
        //private readonly GreetingSettings _settings;

        //public GreetingService(IOptions<GreetingSettings> options)
        //{
        //    _settings = options.Value;
        //}

        public string Greet(string name)
        {
            return $"Hello, {name}! Welcome to dependency injection in ASP.NET Core.";
            //return $"{_settings.Prefix}, {name}! {_settings.Suffix}";
        }
    }
}
