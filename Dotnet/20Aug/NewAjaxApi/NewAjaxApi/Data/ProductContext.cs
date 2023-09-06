using Microsoft.EntityFrameworkCore;
using NewAjaxApi.Models;

namespace NewAjaxApi.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ProductSam> ProductSams { get; set; }
    }
}
