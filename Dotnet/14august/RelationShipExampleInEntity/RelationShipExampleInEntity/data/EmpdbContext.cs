using Microsoft.EntityFrameworkCore;
using RelationShipExampleInEntity.Models;

namespace RelationShipExampleInEntity.data
{
    public class EmpdbContext:DbContext
    {
        public EmpdbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
