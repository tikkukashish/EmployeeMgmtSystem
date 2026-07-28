using EmployeeMgmtSystem.Models;

namespace EmployeeMgmtSystem.Repository
{
    public interface IEmployeeRepo
    {
        public List<Employee> GetAll();
        public Task<int> Create(Employee obj);
        public List<Employee> Search(string name);
    }
}
