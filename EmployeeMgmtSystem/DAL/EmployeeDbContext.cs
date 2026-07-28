using EmployeeMgmtSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeMgmtSystem.DAL
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options): base(options) 
        {
       
        }
        public DbSet<Employee> Employees { get; set; }
    }
    
    
}
