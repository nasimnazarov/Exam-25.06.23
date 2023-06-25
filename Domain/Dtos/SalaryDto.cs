using System.ComponentModel.DataAnnotations;

public class SalaryDto
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public int Amount { get; set; }
}