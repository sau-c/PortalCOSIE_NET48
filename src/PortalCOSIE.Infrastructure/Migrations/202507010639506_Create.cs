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
            DropForeignKey("dbo.RolPermiso", "Permiso_Id", "dbo.Permiso");
            DropForeignKey("dbo.RolPermiso", "Rol_Id", "dbo.Rol");
            DropIndex("dbo.RolPermiso", new[] { "Permiso_Id" });
            DropIndex("dbo.RolPermiso", new[] { "Rol_Id" });
            DropTable("dbo.RolPermiso");
            DropTable("dbo.Rol");
            DropTable("dbo.Permiso");
        }
    }
}
