using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class RolConfiguration : EntityTypeConfiguration<Rol>
    {
        public RolConfiguration()
        {
            ToTable("Rol")
            .HasKey(r => r.Id);

            Property(r => r.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            Property(r => r.Descripcion)
            .HasMaxLength(250);

            //Esto nos ayuda a quitar la convencion plural (PermisoRols)
            HasMany(r => r.Permisos)
            .WithMany(p => p.Roles)
            .Map(m =>
            {
                m.ToTable("PermisoRol");
                m.MapLeftKey("RolId");
                m.MapRightKey("PermisoId");
            });
        }
    }
}
