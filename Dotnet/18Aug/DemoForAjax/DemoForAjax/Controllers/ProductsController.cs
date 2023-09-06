using DemoForAjax.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoForAjax.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public List<Product> GetProducts()
        {
            return Product.GetProducts();
        }
      
        [HttpGet]
        [Route("GetById/{productId}")]
        public Product GetProductById(int productId)
        {
            return ProductList().FirstOrDefault(x => x.ProductId == productId);
        }


    }
}
