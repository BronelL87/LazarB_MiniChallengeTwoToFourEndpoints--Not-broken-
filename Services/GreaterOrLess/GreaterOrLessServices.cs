
namespace LazarB_MiniChallengeTwoToFourEndpoints.Services.Add.GreaterOrLess;

public class GreaterOrLessServices : IGreaterOrLessServices
{
    public string CompareNumbers(string userNum1, string userNum2)
    {
        int userNumOne;
        int userNumTwo;

        if (int.TryParse(userNum1, out userNumOne) && int.TryParse(userNum2, out userNumTwo) && (userNumOne > userNumTwo))
        {


            return $"{userNumOne} is greater than {userNumTwo}. {userNumTwo} is less than {userNumOne}.";



        }
        else if (int.TryParse(userNum1, out userNumOne) && int.TryParse(userNum2, out userNumTwo) && (userNumTwo > userNumOne))
        {
            return $"{userNumOne} is less than {userNumTwo}. {userNumTwo} is greater than {userNumOne}.";
        }
        else if (int.TryParse(userNum1, out userNumOne) && int.TryParse(userNum2, out userNumTwo) && (userNumOne == userNumTwo))
        {
            return $"{userNumOne} is equal to {userNumTwo}. Therefore {userNumOne} is neither greater than or less than {userNumTwo} and vice versa.";
        }
        else
        {
            return "Incorrect format";
        }
    }
}


