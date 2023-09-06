using LogInForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;



namespace LogInForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDbContext context;
        public HomeController(UserDbContext context)
        {
            this.context = context;  
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserDetail user)
        {
            var Myuser=context.UserDetails.Where(x => x.Email==user.Email && x.Password == user.Password).FirstOrDefault(); 
            if (Myuser!=null)
            {
                
                HttpContext.Session.SetString("UserSession", Myuser.Email);
                return RedirectToAction("DashBoard");
            }
            else
            {
                ViewBag.Message = "Login Failed.....";
            }
           
            return View();
        }
        public IActionResult DashBoard()
        {
           if( HttpContext.Session.GetString("UserSession") != null){
                ViewBag.MySession = HttpContext.Session.GetString("UserSession").ToString();

            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Register()
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