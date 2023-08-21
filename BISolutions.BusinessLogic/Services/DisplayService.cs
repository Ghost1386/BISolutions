using System.Text.Json;
using BISolutions.BusinessLogic.Interfaces;

namespace BISolutions.BusinessLogic.Services;

public class DisplayService : IDisplayService
{
    public string DisplayResultFor_GetSumOddNumber(string jsonSum)
    {
        var sum = JsonSerializer.Deserialize<int>(jsonSum);
        
        return $"Сумма чисел равна {sum}";
    }

    public string DisplayResultFor_IsStringPalindrome(string jsonIsPalindrome)
    {
        var isPalindrome = JsonSerializer.Deserialize<bool>(jsonIsPalindrome);
        
        if (isPalindrome)
        {
            return "Строка является палиндромом";
        }
                
        return "Строка не является палиндромом";
    }

    public string DisplayResultFor_SortList(string jsonSortedList)
    {
        var sortedList = JsonSerializer.Deserialize<List<int>>(jsonSortedList);

        var sortedListInString = string.Empty;

        foreach (var num in sortedList)
        {
            sortedListInString += num + " ";
        }

        return sortedListInString;
    }
}