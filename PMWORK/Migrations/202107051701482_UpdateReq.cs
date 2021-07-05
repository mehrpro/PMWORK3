namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReq : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequestRepairs", "Status", c => c.Byte(nullable: false));
            AlterColumn("dbo.RequestRepairs", "EMPM", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RequestRepairs", "EMPM", c => c.Int(nullable: false));
            DropColumn("dbo.RequestRepairs", "Status");
        }
    }
}
