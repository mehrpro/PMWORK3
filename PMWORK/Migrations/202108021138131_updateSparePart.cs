namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSparePart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SpareParts", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SpareParts", "IsActive");
        }
    }
}
