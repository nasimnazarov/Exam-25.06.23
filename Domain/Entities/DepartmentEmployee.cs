using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class DepartmentEmployee
{
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    public int DepartmentId { get; set; }
    [Required]
    public DateTime FromDate { get; set; }
    [Required]
    public DateTime ToDate { get; set; }
    public Department Department { get; set; }
    public Employee Employee { get; set; }
}