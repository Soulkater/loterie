using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class appDbContext : DbContext
    {
        public appDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Partie> Partie { get; set; } 
        public DbSet<Tirage> Tirage { get; set; } 
    }
}