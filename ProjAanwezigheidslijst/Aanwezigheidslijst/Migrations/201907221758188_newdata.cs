namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeelnemersOpleidingens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Deelnemer_Id = c.Int(),
                        Opleiding_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deelnemers", t => t.Deelnemer_Id)
                .ForeignKey("dbo.Opleidingsinformaties", t => t.Opleiding_Id)
                .Index(t => t.Deelnemer_Id)
                .Index(t => t.Opleiding_Id);
            
            CreateTable(
                "dbo.DocetenOpleidingens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Docent_Id = c.Int(),
                        Opleiding_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Docentens", t => t.Docent_Id)
                .ForeignKey("dbo.Opleidingsinformaties", t => t.Opleiding_Id)
                .Index(t => t.Docent_Id)
                .Index(t => t.Opleiding_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocetenOpleidingens", "Opleiding_Id", "dbo.Opleidingsinformaties");
            DropForeignKey("dbo.DocetenOpleidingens", "Docent_Id", "dbo.Docentens");
            DropForeignKey("dbo.DeelnemersOpleidingens", "Opleiding_Id", "dbo.Opleidingsinformaties");
            DropForeignKey("dbo.DeelnemersOpleidingens", "Deelnemer_Id", "dbo.Deelnemers");
            DropIndex("dbo.DocetenOpleidingens", new[] { "Opleiding_Id" });
            DropIndex("dbo.DocetenOpleidingens", new[] { "Docent_Id" });
            DropIndex("dbo.DeelnemersOpleidingens", new[] { "Opleiding_Id" });
            DropIndex("dbo.DeelnemersOpleidingens", new[] { "Deelnemer_Id" });
            DropTable("dbo.DocetenOpleidingens");
            DropTable("dbo.DeelnemersOpleidingens");
        }
    }
}
