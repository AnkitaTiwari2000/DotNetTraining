using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserManageMentApi.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.seedRoles(builder);



        }
        private void seedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole() { Name="Admin",NormalizedName="Admin"},
            new IdentityRole() { Name="User",NormalizedName="User"},
            new IdentityRole() { Name = "hr", NormalizedName = "HR" }
                );
        }
    }
}
