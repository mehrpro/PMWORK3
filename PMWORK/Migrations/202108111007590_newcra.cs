namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newcra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Repairouts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyID_FK = c.Int(nullable: false),
                        RequestID_FK = c.Long(nullable: false),
                        RequestRepairOut = c.String(nullable: false, maxLength: 500),
                        Regidtered = c.DateTime(nullable: false),
                        RepairOutFullName = c.String(nullable: false, maxLength: 250),
                        RepairReportOut = c.String(maxLength: 500),
                        BackendRequest = c.DateTime(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RequestRepairs", t => t.RequestID_FK)
                .Index(t => t.RequestID_FK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairouts", "RequestID_FK", "dbo.RequestRepairs");
            DropIndex("dbo.Repairouts", new[] { "RequestID_FK" });
            DropTable("dbo.Repairouts");
        }
    }
}
