using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class FacultadConfiguration : EntityTypeConfiguration<Facultad>
    {
        public FacultadConfiguration()
        {
            ToTable("Facultad")
                .HasKey(r => r.Id);

            Property(r => r.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            Property(r => r.Descripcion)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
