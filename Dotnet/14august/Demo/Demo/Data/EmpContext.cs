using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class EmpContext: DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
