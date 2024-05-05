using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PDV_backEnd.Models;

namespace PDV_backEnd.Data.Map
{
    public class TracadoMap : IEntityTypeConfiguration<TracadoModel>
    {
        public void Configure(EntityTypeBuilder<TracadoModel> builder)
        {
            builder.HasKey(x => x.TRA_ID);
            builder.Property(x => x.TRA_NOME).IsRequired().HasMaxLength(50);
            builder.Property(x => x.TRA_DATA_ESTREIA).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PIL_VENCEDOR);
            builder.Property(x => x.EQI_VENCEDORA);
            builder.Property(x => x.CLI_CLIMA);
            builder.Property(x => x.SEN_SENTIDO);
            builder.Property(x => x.KAR_KARTODROMO);
            builder.Property(x => x.CAL_NUMERO_ETAPA);
            builder.Property(x => x.MV_ESTREIA);
            builder.Property(x => x.MV_RECORD);
        }
    }
}
