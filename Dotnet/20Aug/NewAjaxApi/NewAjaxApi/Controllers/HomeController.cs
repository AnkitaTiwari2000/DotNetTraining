using Microsoft.AspNetCore.Mvc;
using NewAjaxApi.Models;
using Newtonsoft.Json.Serialization;
using System.Diagnostics;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using NewAjaxApi.Data;

namespace NewAjaxApi.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {

            return View();
        }
        public JsonResult GetProduct()
        {
           // var sa = new JsonSerializerSettings();
            ProductSam psm = new ProductSam()
            {
                Id = 1,
                Name = "Mobile",
                Descr = "Use For Call",
                Price = 23.0
            };

          // var json = JsonConvert.SerializeObject(psm);
            return Json(psm);
        }
        public  JsonResult AddProduct(ProductSam product)
        {
            return Json("true");
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