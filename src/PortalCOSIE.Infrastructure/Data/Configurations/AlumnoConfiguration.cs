using PortalCOSIE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class AlumnoConfiguration : EntityTypeConfiguration<Alumno>
    {
        public AlumnoConfiguration()
        {
            ToTable("Alumno")
                .HasKey(a => a.Id);

            Property(a => a.NumeroBoleta)
                .IsRequired()
                .HasMaxLength(20);

            Property(a => a.FechaIngreso)
                .IsRequired();

            Property(a => a.CarreraId)
                .IsRequired();

            Property(a => a.PlanEstudioId)
                .IsRequired();

            HasRequired(a => a.Carrera)
                .WithMany()
                .HasForeignKey(a => a.CarreraId)
                .WillCascadeOnDelete(false);

            HasRequired(a => a.PlanEstudio)
                .WithMany()
                .HasForeignKey(a => a.PlanEstudioId)
                .WillCascadeOnDelete(false);
        }
    }
}