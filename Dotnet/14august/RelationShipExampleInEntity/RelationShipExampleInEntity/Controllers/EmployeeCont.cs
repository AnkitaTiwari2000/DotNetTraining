using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelationShipExampleInEntity.data;
using RelationShipExampleInEntity.Models;
using System.Linq;

namespace RelationShipExampleInEntity.Controllers
{
    public class EmployeeCont : Controller
    {
        EmpdbContext empdbContext;
        public EmployeeCont(EmpdbContext empdbContext)
        {
            this.empdbContext = empdbContext;
        }
        public IActionResult Index(String search)
        {
            
            var employees = empdbContext.Employees.Include(e => e.address);
            return View(employees.Where(x=>x.Name.Contains(search)||search==null).ToList());
            // Console.WriteLine(result);
//             return View(result);
        }
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Address a)
        {
            empdbContext.Add(a);
            empdbContext.SaveChanges();
            ViewBag.success = "Address Has Been Added";
            
            ModelState.Clear();
            
            return View();
        }
        public IActionResult CreateEmp()
        {
            ViewBag.getaddress = empdbContext.Addresses.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmp(Employee emp)
        {
            empdbContext.Add(emp);
            empdbContext.SaveChanges();
            TempData["AlertMessage"] = "Employee is Added!!! ";
            ModelState.Clear();
            
            return RedirectToAction("CreateEmp");
        }
        public IActionResult Delete(int Id)
        {
            var res = empdbContext.Employees.Where(x => x.Id == Id).FirstOrDefault();
            empdbContext.Employees.Remove(res);
            empdbContext.SaveChanges();
            TempData["AlertMessage"] = " Listis Deleted!!! ";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            ViewBag.getaddress = empdbContext.Addresses.ToList();
            var res = empdbContext.Employees.Where(x => x.Id == Id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            var res = empdbContext.Employees.Where(x => x.Id == emp.Id).FirstOrDefault();
            res.Name = emp.Name;
            res.EmployeeMob = emp.EmployeeMob;
            empdbContext.SaveChanges();
            TempData["AlertMessage"] = " Listis Edited!!! ";
            return RedirectToAction("Index");
        }
        public IActionResult ShowData(int Id)
        {
            var employees = empdbContext.Employees.Include(e => e.address);
            Console.WriteLine(employees.ToList()); 
            var res = empdbContext.Employees.Where(x => x.Id == Id).FirstOrDefault();
            return View(res);
        }

    }
}
