using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallengeTwoToFourEndpoints.Services.Add
{
    public interface IAdditionServices
    {
        string AddNumbers(string num1, string num2);
    }
}