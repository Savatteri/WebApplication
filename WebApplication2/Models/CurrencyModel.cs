using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication2.Repositories;

namespace WebApplication2.Models
{
    public class CurrencyModel
    {
        public RatesModel Rates { get; set; }
        //[JsonIgnore] //
        public string Base { get; set; }
        public string Date { get; set; }
    }
}