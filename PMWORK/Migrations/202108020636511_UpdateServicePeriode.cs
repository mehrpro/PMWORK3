namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateServicePeriode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ServicePeriodes", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ServicePeriodes", "IsActive");
        }
    }
}
