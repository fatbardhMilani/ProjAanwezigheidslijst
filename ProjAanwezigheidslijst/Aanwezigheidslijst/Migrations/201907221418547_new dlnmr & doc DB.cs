namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdlnmrdocDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Deelnemers", "Opleiding_Id", c => c.Int());
            AddColumn("dbo.Docentens", "Opleiding_Id", c => c.Int());
            CreateIndex("dbo.Deelnemers", "Opleiding_Id");
            CreateIndex("dbo.Docentens", "Opleiding_Id");
            AddForeignKey("dbo.Deelnemers", "Opleiding_Id", "dbo.Opleidingsinformaties", "Id");
            AddForeignKey("dbo.Docentens", "Opleiding_Id", "dbo.Opleidingsinformaties", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Docentens", "Opleiding_Id", "dbo.Opleidingsinformaties");
            DropForeignKey("dbo.Deelnemers", "Opleiding_Id", "dbo.Opleidingsinformaties");
            DropIndex("dbo.Docentens", new[] { "Opleiding_Id" });
            DropIndex("dbo.Deelnemers", new[] { "Opleiding_Id" });
            DropColumn("dbo.Docentens", "Opleiding_Id");
            DropColumn("dbo.Deelnemers", "Opleiding_Id");
        }
    }
}
