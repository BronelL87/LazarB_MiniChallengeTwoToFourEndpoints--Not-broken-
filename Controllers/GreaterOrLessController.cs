
using LazarB_MiniChallengeTwoToFourEndpoints.Services.Add.GreaterOrLess;
using Microsoft.AspNetCore.Mvc;


namespace LazarB_MiniChallengeTwoToFourEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessController : Controller
{
    private readonly IGreaterOrLessServices _greaterOrLessServices;

    public GreaterOrLessController(IGreaterOrLessServices greaterOrLessServices)
    {
        _greaterOrLessServices = greaterOrLessServices;
    }

    [HttpGet]
    [Route("GreaterOrLess/{userNum1}/{userNum2}")]
    public string CompareNumbers(string userNum1, string userNum2){
        return _greaterOrLessServices.CompareNumbers(userNum1, userNum2);
    }
}
