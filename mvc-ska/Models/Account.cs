using System.ComponentModel.DataAnnotations;

namespace mvc_ska.Models;

public class Account
{
    public int id { get; set; }
    [Range(0, 1E+17)]
    public decimal amount { get; set; }
    [Required]
    public DateTime date { get; set; }
    [Required]
    public string remark { get; set; }
}