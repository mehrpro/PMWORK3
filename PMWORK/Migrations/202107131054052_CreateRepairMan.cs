namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRepairMan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RepairMen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Repairman_FullName = c.String(nullable: false, maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.WorkOrders", "RepairManID_FK", c => c.Int(nullable: false));
            AddColumn("dbo.WorkOrders", "EndWorking", c => c.DateTime(nullable: false));
            CreateIndex("dbo.WorkOrders", "RepairManID_FK");
            AddForeignKey("dbo.WorkOrders", "RepairManID_FK", "dbo.RepairMen", "ID");
            DropColumn("dbo.WorkOrders", "IsActive");
            DropColumn("dbo.WorkOrders", "Electrical");
            DropColumn("dbo.WorkOrders", "Mecanical");
            DropColumn("dbo.WorkOrders", "Piping");
            DropColumn("dbo.WorkOrders", "Creating");
            DropColumn("dbo.WorkOrders", "Equip");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkOrders", "Equip", c => c.Boolean(nullable: false));
            AddColumn("dbo.WorkOrders", "Creating", c => c.Boolean(nullable: false));
            AddColumn("dbo.WorkOrders", "Piping", c => c.Boolean(nullable: false));
            AddColumn("dbo.WorkOrders", "Mecanical", c => c.Boolean(nullable: false));
            AddColumn("dbo.WorkOrders", "Electrical", c => c.Boolean(nullable: false));
            AddColumn("dbo.WorkOrders", "IsActive", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.WorkOrders", "RepairManID_FK", "dbo.RepairMen");
            DropIndex("dbo.WorkOrders", new[] { "RepairManID_FK" });
            DropColumn("dbo.WorkOrders", "EndWorking");
            DropColumn("dbo.WorkOrders", "RepairManID_FK");
            DropTable("dbo.RepairMen");
        }
    }
}
