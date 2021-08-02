namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSpare1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SpareParts", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SpareParts", "Number", c => c.Int(nullable: false));
        }
    }
}
