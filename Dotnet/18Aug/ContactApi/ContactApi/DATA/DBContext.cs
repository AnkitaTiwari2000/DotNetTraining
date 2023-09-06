using ContactAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.DATA
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }
        public  DbSet<Contact> Contacts { get; set; }
    }
}
