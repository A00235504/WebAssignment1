using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAssignment1.Pages
{
    public class IntroModel : PageModel
    {
        public void OnGet()
        {

                result = InputNumber1 * InputNumber2;
  
        }

        [FromQuery(Name = "InputNumber1")]

        public int InputNumber1 { get; set; }

        [FromQuery(Name = "InputNumber2")]

        public int InputNumber2 { get; set; }

        public int result { get; set; }

        
    }
}
