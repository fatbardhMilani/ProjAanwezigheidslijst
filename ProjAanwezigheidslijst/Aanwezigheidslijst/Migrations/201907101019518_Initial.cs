namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeelnemersOpleidingens", "DeelnemerId_Id", c => c.Int());
            AddColumn("dbo.DeelnemersOpleidingens", "OpleidingId_Id", c => c.Int());
            AddColumn("dbo.DocetenOpleidingens", "DocentId_Id", c => c.Int());
            AddColumn("dbo.DocetenOpleidingens", "OpleidingId_Id", c => c.Int());
            AddColumn("dbo.Tijdsregistraties", "DeelnemerId_Id", c => c.Int());
            AddColumn("dbo.Tijdsregistraties", "OpleidingId_Id", c => c.Int());
            CreateIndex("dbo.DeelnemersOpleidingens", "DeelnemerId_Id");
            CreateIndex("dbo.DeelnemersOpleidingens", "OpleidingId_Id");
            CreateIndex("dbo.DocetenOpleidingens", "DocentId_Id");
            CreateIndex("dbo.DocetenOpleidingens", "OpleidingId_Id");
            CreateIndex("dbo.Tijdsregistraties", "DeelnemerId_Id");
            CreateIndex("dbo.Tijdsregistraties", "OpleidingId_Id");
            AddForeignKey("dbo.DeelnemersOpleidingens", "DeelnemerId_Id", "dbo.Deelnemers", "Id");
            AddForeignKey("dbo.DeelnemersOpleidingens", "OpleidingId_Id", "dbo.Opleidingsinformaties", "Id");
            AddForeignKey("dbo.DocetenOpleidingens", "DocentId_Id", "dbo.Docentens", "Id");
            AddForeignKey("dbo.DocetenOpleidingens", "OpleidingId_Id", "dbo.Opleidingsinformaties", "Id");
            AddForeignKey("dbo.Tijdsregistraties", "DeelnemerId_Id", "dbo.Deelnemers", "Id");
            AddForeignKey("dbo.Tijdsregistraties", "OpleidingId_Id", "dbo.Opleidingsinformaties", "Id");
            DropColumn("dbo.DeelnemersOpleidingens", "DeelnemerId");
            DropColumn("dbo.DeelnemersOpleidingens", "OpleidingId");
            DropColumn("dbo.DocetenOpleidingens", "DocentId");
            DropColumn("dbo.DocetenOpleidingens", "OpleidingId");
            DropColumn("dbo.Tijdsregistraties", "OpleidingId");
            DropColumn("dbo.Tijdsregistraties", "DeelnemerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tijdsregistraties", "DeelnemerId", c => c.Int(nullable: false));
            AddColumn("dbo.Tijdsregistraties", "OpleidingId", c => c.Int(nullable: false));
            AddColumn("dbo.DocetenOpleidingens", "OpleidingId", c => c.Int(nullable: false));
            AddColumn("dbo.DocetenOpleidingens", "DocentId", c => c.Int(nullable: false));
            AddColumn("dbo.DeelnemersOpleidingens", "OpleidingId", c => c.Int(nullable: false));
            AddColumn("dbo.DeelnemersOpleidingens", "DeelnemerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Tijdsregistraties", "OpleidingId_Id", "dbo.Opleidingsinformaties");
            DropForeignKey("dbo.Tijdsregistraties", "DeelnemerId_Id", "dbo.Deelnemers");
            DropForeignKey("dbo.DocetenOpleidingens", "OpleidingId_Id", "dbo.Opleidingsinformaties");
            DropForeignKey("dbo.DocetenOpleidingens", "DocentId_Id", "dbo.Docentens");
            DropForeignKey("dbo.DeelnemersOpleidingens", "OpleidingId_Id", "dbo.Opleidingsinformaties");
            DropForeignKey("dbo.DeelnemersOpleidingens", "DeelnemerId_Id", "dbo.Deelnemers");
            DropIndex("dbo.Tijdsregistraties", new[] { "OpleidingId_Id" });
            DropIndex("dbo.Tijdsregistraties", new[] { "DeelnemerId_Id" });
            DropIndex("dbo.DocetenOpleidingens", new[] { "OpleidingId_Id" });
            DropIndex("dbo.DocetenOpleidingens", new[] { "DocentId_Id" });
            DropIndex("dbo.DeelnemersOpleidingens", new[] { "OpleidingId_Id" });
            DropIndex("dbo.DeelnemersOpleidingens", new[] { "DeelnemerId_Id" });
            DropColumn("dbo.Tijdsregistraties", "OpleidingId_Id");
            DropColumn("dbo.Tijdsregistraties", "DeelnemerId_Id");
            DropColumn("dbo.DocetenOpleidingens", "OpleidingId_Id");
            DropColumn("dbo.DocetenOpleidingens", "DocentId_Id");
            DropColumn("dbo.DeelnemersOpleidingens", "OpleidingId_Id");
            DropColumn("dbo.DeelnemersOpleidingens", "DeelnemerId_Id");
        }
    }
}
