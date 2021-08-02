namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateServicePeriode3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ServicePeriodes", "Registred", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ServicePeriodes", "Registred");
        }
    }
}
