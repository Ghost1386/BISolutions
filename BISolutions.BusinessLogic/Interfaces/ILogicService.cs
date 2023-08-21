namespace BISolutions.BusinessLogic.Interfaces;

public interface ILogicService
{
    string GetSumOddNumber(int[] numbers);

    string IsStringPalindrome(string str);

    string SortList(List<int> numbers);
}