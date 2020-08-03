using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ExchangeModels
    {
        
        [Required(ErrorMessage = "Value is required")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Base Currency is required")]
        [StringLength(3, ErrorMessage = "Only 3 haracters are accept")]
        public string FromCurrency { get; set; }

        [StringLength(3, ErrorMessage = "Only 3 haracters are accept")]
        [Required(ErrorMessage = "Final Currency is required")]
        public string ToCurrency { get; set; }
       
    }

}
