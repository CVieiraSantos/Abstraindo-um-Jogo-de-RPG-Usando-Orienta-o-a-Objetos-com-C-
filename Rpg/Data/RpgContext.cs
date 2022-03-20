using Rpg.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Rpg
{
    public class RpgContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RpgDb;Integrated Security=true");
        }

        public DbSet<Arus> Arus { get; set; }
        
    }
}