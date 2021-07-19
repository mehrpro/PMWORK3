namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRepairMan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RepairMen", "RepairMan_Status", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RepairMen", "RepairMan_Status");
        }
    }
}
