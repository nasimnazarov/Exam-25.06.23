namespace Domain.Dtos;

public class DepartmentEmployeeDto
{

    public int EmployeeId { get; set; }
    
    public int DepartmentId { get; set; }
    
    public DateTime FromDate { get; set; }
    
    public DateTime ToDate { get; set; }
}