using PortalCOSIE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class PlanEstudioConfiguration : EntityTypeConfiguration<PlanEstudio>
    {
        public PlanEstudioConfiguration()
        {
            ToTable("PlanEstudio")
                .HasKey(p => p.Id);

            Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Descripcion)
                .HasMaxLength(250);
        }
    }
}