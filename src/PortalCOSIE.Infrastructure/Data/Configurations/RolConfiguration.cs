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

        }
    }
}
