using EmployeeMgmtSystem.Models;
using EmployeeMgmtSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace EmployeeMgmtSystem.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepo _employeeRepo;

        public EmployeeController(IEmployeeRepo repo)
        {
            _employeeRepo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Employee> employees = _employeeRepo.GetAll();
            ViewBag.Employees = employees;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            List<Employee> lssearch= _employeeRepo.Search(search);
            return View(lssearch);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee obj)
        {
            int res = await _employeeRepo.Create(obj);
            if (res > 0)
            {
                return RedirectToAction("Index");
            }
            else return View();
        }

    }
}
