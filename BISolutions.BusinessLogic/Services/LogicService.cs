using System.Text.Json;
using BISolutions.BusinessLogic.Interfaces;

namespace BISolutions.BusinessLogic.Services;

public class LogicService : ILogicService
{
    public string GetSumOddNumber(int[] numbers)
    {
        var sum = 0;

        var isSecondOdd = false;

        foreach (var number in numbers)
        {
            if (number % 2 != 0)
            {
                if (isSecondOdd)
                {
                    sum += number;

                    isSecondOdd = false;
                    
                    continue;
                }
                
                isSecondOdd = true;
            }
        }

        var jsonSum = JsonSerializer.Serialize(Math.Abs(sum));

        return jsonSum;
    }

    public string IsStringPalindrome(string str)
    {
        var isPalindrome = true;
        
        for(var i = 0; i < str.Length / 2; i++)   
        {
            if(str[i] != str[str.Length-1-i]) 
            {
                isPalindrome = false;
                break;
            }
        }

        var jsonIsPalindrome = JsonSerializer.Serialize(isPalindrome);
        
        return jsonIsPalindrome;
    }

    public string SortList(List<int> numbers)
    {
        for (var i = 0; i < numbers.Count; i++)
        {
            for (var j = 0; j < numbers.Count - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    (numbers[j + 1], numbers[j]) = (numbers[j], numbers[j + 1]);
                }
            }
        }

        var jsonResultList = JsonSerializer.Serialize(numbers);

        return jsonResultList;
    }
}