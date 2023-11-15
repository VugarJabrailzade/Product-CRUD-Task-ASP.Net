using Microsoft.EntityFrameworkCore;
using Task1_asp.Net.Database.Models;

namespace Task1_asp.Net.Database
{
    public class PustokDbContext : DbContext
    {
        public PustokDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }

        public DbSet<Navbar> Navbars { get; set; }

    }
}
