using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PDV_backEnd.Models;

namespace PDV_backEnd.Data.Map
{
    public class KartodromoMap : IEntityTypeConfiguration<KartodromoModel>
    {
        public void Configure(EntityTypeBuilder<KartodromoModel> builder)
        {
            builder.HasKey(x => x.KAR_ID);
            builder.Property(x => x.KAR_NOME).IsRequired().HasMaxLength(130);
            builder.Property(x => x.KAR_NOMECURTO).IsRequired().HasMaxLength(60);
            builder.Property(x => x.KAR_APELIDO).IsRequired().HasMaxLength(20);
            builder.Property(x => x.CID_KARTODROMO);
        }
    }
}
