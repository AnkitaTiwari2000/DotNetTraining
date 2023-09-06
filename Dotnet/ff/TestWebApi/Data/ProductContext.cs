using Microsoft.EntityFrameworkCore;
using TestWebApi.Model;

namespace TestWebApi.Data
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
