using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PDV_backEnd.Models;

namespace PDV_backEnd.Data.Map
{
    public class StatusMap : IEntityTypeConfiguration<StatusModel>
    {
        public void Configure(EntityTypeBuilder<StatusModel> builder)
        {
            builder.HasKey(x => x.STA_ID);
            builder.Property(x => x.STA_ATIVO);
            builder.Property(x => x.STA_DESC).HasMaxLength(15);
        }
    }
}
