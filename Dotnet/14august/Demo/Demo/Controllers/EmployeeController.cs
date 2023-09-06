using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmpContext _context;

        public EmployeeController(EmpContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
             var emp = _context.Employees.ToList();
            return View(emp);
        }
        public IActionResult Create()
        {
           // ViewBag.data = _context.Employees.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Save(Employee emp)
        {
            if (emp.Id == 0 )
            {

                Address ad=new Address();
                _context.Address
                emp.address.Id = Guid.NewGuid();
                _context.Employees.Add(emp);
                _context.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
    }
}
