namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTypeofWork : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RequestRepairs", "TypeofRepairID_FK", "dbo.TypeofRepairs");
            DropIndex("dbo.RequestRepairs", new[] { "TypeofRepairID_FK" });
            CreateTable(
                "dbo.PublicTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Group = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Applicants", "CompanyID_FK", c => c.Int(nullable: false));
            AddColumn("dbo.RequestRepairs", "EM", c => c.Boolean(nullable: false));
            AddColumn("dbo.RequestRepairs", "PublicTypeID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.Applicants", "CompanyID_FK");
            CreateIndex("dbo.RequestRepairs", "PublicTypeID_FK");
            AddForeignKey("dbo.Applicants", "CompanyID_FK", "dbo.Companies", "ID");
            AddForeignKey("dbo.RequestRepairs", "PublicTypeID_FK", "dbo.PublicTypes", "ID");
            DropColumn("dbo.RequestRepairs", "TypeofRepairID_FK");
            DropColumn("dbo.RequestRepairs", "EMPM");
            DropColumn("dbo.RequestRepairs", "Status");
            DropTable("dbo.TypeofRepairs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TypeofRepairs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeTitle = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.RequestRepairs", "Status", c => c.Byte(nullable: false));
            AddColumn("dbo.RequestRepairs", "EMPM", c => c.Byte(nullable: false));
            AddColumn("dbo.RequestRepairs", "TypeofRepairID_FK", c => c.Int(nullable: false));
            DropForeignKey("dbo.RequestRepairs", "PublicTypeID_FK", "dbo.PublicTypes");
            DropForeignKey("dbo.Applicants", "CompanyID_FK", "dbo.Companies");
            DropIndex("dbo.RequestRepairs", new[] { "PublicTypeID_FK" });
            DropIndex("dbo.Applicants", new[] { "CompanyID_FK" });
            DropColumn("dbo.RequestRepairs", "PublicTypeID_FK");
            DropColumn("dbo.RequestRepairs", "EM");
            DropColumn("dbo.Applicants", "CompanyID_FK");
            DropTable("dbo.PublicTypes");
            CreateIndex("dbo.RequestRepairs", "TypeofRepairID_FK");
            AddForeignKey("dbo.RequestRepairs", "TypeofRepairID_FK", "dbo.TypeofRepairs", "ID");
        }
    }
}
