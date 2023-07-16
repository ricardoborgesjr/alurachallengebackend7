using alurachallengebackend7.Models;
using Microsoft.EntityFrameworkCore;

namespace alurachallengebackend7.Data
{
    public class DepoimentoContext : DbContext
    {
        public DepoimentoContext(DbContextOptions<DepoimentoContext> options) : base(options)
        {

        }

        public DbSet<Depoimento> Depoimentos { get; set; }
    }
}