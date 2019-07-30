namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Deelnemers", "Opleiding_Id", "dbo.Opleidingsinformaties");
            DropForeignKey("dbo.Docentens", "Opleiding_Id", "dbo.Opleidingsinformaties");
            DropIndex("dbo.Deelnemers", new[] { "Opleiding_Id" });
            DropIndex("dbo.Docentens", new[] { "Opleiding_Id" });
            DropColumn("dbo.Deelnemers", "Opleiding_Id");
            DropColumn("dbo.Docentens", "Opleiding_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Docentens", "Opleiding_Id", c => c.Int());
            AddColumn("dbo.Deelnemers", "Opleiding_Id", c => c.Int());
            CreateIndex("dbo.Docentens", "Opleiding_Id");
            CreateIndex("dbo.Deelnemers", "Opleiding_Id");
            AddForeignKey("dbo.Docentens", "Opleiding_Id", "dbo.Opleidingsinformaties", "Id");
            AddForeignKey("dbo.Deelnemers", "Opleiding_Id", "dbo.Opleidingsinformaties", "Id");
        }
    }
}
