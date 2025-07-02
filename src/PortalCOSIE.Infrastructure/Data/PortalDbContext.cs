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
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<PlanEstudio> PlanesEstudio { get; set; }
        public DbSet<Tramite> Tramites { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Personal> Personales { get; set; }
        public DbSet<Acceso> Accesos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RolConfiguration());
            modelBuilder.Configurations.Add(new PermisoConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new AlumnoConfiguration());
            modelBuilder.Configurations.Add(new CarreraConfiguration());
            modelBuilder.Configurations.Add(new PlanEstudioConfiguration());
            modelBuilder.Configurations.Add(new TramiteConfiguration());
            modelBuilder.Configurations.Add(new DocumentoConfiguration());
            modelBuilder.Configurations.Add(new PersonalConfiguration());
            modelBuilder.Configurations.Add(new AccesoConfiguration());
        }
    }
}
