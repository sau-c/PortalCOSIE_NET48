using PortalCOSIE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class AccesoConfiguration : EntityTypeConfiguration<Acceso>
    {
        public AccesoConfiguration()
        {
            ToTable("Acceso")
                .HasKey(a => a.Id);

            Property(a => a.UserName)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.Contrasena)
                .IsRequired()
                .HasMaxLength(200);

            Property(a => a.UsuarioId)
                .IsRequired();

            HasRequired(a => a.Usuario)
                .WithMany()
                .HasForeignKey(a => a.UsuarioId)
                .WillCascadeOnDelete(false);
        }
    }
}