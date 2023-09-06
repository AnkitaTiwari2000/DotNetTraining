using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace DemoForAjax.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
