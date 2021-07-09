namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRequestRepair1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequestRepairs", "IsClose", c => c.Boolean(nullable: false));
            AddColumn("dbo.RequestRepairs", "CompanyID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.RequestRepairs", "CompanyID_FK");
            AddForeignKey("dbo.RequestRepairs", "CompanyID_FK", "dbo.Companies", "ID");
            DropColumn("dbo.RequestRepairs", "Registered");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RequestRepairs", "Registered", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.RequestRepairs", "CompanyID_FK", "dbo.Companies");
            DropIndex("dbo.RequestRepairs", new[] { "CompanyID_FK" });
            DropColumn("dbo.RequestRepairs", "CompanyID_FK");
            DropColumn("dbo.RequestRepairs", "IsClose");
        }
    }
}
