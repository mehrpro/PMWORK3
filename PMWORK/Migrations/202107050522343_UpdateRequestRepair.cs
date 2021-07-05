namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRequestRepair : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequestRepairs", "EMPM", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RequestRepairs", "EMPM");
        }
    }
}
