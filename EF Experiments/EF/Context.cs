using EF_Experiments.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_Experiments.EF
{
    public class Context : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EFExperiments");
            //optionsBuilder.UseSqlite(
            //   "Data Source=EfExperiments.db");
        }

    }
}
