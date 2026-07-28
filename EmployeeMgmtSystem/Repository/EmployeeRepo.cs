using EmployeeMgmtSystem.DAL;
using EmployeeMgmtSystem.Models;
using System.Net;

namespace EmployeeMgmtSystem.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        EmployeeDbContext _context;
        public EmployeeRepo(EmployeeDbContext context) 
        {
            _context = context;
        }
        async Task<int> IEmployeeRepo.Create(Employee obj)
        {
            _context.Employees.Add(obj);
            return await _context.SaveChangesAsync();
        }

        List<Employee> IEmployeeRepo.GetAll()
        {
            List<Employee> ls = _context.Employees.ToList();
            return ls;
        }

        List<Employee> IEmployeeRepo.Search(string name)
        {
            return  _context.Employees.Where(x => x.EmpName.Equals(name)).ToList();
        }
    }
}
