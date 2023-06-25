using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Services;

public class EmployeeService
{
    private readonly DataContext _context;

    public EmployeeService(DataContext context)
    {
        _context = context;
    }

    public List<Employee> GetEmployees()
    {
        return _context.Employees.ToList();
    }

    public AddEmployeeDto AddEmployee(AddEmployeeDto model)
    {
        var employee = new Employee()
        {
            Id = model.Id,
            BirthDate = model.BirthDate,
            FirstName = model.FirstName,
            LastName = model.LastName,
            HireDate = model.HireDate,
        };
        _context.Employees.Add(employee);
        _context.SaveChanges();
        return model;
    }
    public bool DeleteEmployee(int id)
    {
        var book = _context.Employees.Find(id);
        _context.Employees.Remove(book);
        var result = _context.SaveChanges();
        return result == 1;
    }

}