namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.DeelnemersOpleidingens", name: "DeelnemerId_Id", newName: "Deelnemer_Id");
            RenameColumn(table: "dbo.DeelnemersOpleidingens", name: "OpleidingId_Id", newName: "Opleiding_Id");
            RenameColumn(table: "dbo.DocetenOpleidingens", name: "DocentId_Id", newName: "Docent_Id");
            RenameColumn(table: "dbo.DocetenOpleidingens", name: "OpleidingId_Id", newName: "Opleiding_Id");
            RenameColumn(table: "dbo.NietOpleidingsDagens", name: "OpleidingId_Id", newName: "Opleiding_Id");
            RenameColumn(table: "dbo.Tijdsregistraties", name: "DeelnemerId_Id", newName: "Deelnemer_Id");
            RenameColumn(table: "dbo.Tijdsregistraties", name: "OpleidingId_Id", newName: "Opleiding_Id");
            RenameIndex(table: "dbo.DeelnemersOpleidingens", name: "IX_DeelnemerId_Id", newName: "IX_Deelnemer_Id");
            RenameIndex(table: "dbo.DeelnemersOpleidingens", name: "IX_OpleidingId_Id", newName: "IX_Opleiding_Id");
            RenameIndex(table: "dbo.DocetenOpleidingens", name: "IX_DocentId_Id", newName: "IX_Docent_Id");
            RenameIndex(table: "dbo.DocetenOpleidingens", name: "IX_OpleidingId_Id", newName: "IX_Opleiding_Id");
            RenameIndex(table: "dbo.NietOpleidingsDagens", name: "IX_OpleidingId_Id", newName: "IX_Opleiding_Id");
            RenameIndex(table: "dbo.Tijdsregistraties", name: "IX_DeelnemerId_Id", newName: "IX_Deelnemer_Id");
            RenameIndex(table: "dbo.Tijdsregistraties", name: "IX_OpleidingId_Id", newName: "IX_Opleiding_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Tijdsregistraties", name: "IX_Opleiding_Id", newName: "IX_OpleidingId_Id");
            RenameIndex(table: "dbo.Tijdsregistraties", name: "IX_Deelnemer_Id", newName: "IX_DeelnemerId_Id");
            RenameIndex(table: "dbo.NietOpleidingsDagens", name: "IX_Opleiding_Id", newName: "IX_OpleidingId_Id");
            RenameIndex(table: "dbo.DocetenOpleidingens", name: "IX_Opleiding_Id", newName: "IX_OpleidingId_Id");
            RenameIndex(table: "dbo.DocetenOpleidingens", name: "IX_Docent_Id", newName: "IX_DocentId_Id");
            RenameIndex(table: "dbo.DeelnemersOpleidingens", name: "IX_Opleiding_Id", newName: "IX_OpleidingId_Id");
            RenameIndex(table: "dbo.DeelnemersOpleidingens", name: "IX_Deelnemer_Id", newName: "IX_DeelnemerId_Id");
            RenameColumn(table: "dbo.Tijdsregistraties", name: "Opleiding_Id", newName: "OpleidingId_Id");
            RenameColumn(table: "dbo.Tijdsregistraties", name: "Deelnemer_Id", newName: "DeelnemerId_Id");
            RenameColumn(table: "dbo.NietOpleidingsDagens", name: "Opleiding_Id", newName: "OpleidingId_Id");
            RenameColumn(table: "dbo.DocetenOpleidingens", name: "Opleiding_Id", newName: "OpleidingId_Id");
            RenameColumn(table: "dbo.DocetenOpleidingens", name: "Docent_Id", newName: "DocentId_Id");
            RenameColumn(table: "dbo.DeelnemersOpleidingens", name: "Opleiding_Id", newName: "OpleidingId_Id");
            RenameColumn(table: "dbo.DeelnemersOpleidingens", name: "Deelnemer_Id", newName: "DeelnemerId_Id");
        }
    }
}
