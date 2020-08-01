using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ExchangeModels
    {
        //It must to be int value; but the json method that i'm using doesn't support int
        // thecodebuzz.com/json-value-could-not-be-converted-to-system-string/
        public double Value { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
       
    }

}
