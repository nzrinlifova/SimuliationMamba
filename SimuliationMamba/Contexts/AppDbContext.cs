using Microsoft.EntityFrameworkCore;
using SimuliationMamba.Models;

namespace SimuliationMamba.Contexts
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString = @"Server=DESKTOP-KA8SSD4;Database=ManbaDb;Trusted_connection=True;TrustServerCertificate=True";
        public DbSet<Team> Teams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);

        }
    }
}
