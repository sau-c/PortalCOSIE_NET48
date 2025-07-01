using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("Usuario")
            .HasKey(r => r.Id);

            Property(r => r.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            Property(r => r.ApellidoPaterno)
            .IsRequired()
            .HasMaxLength(50);

            Property(r => r.ApellidoMaterno)
            .IsRequired()
            .HasMaxLength(50);

            Property(r => r.Correo)
            .IsRequired()
            .HasMaxLength(100);

            Property(u => u.Celular)
            .HasMaxLength(20);

            HasRequired(u => u.Rol)
            .WithMany(r => r.Usuarios)
            .HasForeignKey(u => u.RolId)
            .WillCascadeOnDelete(false); // Puedes cambiar esto según tu lógica
        }
    }
}
