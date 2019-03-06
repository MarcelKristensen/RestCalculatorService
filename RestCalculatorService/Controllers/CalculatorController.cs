using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCalculatorService.Model;

namespace RestCalculatorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET: api/Calculator
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Calculator/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Calculator Add
        [HttpPost("Add", Name = "Add")]
        public int Post([FromBody] Data data)
        {
            return data.A + data.B;
        }

        // POST: api/Calculator Sub
        [HttpPost("Subtract", Name = "Subtract")]
        public int Sub([FromBody] Data data)
        {
            return data.A - data.B;
        }

        // POST: api/Calculator Multi
        [HttpPost("Multiply", Name = "Multiply")]
        public int Multiply([FromBody] Data data)
        {
            return data.A * data.B;
        }

        // POST: api/Calculator Divide
        [HttpPost("Divide", Name = "Divide")]
        public int Divide([FromBody] Data data)
        {
            return data.A / data.B;
        }

        // POST: api/Calculator
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Calculator/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
