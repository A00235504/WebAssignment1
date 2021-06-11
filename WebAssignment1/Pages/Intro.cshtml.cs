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
                //performing calculations on the two inputs
                //saving the result in result variable
                result = InputNumber1 * InputNumber2;
  
        }
        //getting data from the Input1
        [FromQuery(Name = "InputNumber1")]

        //creating a variable of int type for input1
        public int InputNumber1 { get; set; }

        //getting data from the Input2 for input2
        [FromQuery(Name = "InputNumber2")]

        //creating a variable of int type
        public int InputNumber2 { get; set; }

        //creating a variable of int type for result
        public int result { get; set; }

        
    }
}
