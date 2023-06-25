using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace Domain.Entities;

public class DepartmentManager
{
    public int EmployeeId { get; set; }
    [Required]
    public int DepartmentId { get; set; }
    [Required]
    public DateTime FromDate { get; set; }
    [Required]
    public DateTime ToDate { get; set; }
    public Employee Employee { get; set; }
    public Department Department { get; set; }
}