namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Opleidingsinformaties", "OeNummer", c => c.Int(nullable: false));
            AlterColumn("dbo.Opleidingsinformaties", "Opleidingscode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Opleidingsinformaties", "Opleidingscode", c => c.String());
            AlterColumn("dbo.Opleidingsinformaties", "OeNummer", c => c.String());
        }
    }
}
