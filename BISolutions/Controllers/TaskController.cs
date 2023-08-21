using BISolutions.BusinessLogic.Interfaces;
using BISolutions.Common.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BISolutions.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly ILogicService _logicService;
    private readonly IDisplayService _displayService;

    public TaskController(ILogicService logicService, IDisplayService displayService)
    {
        _logicService = logicService;
        _displayService = displayService;
    }
    
    [HttpPost("getSum")]
    public IActionResult GetSum(GetSumDto getSumDto)
    {
        if (ModelState.IsValid)
        {
            var jsonSum = _logicService.GetSumOddNumber(getSumDto.Numbers);
        
            return Ok(_displayService.DisplayResultFor_GetSumOddNumber(jsonSum));
        }

        return BadRequest();
    }
    
    [HttpPost("isPalindrome")]
    public IActionResult IsPalindrome(IsStringPalindromeDto isStringPalindromeDto)
    {
        if (ModelState.IsValid)
        {
            var jsonIsPalindrome = _logicService.IsStringPalindrome(isStringPalindromeDto.Str);
        
            return Ok(_displayService.DisplayResultFor_IsStringPalindrome(jsonIsPalindrome));
        }

        return BadRequest();
    }
    
    [HttpPost("sortList")]
    public IActionResult SortList(SortListDto sortListDto)
    {
        if (ModelState.IsValid)
        {
            var jsonSortedList = _logicService.SortList(sortListDto.list);

            return Ok(_displayService.DisplayResultFor_SortList(jsonSortedList));
        }
        
        return BadRequest();
    }
}