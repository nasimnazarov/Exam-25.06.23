using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class Employee
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
    [MaxLength(100),Required]
    public string FirstName { get; set; }
    [MaxLength(100),Required]
    public string LastName { get; set; }
    [Required]
    public int Gender { get; set; }
    [Required]
    public DateTime HireDate { get; set; }
    public List<DepartmentEmployee> DepartmentEmployee { get; set; }
    public List<DepartmentManager> DepartmentManager { get; set; }
    public List<Salary> Salary { get; set; }
}