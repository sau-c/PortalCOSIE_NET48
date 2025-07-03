namespace PortalCOSIE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Permisos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Permiso", "Vista", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Permiso", "Accion", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Permiso", "Nombre");
            DropColumn("dbo.Permiso", "Descripcion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Permiso", "Descripcion", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Permiso", "Nombre", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Permiso", "Accion");
            DropColumn("dbo.Permiso", "Vista");
        }
    }
}
