using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallengeTwoToFourEndpoints.Services.Add.Time;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarB_MiniChallengeTwoToFourEndpoints.Controllers;




    [Route("[controller]")]
    public class TimeController : Controller
    {
        private readonly ITimeServices _timeServices;

        public TimeController(ITimeServices timeServices)
        {
            _timeServices = timeServices;
        }
        [HttpGet]
        [Route("Time/{name}/{wakeTime}")]

        public string NameTime(string name, string wakeTime)
        {
            return _timeServices.NameTime(name, wakeTime);
        }
    }
