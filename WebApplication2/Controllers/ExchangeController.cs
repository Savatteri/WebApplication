using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WebApplication2.Models;
using WebApplication2.Services;


namespace WebApplication2.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class ExchangeController : Controller
    {
        ExchangeServices es = new ExchangeServices();

        // GET: api/<ExchangeController>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var ratesresulttest = await es.GetCurrenciesAsync("");
            //debug
            return Ok(ratesresulttest);
        }

        // GET api/<ExchangeController>/5
        [HttpGet("{baseCurrency}")]
        public async Task<IActionResult> GetAsync(string baseCurrency)
        {
            var ratesresulttest = await es.GetCurrenciesAsync(baseCurrency);
            //debug
            return Ok(ratesresulttest);
        }

        // POST api/<ExchangeController>
        [HttpPost]
        public async Task<IActionResult> PostExchangeModelsItemAsync([FromBody] ExchangeModels em)
        {
            var value = em.Value;
            var tocurrency = em.ToCurrency;
            //rateresult is a list of rates
            var ratesresult = await es.GetCurrenciesAsync(em.FromCurrency);
            var result = ratesresult.FindCurrency(tocurrency);
            result = result * value;
            return Ok(result);

        }


        // PUT api/<ExchangeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExchangeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    
}
