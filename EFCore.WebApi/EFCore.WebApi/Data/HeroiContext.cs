using System;
using EFCore.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using MySql;
namespace EFCore.WebApi.Data

{
    public class HeroiContext : DbContext 
    {
        public DbSet<Heroi>  Herois { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<HeroiBatalha> heroiBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=EFFramework;user=root;password=sa1234");
        }

    }

    
}
