using Microsoft.EntityFrameworkCore;
using ApiProject.Models;

namespace ApiProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Model> Model { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            => optionsBuilder.useSqlite(connectionstring: "DataSource=app.db;Cache=Shared");
        }
    }
}
