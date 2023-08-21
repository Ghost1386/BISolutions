using System.ComponentModel.DataAnnotations;

namespace BISolutions.Common.DTOs;

public class IsStringPalindromeDto
{
    [Required]
    public string? Str { get; set; }
}