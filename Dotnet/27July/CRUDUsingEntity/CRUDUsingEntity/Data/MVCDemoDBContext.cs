using CRUDUsingEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDUsingEntity.Data
{
    public class MVCDemoDBContext : DbContext
    {
        public MVCDemoDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<StudentModel> MyProperty { get; set; }
    }
}

