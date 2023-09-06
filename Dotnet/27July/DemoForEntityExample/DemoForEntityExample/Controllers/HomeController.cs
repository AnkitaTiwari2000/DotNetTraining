using Microsoft.AspNetCore.Mvc;
using MyApp.Model;
using MyAppDB;
using MyAppDB.DBConnection;

namespace DemoForEntityExample.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDeposite deposite = null;
        public HomeController() { 
            deposite=new EmployeeDeposite();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeModels model)
        {
            if (ModelState.IsValid)
            {
              int id=  deposite.AddEmployee(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.Issuccess = "Data Added";
                }
            }
            return View();
        }
    }
}
