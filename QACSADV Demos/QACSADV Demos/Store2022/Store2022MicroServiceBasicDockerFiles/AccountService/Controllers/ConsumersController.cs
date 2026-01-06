using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccountService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountService.Controllers
{
    [Route("api/[controller]")]
    public class ConsumersController : Controller
    {
        // GET: api/consumers
        [HttpGet("Names")]
        public IEnumerable<string> GetNames()
        {
            return new string[] { "Jemermy", "Bob", "Mary" };
        }

        [HttpGet]
        public IEnumerable<Consumer> GetConsumers()
        {
            //stub
            //method would actually make SQL READ all from database

            var consumers = new List<Consumer>(){
                new Consumer()
                {
                    Id = 111,
                    Firstname = "Jeremy",
                    Surname = "Cook",
                    Age = 20
                },
                new Consumer(){
                    Id = 112,
                    Firstname = "Bob",
                    Surname = "Smith",
                    Age = 43
                },
                new Consumer(){
                    Id = 113,
                    Firstname = "John",
                    Surname = "Doe",
                    Age = 21
                },
                new Consumer(){
                    Id = 114,
                    Firstname = "Mary",
                    Surname = "Doe",
                    Age = 45
                }
            };
            return consumers;
        }

        // GET: api/consumers/5
        [HttpGet("{id}")]
        public ActionResult<Consumer> GetConsumerById(int id)
        {
            var consumer = new Consumer()
            {
                Id = 111,
                Firstname = "Jeremy",
                Surname = "Cook",
                Age = 20
            };

            return consumer;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
