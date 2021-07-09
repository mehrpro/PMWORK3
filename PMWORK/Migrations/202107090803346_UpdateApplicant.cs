namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateApplicant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Machineries", "ApplicantID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.Machineries", "ApplicantID_FK");
            AddForeignKey("dbo.Machineries", "ApplicantID_FK", "dbo.Applicants", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Machineries", "ApplicantID_FK", "dbo.Applicants");
            DropIndex("dbo.Machineries", new[] { "ApplicantID_FK" });
            DropColumn("dbo.Machineries", "ApplicantID_FK");
        }
    }
}
