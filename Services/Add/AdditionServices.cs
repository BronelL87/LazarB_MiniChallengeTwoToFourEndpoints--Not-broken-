using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallengeTwoToFourEndpoints.Services.Add;

namespace LazarB_MiniChallengeTwoToFourEndpoints.Services
{
    public class AdditionServices : IAdditionServices
    {
        public string AddNumbers(string num1, string num2)
        {
            int numOne;
            int numTwo;
            if(int.TryParse(num1, out numOne) && int.TryParse(num2, out numTwo))
            {
                   int sum = numOne + numTwo;    
                   return $"the answer is {sum}";   
            }
            else{
                return "not the correct format";
            }

        }
    }
}