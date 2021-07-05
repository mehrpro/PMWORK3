namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMachinery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Machineries", "CompanyID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Machineries", "CompanyID");
        }
    }
}
