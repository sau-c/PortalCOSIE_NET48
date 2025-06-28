namespace PortalCOSIE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Permiso : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Facultad", newName: "Permiso");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Permiso", newName: "Facultad");
        }
    }
}
