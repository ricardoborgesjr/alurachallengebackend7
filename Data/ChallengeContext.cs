using alurachallengebackend7.Models;
using Microsoft.EntityFrameworkCore;

namespace alurachallengebackend7.Data
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext(DbContextOptions<ChallengeContext> options) : base(options)
        {

        }

        public DbSet<Depoimento> Depoimentos { get; set; }
        public DbSet<Destino> Destinos { get; set; }
    }
}