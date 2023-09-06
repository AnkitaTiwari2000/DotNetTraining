using CRUDinEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDinEntityFramework.Data
{
    public class DBContextEx : DbContext
    {
       
            public DBContextEx(DbContextOptions options) : base(options)
            {
            }
            public DbSet<UserModel> UserTb { get; set; }
        
    }
}
