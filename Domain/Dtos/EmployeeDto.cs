using System.ComponentModel.DataAnnotations;

public class EmployeeDto
{
    public int Id { get; set; }
    public DateTime BirthDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Gender { get; set; }
    public DateTime HireDate { get; set; }
}

public class AddEmployeeDto:EmployeeDto
{
    
}