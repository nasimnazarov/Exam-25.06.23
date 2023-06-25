using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Microsoft.AspNetCore.Components.Route("[controller]")]

public class EmployeeController
{
    private readonly EmployeeService _employeeService;

    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    [HttpGet("GetEmployees")]
    public List<Employee> GetEmployees()
    {
        return _employeeService.GetEmployees();
    }

    [HttpPost("AddEmployees")]
    public AddEmployeeDto AddEmployee(AddEmployeeDto model)
    {
        return _employeeService.AddEmployee(model);
    }
    [HttpDelete("DeleteEmployee")]
    public bool DeleteEmployee(int id)
    {
        return _employeeService.DeleteEmployee(id);
    }
}