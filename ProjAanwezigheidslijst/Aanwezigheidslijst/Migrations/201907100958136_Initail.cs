namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deelnemers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        GeboorteDatum = c.DateTime(nullable: false),
                        Woonplaats = c.String(),
                        BadgeNummer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeelnemersOpleidingens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeelnemerId = c.Int(nullable: false),
                        OpleidingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Docentens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Bedrijf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DocetenOpleidingens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocentId = c.Int(nullable: false),
                        OpleidingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NietOpleidingsDagens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Datum = c.DateTime(nullable: false),
                        Voormiddag = c.String(),
                        Namiddag = c.String(),
                        OpleidingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Opleidingsinformaties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Opleidingsinstelling = c.String(),
                        Opleiding = c.String(),
                        Contactpersoon = c.String(),
                        Opleidingsplaats = c.String(),
                        ReferentieOpleidingsplaats = c.String(),
                        OeNummer = c.Int(nullable: false),
                        Opleidingscode = c.Int(nullable: false),
                        StartDatum = c.DateTime(nullable: false),
                        EindDatume = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tijdsregistraties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        OpleidingId = c.Int(nullable: false),
                        DeelnemerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tijdsregistraties");
            DropTable("dbo.Opleidingsinformaties");
            DropTable("dbo.NietOpleidingsDagens");
            DropTable("dbo.DocetenOpleidingens");
            DropTable("dbo.Docentens");
            DropTable("dbo.DeelnemersOpleidingens");
            DropTable("dbo.Deelnemers");
        }
    }
}
