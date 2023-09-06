using CRUDinEntityFramework.Data;
using CRUDinEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDinEntityFramework.Controllers
{
    public class UserController : Controller
    {
        private readonly DBContextEx  _context;
        public UserController(DBContextEx context)
        { _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
               try
                {
                    var user = _context.UserTb.ToList();
                    if (user.Count == 0)
                    {
                        return NotFound("Product Not available");
                    }
                    return Ok("Result");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            
        }
        [HttpPost]
        public IActionResult Create(UserModel model)
        {
                  model.Id = 1;
           
            _context.UserTb.Add(model);

                _context.SaveChanges();
                return Ok("Product Created.");
            

           
            
        }
    }
}
