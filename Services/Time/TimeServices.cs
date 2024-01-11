using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace LazarB_MiniChallengeTwoToFourEndpoints.Services.Add.Time
{
    public class TimeServices : ITimeServices
    {
        public string NameTime(string name, string wakeTime){
        
            return $"Your name is {name} and you woke up at {wakeTime}";
        }
    
    }


}