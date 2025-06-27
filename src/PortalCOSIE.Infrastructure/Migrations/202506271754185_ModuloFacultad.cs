namespace PortalCOSIE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModuloFacultad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facultad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        Creado = c.DateTime(nullable: false),
                        CreadoPor = c.String(),
                        Actualizado = c.DateTime(nullable: false),
                        ActualizadoPor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Rol", "Creado", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rol", "CreadoPor", c => c.String());
            AddColumn("dbo.Rol", "Actualizado", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rol", "ActualizadoPor", c => c.String());
            AlterColumn("dbo.Rol", "Descripcion", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rol", "Descripcion", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.Rol", "ActualizadoPor");
            DropColumn("dbo.Rol", "Actualizado");
            DropColumn("dbo.Rol", "CreadoPor");
            DropColumn("dbo.Rol", "Creado");
            DropTable("dbo.Facultad");
        }
    }
}
