using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingTestMVC.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        // TODO: 1. Fix bug
        private static Dictionary<int, string> Companies = null;
        public CompanyController()
        {
            Companies.Add(1, "Intelligent Industries");
            Companies.Add(2, "Microsoft");
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public Dictionary<int, string> Get()
        {
            return Companies;
        }

        // TODO: 2. Complete API Methods
        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CompanyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
