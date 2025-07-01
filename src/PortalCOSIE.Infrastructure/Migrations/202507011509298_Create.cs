namespace PortalCOSIE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permiso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.RolPermiso",
                c => new
                    {
                        Rol_Id = c.Int(nullable: false),
                        Permiso_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rol_Id, t.Permiso_Id })
                .ForeignKey("dbo.Rol", t => t.Rol_Id, cascadeDelete: true)
                .ForeignKey("dbo.Permiso", t => t.Permiso_Id, cascadeDelete: true)
                .Index(t => t.Rol_Id)
                .Index(t => t.Permiso_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "RolId", "dbo.Rol");
            DropForeignKey("dbo.RolPermiso", "Permiso_Id", "dbo.Permiso");
            DropForeignKey("dbo.RolPermiso", "Rol_Id", "dbo.Rol");
            DropIndex("dbo.RolPermiso", new[] { "Permiso_Id" });
            DropIndex("dbo.RolPermiso", new[] { "Rol_Id" });
            DropIndex("dbo.Usuario", new[] { "RolId" });
            DropTable("dbo.RolPermiso");
            DropTable("dbo.Usuario");
            DropTable("dbo.Rol");
            DropTable("dbo.Permiso");
        }
    }
}
