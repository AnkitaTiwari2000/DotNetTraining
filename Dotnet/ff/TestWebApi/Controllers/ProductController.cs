using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.Data;
using TestWebApi.Model;

namespace TestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
      
            private readonly ProductContext _context;
            public ProductController(ProductContext context)
            {
                _context = context;
            }
            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    var product = _context.Products.ToList();
                    if (product.Count == 0)
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
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                try
                {
                    var product = _context.Products.Find(id);
                    if (product == null)
                    {
                        return NotFound($"Product details not found with id {id}");
                    }
                    return RedirectToAction("Get");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            [HttpPost]
            public IActionResult Create(ProductModel model)
            {
                try
                {
                    _context.Add(model);
                    _context.SaveChanges();
                    return Ok("Product Created.");
                }

                catch (Exception ex)
                {

                    return BadRequest(ex.Message);

                }
            }
            [HttpPut]
            public IActionResult Put(ProductModel model)
            {
                if (model == null || model.Id == 0)
                {
                    if (model == null)
                    {
                        return BadRequest("Model dats is invalid");

                    }
                    else if (model.Id == 0)
                    {
                        return BadRequest($"Product Id{model.Id} is invalid");
                    }
                }
                try
                {
                    var product = _context.Products.Find(model.Id);
                    if (product == null)
                    {
                        return NotFound($"Product not found with id{model.Id}");
                    }
                    product.Name = model.Name;
                    product.Price = model.Price;
                    product.Qty = model.Qty;
                    _context.SaveChanges();
                    return Ok("Product details update.");
                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }
    }
}
