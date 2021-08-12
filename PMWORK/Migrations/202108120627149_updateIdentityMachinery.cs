namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateIdentityMachinery : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.IdentityMachineries", new[] { "ApplicantID_FK" });
            RenameColumn(table: "dbo.IdentityMachineries", name: "ApplicantID_FK", newName: "Applicant_ID");
            AddColumn("dbo.IdentityMachineries", "dateStartWaranty", c => c.DateTime(nullable: false));
            AddColumn("dbo.IdentityMachineries", "dateEndWaranty", c => c.DateTime(nullable: false));
            AddColumn("dbo.IdentityMachineries", "Calibration", c => c.Boolean(nullable: false));
            AddColumn("dbo.IdentityMachineries", "NewDivice", c => c.Boolean(nullable: false));
            AddColumn("dbo.IdentityMachineries", "Company", c => c.String(maxLength: 250));
            AddColumn("dbo.IdentityMachineries", "Countery", c => c.String(maxLength: 50));
            AddColumn("dbo.IdentityMachineries", "CompanyAddress", c => c.String(maxLength: 250));
            AddColumn("dbo.IdentityMachineries", "CompanyTel", c => c.String(maxLength: 15));
            AddColumn("dbo.IdentityMachineries", "CompanyFax", c => c.String(maxLength: 15));
            AddColumn("dbo.IdentityMachineries", "SupplyName", c => c.String(maxLength: 250));
            AddColumn("dbo.IdentityMachineries", "SupplyAddress", c => c.String(maxLength: 250));
            AddColumn("dbo.IdentityMachineries", "SupplyTel", c => c.String(maxLength: 15));
            AddColumn("dbo.IdentityMachineries", "SupplyFax", c => c.String(maxLength: 15));
            AddColumn("dbo.IdentityMachineries", "CalibrationCompany", c => c.String(maxLength: 250));
            AddColumn("dbo.IdentityMachineries", "CalibrationAddress", c => c.String(maxLength: 250));
            AddColumn("dbo.IdentityMachineries", "CalibrationTel", c => c.String(maxLength: 15));
            AddColumn("dbo.IdentityMachineries", "CalibrationFax", c => c.String(maxLength: 15));
            AlterColumn("dbo.IdentityMachineries", "Applicant_ID", c => c.Int());
            CreateIndex("dbo.IdentityMachineries", "Applicant_ID");
            DropColumn("dbo.IdentityMachineries", "Wather");
            DropColumn("dbo.IdentityMachineries", "oil");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IdentityMachineries", "oil", c => c.String());
            AddColumn("dbo.IdentityMachineries", "Wather", c => c.String());
            DropIndex("dbo.IdentityMachineries", new[] { "Applicant_ID" });
            AlterColumn("dbo.IdentityMachineries", "Applicant_ID", c => c.Int(nullable: false));
            DropColumn("dbo.IdentityMachineries", "CalibrationFax");
            DropColumn("dbo.IdentityMachineries", "CalibrationTel");
            DropColumn("dbo.IdentityMachineries", "CalibrationAddress");
            DropColumn("dbo.IdentityMachineries", "CalibrationCompany");
            DropColumn("dbo.IdentityMachineries", "SupplyFax");
            DropColumn("dbo.IdentityMachineries", "SupplyTel");
            DropColumn("dbo.IdentityMachineries", "SupplyAddress");
            DropColumn("dbo.IdentityMachineries", "SupplyName");
            DropColumn("dbo.IdentityMachineries", "CompanyFax");
            DropColumn("dbo.IdentityMachineries", "CompanyTel");
            DropColumn("dbo.IdentityMachineries", "CompanyAddress");
            DropColumn("dbo.IdentityMachineries", "Countery");
            DropColumn("dbo.IdentityMachineries", "Company");
            DropColumn("dbo.IdentityMachineries", "NewDivice");
            DropColumn("dbo.IdentityMachineries", "Calibration");
            DropColumn("dbo.IdentityMachineries", "dateEndWaranty");
            DropColumn("dbo.IdentityMachineries", "dateStartWaranty");
            RenameColumn(table: "dbo.IdentityMachineries", name: "Applicant_ID", newName: "ApplicantID_FK");
            CreateIndex("dbo.IdentityMachineries", "ApplicantID_FK");
        }
    }
}
