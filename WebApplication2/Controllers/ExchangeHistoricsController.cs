using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;


namespace WebApplication2.Controllers
{
    [Route("api/currencies/historics")]
    [ApiController]
    public class ExchangeHistoricsController : ControllerBase
    {
        ExchangeServices es = new ExchangeServices();
        
        // GET: api/<ExchangeHistoricsController>
        [HttpGet]
        public async Task<IActionResult> GetAsync1(int days)
        {
            var result = await es.GetHistoryAsync(0);
            return Ok(result);
        }

        // GET api/<ExchangeHistoricsController>/5
        [HttpGet("{days}")]
        public async Task<IActionResult> GetAsync(int days)
        {
            var result = await es.GetHistoryAsync(days);
            return Ok(result);
        }

        // POST api/<ExchangeHistoricsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExchangeHistoricsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExchangeHistoricsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
