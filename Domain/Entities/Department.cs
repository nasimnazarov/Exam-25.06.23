using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class Department
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100),Required]
    public string Name { get; set; }
    public List<DepartmentEmployee> DepartmentEmployee { get; set; }
    public List<DepartmentManager> DepartmentManager { get; set; }
}