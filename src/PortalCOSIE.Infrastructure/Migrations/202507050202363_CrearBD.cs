namespace PortalCOSIE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Acceso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 100),
                        Contrasena = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        ApellidoPaterno = c.String(nullable: false, maxLength: 50),
                        ApellidoMaterno = c.String(nullable: false, maxLength: 50),
                        Correo = c.String(nullable: false, maxLength: 100),
                        Celular = c.String(maxLength: 20),
                        RolId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rol", t => t.RolId)
                .Index(t => t.RolId);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(maxLength: 250),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permiso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Controlador = c.String(nullable: false, maxLength: 100),
                        Accion = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Carrera",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(maxLength: 250),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanEstudio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(maxLength: 250),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Documento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Comentario = c.String(maxLength: 250),
                        TramiteId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tramite", t => t.TramiteId)
                .Index(t => t.TramiteId);
            
            CreateTable(
                "dbo.Tramite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlumnoId = c.Int(nullable: false),
                        PersonalId = c.Int(nullable: false),
                        FechaSolicitud = c.DateTime(nullable: false),
                        FechaConclusion = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.AlumnoId)
                .ForeignKey("dbo.Personal", t => t.PersonalId)
                .Index(t => t.AlumnoId)
                .Index(t => t.PersonalId);
            
            CreateTable(
                "dbo.PermisoRol",
                c => new
                    {
                        RolId = c.Int(nullable: false),
                        PermisoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RolId, t.PermisoId })
                .ForeignKey("dbo.Rol", t => t.RolId, cascadeDelete: true)
                .ForeignKey("dbo.Permiso", t => t.PermisoId, cascadeDelete: true)
                .Index(t => t.RolId)
                .Index(t => t.PermisoId);
            
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NumeroBoleta = c.String(nullable: false, maxLength: 20),
                        FechaIngreso = c.DateTime(nullable: false),
                        CarreraId = c.Int(nullable: false),
                        PlanEstudioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .ForeignKey("dbo.Carrera", t => t.CarreraId)
                .ForeignKey("dbo.PlanEstudio", t => t.PlanEstudioId)
                .Index(t => t.Id)
                .Index(t => t.CarreraId)
                .Index(t => t.PlanEstudioId);
            
            CreateTable(
                "dbo.Personal",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        IdPersonal = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personal", "Id", "dbo.Usuario");
            DropForeignKey("dbo.Alumno", "PlanEstudioId", "dbo.PlanEstudio");
            DropForeignKey("dbo.Alumno", "CarreraId", "dbo.Carrera");
            DropForeignKey("dbo.Alumno", "Id", "dbo.Usuario");
            DropForeignKey("dbo.Documento", "TramiteId", "dbo.Tramite");
            DropForeignKey("dbo.Tramite", "PersonalId", "dbo.Personal");
            DropForeignKey("dbo.Tramite", "AlumnoId", "dbo.Alumno");
            DropForeignKey("dbo.Acceso", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "RolId", "dbo.Rol");
            DropForeignKey("dbo.PermisoRol", "PermisoId", "dbo.Permiso");
            DropForeignKey("dbo.PermisoRol", "RolId", "dbo.Rol");
            DropIndex("dbo.Personal", new[] { "Id" });
            DropIndex("dbo.Alumno", new[] { "PlanEstudioId" });
            DropIndex("dbo.Alumno", new[] { "CarreraId" });
            DropIndex("dbo.Alumno", new[] { "Id" });
            DropIndex("dbo.PermisoRol", new[] { "PermisoId" });
            DropIndex("dbo.PermisoRol", new[] { "RolId" });
            DropIndex("dbo.Tramite", new[] { "PersonalId" });
            DropIndex("dbo.Tramite", new[] { "AlumnoId" });
            DropIndex("dbo.Documento", new[] { "TramiteId" });
            DropIndex("dbo.Usuario", new[] { "RolId" });
            DropIndex("dbo.Acceso", new[] { "UsuarioId" });
            DropTable("dbo.Personal");
            DropTable("dbo.Alumno");
            DropTable("dbo.PermisoRol");
            DropTable("dbo.Tramite");
            DropTable("dbo.Documento");
            DropTable("dbo.PlanEstudio");
            DropTable("dbo.Carrera");
            DropTable("dbo.Permiso");
            DropTable("dbo.Rol");
            DropTable("dbo.Usuario");
            DropTable("dbo.Acceso");
        }
    }
}
