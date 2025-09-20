using Microsoft.EntityFrameworkCore;

namespace CardsTournament.Models
{
    public class GreedDbContext : DbContext
    {
        public GreedDbContext(DbContextOptions<GreedDbContext> options) : base(options) { }
        public DbSet<Card> Cards { get; set; }
    }
}
