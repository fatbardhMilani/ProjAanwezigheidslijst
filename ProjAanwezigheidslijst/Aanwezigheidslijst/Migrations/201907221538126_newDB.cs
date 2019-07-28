namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DeelnemersOpleidingens", "Deelnemer_Id", "dbo.Deelnemers");
            DropForeignKey("dbo.DeelnemersOpleidingens", "Opleiding_Id", "dbo.Opleidingsinformaties");
            DropForeignKey("dbo.DocetenOpleidingens", "Docent_Id", "dbo.Docentens");
            DropForeignKey("dbo.DocetenOpleidingens", "Opleiding_Id", "dbo.Opleidingsinformaties");
            DropIndex("dbo.DeelnemersOpleidingens", new[] { "Deelnemer_Id" });
            DropIndex("dbo.DeelnemersOpleidingens", new[] { "Opleiding_Id" });
            DropIndex("dbo.DocetenOpleidingens", new[] { "Docent_Id" });
            DropIndex("dbo.DocetenOpleidingens", new[] { "Opleiding_Id" });
            DropTable("dbo.DeelnemersOpleidingens");
            DropTable("dbo.DocetenOpleidingens");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DocetenOpleidingens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Docent_Id = c.Int(),
                        Opleiding_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeelnemersOpleidingens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Deelnemer_Id = c.Int(),
                        Opleiding_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.DocetenOpleidingens", "Opleiding_Id");
            CreateIndex("dbo.DocetenOpleidingens", "Docent_Id");
            CreateIndex("dbo.DeelnemersOpleidingens", "Opleiding_Id");
            CreateIndex("dbo.DeelnemersOpleidingens", "Deelnemer_Id");
            AddForeignKey("dbo.DocetenOpleidingens", "Opleiding_Id", "dbo.Opleidingsinformaties", "Id");
            AddForeignKey("dbo.DocetenOpleidingens", "Docent_Id", "dbo.Docentens", "Id");
            AddForeignKey("dbo.DeelnemersOpleidingens", "Opleiding_Id", "dbo.Opleidingsinformaties", "Id");
            AddForeignKey("dbo.DeelnemersOpleidingens", "Deelnemer_Id", "dbo.Deelnemers", "Id");
        }
    }
}
