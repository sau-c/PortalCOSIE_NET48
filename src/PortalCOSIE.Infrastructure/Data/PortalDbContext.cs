using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalCOSIE.Domain.Entities;

namespace PortalCOSIE.Infrastructure.Data
{
    public class PortalDbContext : DbContext
    {
        public PortalDbContext() : base("name=DefaultConnection") { }

        public DbSet<Rol> Rol { get; set; }
    }
}
