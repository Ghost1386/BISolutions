using System.ComponentModel.DataAnnotations;

namespace BISolutions.Common.DTOs;

public class SortListDto
{
    [Required]
    public List<int> list { get; set; }
}