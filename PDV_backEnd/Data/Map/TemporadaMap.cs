using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PDV_backEnd.Models;

namespace PDV_backEnd.Data.Map
{
    public class TemporadaMap : IEntityTypeConfiguration<TemporadaModel>
    {
        public void Configure(EntityTypeBuilder<TemporadaModel> builder)
        {
            builder.HasKey(x => x.TEM_ID);
            builder.Property(x => x.TEM_NUMTEM).IsRequired();
            builder.Property(x => x.TEM_NOME).IsRequired().HasMaxLength(25);
            builder.Property(x => x.TEM_ETAPAS).IsRequired();
            builder.Property(x => x.TEM_INICIO).IsRequired().HasMaxLength(20);
            builder.Property(x => x.TEM_FINAL).IsRequired().HasMaxLength(20);
            builder.Property(x => x.TEM_ANO).IsRequired();
        }
    }
}