using EntityEx.Data;
using EntityEx.Models;

using Microsoft.AspNetCore.Mvc;

namespace EntityEx.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext db;
        public EmployeeController(EmployeeDBContext _db) {
            this.db = _db;
        }

        public IActionResult Index()
        {
            var result = db.Employees.ToList();
            //Console.WriteLine(result);
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateEmployeeViewModel createEmployeeRequest, Guid guid)
        {
            var employee = new EmployeModel()
            {
                
                Name = createEmployeeRequest.Name,
                Salary = createEmployeeRequest.Salary
            };

            db.Employees.Add(employee);
            db.SaveChanges();
          
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var res=db.Employees.Where(x => x.Id == Id).FirstOrDefault();
            db.Employees.Remove(res);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            var res = db.Employees.Where(x => x.Id == Id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit(EmployeModel emp)
        {
            var res = db.Employees.Where(x => x.Id == emp.Id).FirstOrDefault();
            res.Name = emp.Name;
            res.Salary = emp.Salary;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ShowData(int Id)
        {
            var res = db.Employees.Where(x => x.Id == Id).FirstOrDefault();
            return View(res);
        }

    }
}
