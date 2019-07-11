namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Opleidingsinformaties", "OeNummer", c => c.String());
            AlterColumn("dbo.Opleidingsinformaties", "Opleidingscode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Opleidingsinformaties", "Opleidingscode", c => c.Int(nullable: false));
            AlterColumn("dbo.Opleidingsinformaties", "OeNummer", c => c.Int(nullable: false));
        }
    }
}
