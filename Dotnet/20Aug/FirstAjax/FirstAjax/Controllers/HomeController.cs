using FirstAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public List<Employee> GetEmpList()
        {
            var empList = new List<Employee>()
    {
         new Employee { ID=1, Name="Manas"},
         new Employee { ID=2, Name="Tester"}
    };

            return empList;
        }
    }
}