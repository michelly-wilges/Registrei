namespace Registrei.Data
{
    using Microsoft.EntityFrameworkCore;
    using Registrei.Models;

    public class AppDbContext : DbContext
    {
        public DbSet<Servico> Servicos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
