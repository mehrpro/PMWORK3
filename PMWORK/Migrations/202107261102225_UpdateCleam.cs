namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCleam : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Cleams");
            AddColumn("dbo.Cleams", "GroupID_FK", c => c.Int(nullable: false));
            AddColumn("dbo.Cleams", "IsDelete", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Cleams", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cleams", "ID");
            CreateIndex("dbo.Cleams", "GroupID_FK");
            AddForeignKey("dbo.Cleams", "GroupID_FK", "dbo.MenuGroups", "GroupID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cleams", "GroupID_FK", "dbo.MenuGroups");
            DropIndex("dbo.Cleams", new[] { "GroupID_FK" });
            DropPrimaryKey("dbo.Cleams");
            AlterColumn("dbo.Cleams", "ID", c => c.Long(nullable: false, identity: true));
            DropColumn("dbo.Cleams", "IsDelete");
            DropColumn("dbo.Cleams", "GroupID_FK");
            AddPrimaryKey("dbo.Cleams", "ID");
        }
    }
}
