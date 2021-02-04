using Microsoft.EntityFrameworkCore;
using piloto.Models;

namespace piloto.Data
{
    public class PilotoContext : DbContext
    {
        public PilotoContext(DbContextOptions<PilotoContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Piloto> piloto { get; set; }
    }
}