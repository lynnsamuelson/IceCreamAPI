using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IceCreamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IceCreamController : ControllerBase
    {

        private static readonly string[] Flavors = new[]
        {
            "Chocolate", "Butter Pecan", "Vanilla", "Strawberry", "Latte", "Cookies and Cream", "Pistachio Almond", "Rum Raison", "Bannan Pudding", "Peach"
        };

        // GET: api/<IceCreamController>
        [HttpGet]
        public IEnumerable<IceCream> Get()
        {
            var rng = new Random();
          
            return Enumerable.Range(1, 5).Select(index => new IceCream
            {
                Flavor = Flavors[rng.Next(Flavors.Length)]
            })
           .ToArray();
          
        }

        // GET api/<IceCreamController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IceCreamController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IceCreamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IceCreamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
