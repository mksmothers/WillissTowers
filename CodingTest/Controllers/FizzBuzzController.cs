using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Controllers
{
    public class FizzBuzzController : Controller
    {
        public IActionResult Index()        {
         
            var retVal = new Dictionary<int, string>();
            const string fiz = "Fizz";
            const string buzz = "Buzz";

            for (int i = 1; i<=100; i ++)
            {               
                var result = new StringBuilder();

                if (i % 3 == 0)             
                    result.Append(fiz);              

                if (i % 5 == 0)              
                    result.Append(buzz);   

                retVal.Add(i, result.ToString());
            }

            return View(retVal);
        }
    }
}