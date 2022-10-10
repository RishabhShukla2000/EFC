using EFC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFC
{
    public class EmployeeContext : DbContext 

    {
        public EmployeeContext(DbContextOptions options) : base(options)   
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
