using System.ComponentModel.DataAnnotations;

namespace BISolutions.Common.DTOs;

public class GetSumDto
{
    [Required]
    public int[]? Numbers;
}