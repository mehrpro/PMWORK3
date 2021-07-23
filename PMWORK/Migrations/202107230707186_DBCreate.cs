namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBCreate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.RepairManListeds", new[] { "WorkOrder_ID" });
            DropColumn("dbo.RepairManListeds", "WorkOrderIdFk");
            RenameColumn(table: "dbo.RepairManListeds", name: "WorkOrder_ID", newName: "WorkOrderIdFk");
            AlterColumn("dbo.RepairManListeds", "WorkOrderIdFk", c => c.Long(nullable: false));
            AlterColumn("dbo.RepairManListeds", "WorkOrderIdFk", c => c.Long(nullable: false));
            CreateIndex("dbo.RepairManListeds", "WorkOrderIdFk");
        }
        
        public override void Down()
        {
            DropIndex("dbo.RepairManListeds", new[] { "WorkOrderIdFk" });
            AlterColumn("dbo.RepairManListeds", "WorkOrderIdFk", c => c.Long());
            AlterColumn("dbo.RepairManListeds", "WorkOrderIdFk", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.RepairManListeds", name: "WorkOrderIdFk", newName: "WorkOrder_ID");
            AddColumn("dbo.RepairManListeds", "WorkOrderIdFk", c => c.Int(nullable: false));
            CreateIndex("dbo.RepairManListeds", "WorkOrder_ID");
        }
    }
}
