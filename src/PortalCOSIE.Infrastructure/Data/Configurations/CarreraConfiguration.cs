using PortalCOSIE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class CarreraConfiguration : EntityTypeConfiguration<Carrera>
    {
        public CarreraConfiguration()
        {
            ToTable("Carrera")
                .HasKey(c => c.Id);

            Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Descripcion)
                .HasMaxLength(250);
        }
    }
}