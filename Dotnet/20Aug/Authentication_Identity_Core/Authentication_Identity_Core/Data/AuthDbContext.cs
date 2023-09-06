using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Authentication_Identity_Core.Data
{
    public class AuthDbContext:IdentityDbContext

    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
