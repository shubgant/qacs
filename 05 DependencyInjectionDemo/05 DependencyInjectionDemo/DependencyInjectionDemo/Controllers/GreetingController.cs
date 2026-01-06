using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService _greetingService;

        // Dependency injection via constructor
        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        [HttpGet("{name}")]
        public IActionResult GetGreeting(string name)
        {
            var message = _greetingService.Greet(name);
            return Ok(new { message });
        }
    }
}
