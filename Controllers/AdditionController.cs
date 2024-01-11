using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallengeTwoToFourEndpoints.Services.Add;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarB_MiniChallengeTwoToFourEndpoints.Controllers
{
    [Route("[controller]")]
    public class AdditionController : Controller
    {
        private readonly IAdditionServices _additionServices;

        public AdditionController(IAdditionServices additionServices)
        {
            _additionServices = additionServices;

        }
        
        [HttpGet]
        [Route("Addition/{num1}/{num2}")]

        public string AddNumbers(string num1, string num2){
            return _additionServices.AddNumbers (num1, num2);
        }

    
    }
}