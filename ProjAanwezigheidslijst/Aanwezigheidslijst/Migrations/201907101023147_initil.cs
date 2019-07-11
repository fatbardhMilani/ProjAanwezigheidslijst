namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initil : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NietOpleidingsDagens", "OpleidingId_Id", c => c.Int());
            CreateIndex("dbo.NietOpleidingsDagens", "OpleidingId_Id");
            AddForeignKey("dbo.NietOpleidingsDagens", "OpleidingId_Id", "dbo.Opleidingsinformaties", "Id");
            DropColumn("dbo.NietOpleidingsDagens", "OpleidingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NietOpleidingsDagens", "OpleidingId", c => c.Int(nullable: false));
            DropForeignKey("dbo.NietOpleidingsDagens", "OpleidingId_Id", "dbo.Opleidingsinformaties");
            DropIndex("dbo.NietOpleidingsDagens", new[] { "OpleidingId_Id" });
            DropColumn("dbo.NietOpleidingsDagens", "OpleidingId_Id");
        }
    }
}
