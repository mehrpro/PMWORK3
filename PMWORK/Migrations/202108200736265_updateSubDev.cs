namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSubDev : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubCounterDevices", "UnitID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.SubCounterDevices", "UnitID_FK");
            AddForeignKey("dbo.SubCounterDevices", "UnitID_FK", "dbo.UnitOfMeasurements", "ID");
            DropColumn("dbo.SubCounterDevices", "TypeCounter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubCounterDevices", "TypeCounter", c => c.String(nullable: false, maxLength: 250));
            DropForeignKey("dbo.SubCounterDevices", "UnitID_FK", "dbo.UnitOfMeasurements");
            DropIndex("dbo.SubCounterDevices", new[] { "UnitID_FK" });
            DropColumn("dbo.SubCounterDevices", "UnitID_FK");
        }
    }
}
