using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext :DbContext
{
    private readonly DbContextOptions<DataContext> _options;

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        _options = options;
    }
    //Tables////////////////////////////////DbSet

    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentEmployee> DepartmentEmployees { get; set; }
    public DbSet<DepartmentManager> DepartmentManagers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartmentManager>().HasKey(k => new { k.EmployeeId, k.DepartmentId });
        modelBuilder.Entity<DepartmentEmployee>().HasKey(k => new { k.EmployeeId, k.DepartmentId });
        base.OnModelCreating(modelBuilder);
    }
}
