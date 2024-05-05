using Microsoft.EntityFrameworkCore;
using PDV_backEnd.Data.Map;
using PDV_backEnd.Models;
using System.Runtime.InteropServices;

namespace PDV_backEnd.Data
{
    public class PDVDbContext : DbContext
    {
        public PDVDbContext(DbContextOptions<PDVDbContext> options) : base(options) { }

        //public DbSet<CalendarioModel> Calendario { get; set; }
        //public DbSet<CidadeModel> Cidades { get; set; }
        //public DbSet<ClimaModel> Clima {  get; set; }
        //public DbSet<EquipeModel> Equipes { get; set; }
        public DbSet<KartodromoModel> Kartodromos { get; set; }
        //public DbSet<Melhor_VoltaModel> Melhor_Volta { get; set; }
        //public DbSet<PilotoModel> Pilotos { get; set; }
        //public DbSet<SentidoModel> Sentido { get; set; }
        public DbSet<StatusModel> Status { get; set; }
        public DbSet<TemporadaModel> Temporadas { get; set; }
        public DbSet<TracadoModel> Tracados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KartodromoMap());
            modelBuilder.ApplyConfiguration(new StatusMap());
            modelBuilder.ApplyConfiguration(new TemporadaMap());
            modelBuilder.ApplyConfiguration(new TracadoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
