﻿using Microsoft.EntityFrameworkCore;
using ApiProject.Models;

namespace ApiProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
        
    }
}
