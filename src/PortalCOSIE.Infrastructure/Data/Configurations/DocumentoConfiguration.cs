using PortalCOSIE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class DocumentoConfiguration : EntityTypeConfiguration<Documento>
    {
        public DocumentoConfiguration()
        {
            ToTable("Documento")
                .HasKey(d => d.Id);

            Property(d => d.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            Property(d => d.Comentario)
                .HasMaxLength(250);

            Property(d => d.TramiteId)
                .IsRequired();

            HasRequired(d => d.Tramite)
                .WithMany()
                .HasForeignKey(d => d.TramiteId)
                .WillCascadeOnDelete(false);
        }
    }
}