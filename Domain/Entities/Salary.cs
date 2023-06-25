using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class Salary
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int EmployeeId { get; set; }
    [Required]
    public int Amount { get; set; }
    [Required]
    public DateTime FromDate { get; set; }
    [Required]
    public DateTime ToDate { get; set; }
    public Employee Employee { get; set; }
}