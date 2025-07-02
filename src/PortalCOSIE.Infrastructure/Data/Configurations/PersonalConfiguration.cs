using PortalCOSIE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalCOSIE.Infrastructure.Configurations
{
    public class PersonalConfiguration : EntityTypeConfiguration<Personal>
    {
        public PersonalConfiguration()
        {
            ToTable("Personal")
                .HasKey(p => p.Id);

            Property(p => p.IdPersonal)
                .HasMaxLength(20);
        }
    }
}