namespace Aanwezigheidslijst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NietOpleidingsDagens", "Voormiddag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.NietOpleidingsDagens", "Namiddag", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NietOpleidingsDagens", "Namiddag", c => c.String());
            AlterColumn("dbo.NietOpleidingsDagens", "Voormiddag", c => c.String());
        }
    }
}
