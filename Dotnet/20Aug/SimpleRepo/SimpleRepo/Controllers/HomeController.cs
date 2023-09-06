using Microsoft.AspNetCore.Mvc;
using SimpleRepo.Models;
using SimpleRepo.Repositry;
using System.Diagnostics;

namespace SimpleRepo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRep studentRep;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            studentRep = new StudentRep();
        }
        public List<Stud> getAllStudents()
        {
            return studentRep.getAllStudents();
        }
        public Stud getStudent(int id) { 

            return studentRep.getStudent(id);
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
    }
}