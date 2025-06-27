using PortalCOSIE.Domain.Entities;
using PortalCOSIE.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Infrastructure.Data
{
    public class PortalDbContext : DbContext
    {
        public PortalDbContext() : base("name=DefaultConnection") { }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Facultad> Facultades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RolConfiguration());
            modelBuilder.Configurations.Add(new FacultadConfiguration());
        }
    }
}
