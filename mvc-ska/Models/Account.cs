using System.ComponentModel.DataAnnotations;

namespace mvc_ska.Models;

public class Account
{
    public int Id { get; set; }
    [Range(0, 1E+17)]
    public decimal Amount { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public string Remark { get; set; }
}