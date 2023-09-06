using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class AddressController : Controller
    {
        private readonly EmpContext _context;

        public AddressController(EmpContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var address = _context.Address.ToList();
            return View(address);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(Address address)
        {
            if(address.Id== 0)
            {
               _context.Address.Add(address);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
