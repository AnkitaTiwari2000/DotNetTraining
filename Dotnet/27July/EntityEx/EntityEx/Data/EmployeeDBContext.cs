using EntityEx.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace EntityEx.Data
{
    public class EmployeeDBContext : DbContext
    {
        
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
            
        }
        public DbSet<EmployeModel> Employees{ get; set; }
    }
}
