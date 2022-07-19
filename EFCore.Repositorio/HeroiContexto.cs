using EFCore.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repositorio
{
    public class HeroiContexto : DbContext
    {

        public HeroiContexto(DbContextOptions<HeroiContexto> options) : base(options)
        {

        }

        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroiBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }


        //Define as chaves compostas para uma tabela de relacionamento
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }
    }
}
