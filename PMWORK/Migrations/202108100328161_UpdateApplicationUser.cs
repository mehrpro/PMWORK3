namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUsers", "Editor", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.ApplicationUsers", "LimetedCompany", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationUsers", "LimetedCompany");
            DropColumn("dbo.ApplicationUsers", "Editor");
        }
    }
}
