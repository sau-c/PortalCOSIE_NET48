using PortalCOSIE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class TramiteConfiguration : EntityTypeConfiguration<Tramite>
    {
        public TramiteConfiguration()
        {
            ToTable("Tramite")
                .HasKey(t => t.Id);

            Property(t => t.AlumnoId)
                .IsRequired();

            Property(t => t.PersonalId)
                .IsRequired();

            Property(t => t.FechaSolicitud)
                .IsRequired();

            Property(t => t.FechaConclusion)
                .IsRequired();

            HasRequired(t => t.Alumno)
                .WithMany()
                .HasForeignKey(t => t.AlumnoId)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.Personal)
                .WithMany()
                .HasForeignKey(t => t.PersonalId)
                .WillCascadeOnDelete(false);
        }
    }
}