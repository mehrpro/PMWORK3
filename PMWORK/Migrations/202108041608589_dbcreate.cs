namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applicants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApplicantTitle = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 250),
                        CompanyID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Companies", t => t.CompanyID_FK)
                .Index(t => t.CompanyID_FK);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompnayIndex = c.Byte(nullable: false),
                        CompanyTitle = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 20),
                        UserPassword = c.String(nullable: false, maxLength: 100),
                        FullName = c.String(nullable: false, maxLength: 200),
                        Enabled = c.Boolean(nullable: false),
                        CompanyID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Companies", t => t.CompanyID_FK)
                .Index(t => t.CompanyID_FK);
            
            CreateTable(
                "dbo.Cleams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID_FK = c.Int(nullable: false),
                        GroupID_FK = c.Int(nullable: false),
                        MenuItemID_FK = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID_FK)
                .ForeignKey("dbo.MenuItems", t => t.MenuItemID_FK)
                .ForeignKey("dbo.ApplicationUsers", t => t.UserID_FK)
                .Index(t => t.UserID_FK)
                .Index(t => t.GroupID_FK)
                .Index(t => t.MenuItemID_FK);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        MenuGroupTitle = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        GroupID_FK = c.Int(nullable: false),
                        ItemTitel = c.String(nullable: false, maxLength: 150),
                        Description = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID_FK)
                .Index(t => t.GroupID_FK);
            
            CreateTable(
                "dbo.Codings",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CompanyID_FK = c.Int(nullable: false),
                        GroupID_FK = c.Int(nullable: false),
                        SubGroupID_FK = c.Int(nullable: false),
                        UserID_FK = c.Int(nullable: false),
                        CodeIndex = c.Short(nullable: false),
                        Code = c.Int(nullable: false),
                        CodeTitle = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.GroupID_FK)
                .ForeignKey("dbo.SubGroups", t => t.SubGroupID_FK)
                .ForeignKey("dbo.ApplicationUsers", t => t.UserID_FK)
                .ForeignKey("dbo.Companies", t => t.CompanyID_FK)
                .Index(t => t.CompanyID_FK)
                .Index(t => t.GroupID_FK)
                .Index(t => t.SubGroupID_FK)
                .Index(t => t.UserID_FK);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyID_FK = c.Int(nullable: false),
                        GroupIndex = c.Byte(nullable: false),
                        GroupTitle = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Companies", t => t.CompanyID_FK)
                .Index(t => t.CompanyID_FK);
            
            CreateTable(
                "dbo.SubGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyID_FK = c.Int(nullable: false),
                        GroupID_FK = c.Int(nullable: false),
                        SubGroupIndex = c.Byte(nullable: false),
                        SubGroupTitle = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.GroupID_FK)
                .ForeignKey("dbo.Companies", t => t.CompanyID_FK)
                .Index(t => t.CompanyID_FK)
                .Index(t => t.GroupID_FK);
            
            CreateTable(
                "dbo.Machineries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        CodeID_FK = c.Long(nullable: false),
                        ApplicantID_FK = c.Int(nullable: false),
                        MachineryTitle = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Codings", t => t.CodeID_FK)
                .ForeignKey("dbo.Applicants", t => t.ApplicantID_FK)
                .Index(t => t.CodeID_FK)
                .Index(t => t.ApplicantID_FK);
            
            CreateTable(
                "dbo.IdentityMachineries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MachinerID_FK = c.Int(nullable: false),
                        TypeDevice = c.String(maxLength: 250),
                        dateTimeImport = c.DateTime(nullable: false),
                        dateTimeStart = c.DateTime(nullable: false),
                        ApplicantID_FK = c.Int(nullable: false),
                        Length = c.String(),
                        Width = c.String(),
                        Height = c.String(),
                        Wight = c.String(),
                        Wather = c.String(),
                        oil = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Machineries", t => t.MachinerID_FK)
                .ForeignKey("dbo.Applicants", t => t.ApplicantID_FK)
                .Index(t => t.MachinerID_FK)
                .Index(t => t.ApplicantID_FK);
            
            CreateTable(
                "dbo.PowerElectricalMachineries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MachineryID_FK = c.Int(nullable: false),
                        Title = c.String(maxLength: 250),
                        Manifactor = c.String(maxLength: 250),
                        KW = c.String(maxLength: 10),
                        RPM = c.Int(nullable: false),
                        Voltag = c.String(maxLength: 10),
                        Amper = c.String(maxLength: 10),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Machineries", t => t.MachineryID_FK)
                .Index(t => t.MachineryID_FK);
            
            CreateTable(
                "dbo.RequestRepairs",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        IsClose = c.Boolean(nullable: false),
                        EM = c.Boolean(nullable: false),
                        CompanyID_FK = c.Int(nullable: false),
                        MachineryID_FK = c.Int(nullable: false),
                        UserID_FK = c.Int(nullable: false),
                        RequestDataTime = c.DateTime(nullable: false),
                        PublicTypeID_FK = c.Int(nullable: false),
                        ApplicantID_FK = c.Int(nullable: false),
                        RequestTitle = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PublicTypes", t => t.PublicTypeID_FK)
                .ForeignKey("dbo.Machineries", t => t.MachineryID_FK)
                .ForeignKey("dbo.ApplicationUsers", t => t.UserID_FK)
                .ForeignKey("dbo.Companies", t => t.CompanyID_FK)
                .ForeignKey("dbo.Applicants", t => t.ApplicantID_FK)
                .Index(t => t.CompanyID_FK)
                .Index(t => t.MachineryID_FK)
                .Index(t => t.UserID_FK)
                .Index(t => t.PublicTypeID_FK)
                .Index(t => t.ApplicantID_FK);
            
            CreateTable(
                "dbo.ConsumableParts",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        RequestID_FK = c.Long(nullable: false),
                        ConsumablePartTitel = c.String(nullable: false, maxLength: 250),
                        Number = c.Int(nullable: false),
                        UnitID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitOfMeasurements", t => t.UnitID_FK)
                .ForeignKey("dbo.RequestRepairs", t => t.RequestID_FK)
                .Index(t => t.RequestID_FK)
                .Index(t => t.UnitID_FK);
            
            CreateTable(
                "dbo.UnitOfMeasurements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Unit = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ServicePeriodes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MachineryID_FK = c.Int(nullable: false),
                        ServiceTitle = c.String(nullable: false, maxLength: 250),
                        Periode = c.Int(nullable: false),
                        UnitID_FK = c.Int(nullable: false),
                        Description = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        Registred = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitOfMeasurements", t => t.UnitID_FK)
                .ForeignKey("dbo.Machineries", t => t.MachineryID_FK)
                .Index(t => t.MachineryID_FK)
                .Index(t => t.UnitID_FK);
            
            CreateTable(
                "dbo.SpareParts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MachineryID_FK = c.Int(nullable: false),
                        SparePartTitle = c.String(nullable: false, maxLength: 250),
                        SparePartNumber = c.String(maxLength: 150),
                        Minimal = c.Int(nullable: false),
                        UnitID_FK = c.Int(nullable: false),
                        Description = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitOfMeasurements", t => t.UnitID_FK)
                .ForeignKey("dbo.Machineries", t => t.MachineryID_FK)
                .Index(t => t.MachineryID_FK)
                .Index(t => t.UnitID_FK);
            
            CreateTable(
                "dbo.PublicTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Group = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        RequestID_FK = c.Long(nullable: false),
                        WorkingTotalMin = c.Int(nullable: false),
                        StopTotalMin = c.Int(nullable: false),
                        RepairOutside = c.Boolean(nullable: false),
                        RepairOutSideReportID_FK = c.Int(),
                        StartWorking = c.DateTime(nullable: false),
                        EndWorking = c.DateTime(nullable: false),
                        Cause_Exhaustion = c.Boolean(nullable: false),
                        Cause_OperatorNegligence = c.Boolean(nullable: false),
                        Cause_QualityofSpareParts = c.Boolean(nullable: false),
                        OtherError = c.Boolean(nullable: false),
                        OtherErrorDescription = c.String(maxLength: 250),
                        ReportRepair = c.String(nullable: false, maxLength: 700),
                        PersonHours = c.Boolean(nullable: false),
                        PersonHoursTime = c.Short(nullable: false),
                        PersonHoursDescription = c.String(maxLength: 250),
                        ProductionPlanning = c.Boolean(nullable: false),
                        ProductionPlanningTime = c.Short(nullable: false),
                        ProductionPlanningDescription = c.String(maxLength: 250),
                        NoSpareParts = c.Boolean(nullable: false),
                        NoSparePartsTime = c.Short(nullable: false),
                        NoSparePartsDescription = c.String(maxLength: 250),
                        Other = c.Boolean(nullable: false),
                        OtherTime = c.Short(nullable: false),
                        OtherDescription = c.String(maxLength: 250),
                        CloseRequest = c.Boolean(nullable: false),
                        DateTimeClosing = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RequestRepairs", t => t.RequestID_FK)
                .Index(t => t.RequestID_FK);
            
            CreateTable(
                "dbo.RepairManListeds",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        RepairManIdFk = c.Int(nullable: false),
                        WorkOrderIdFk = c.Long(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RepairMen", t => t.RepairManIdFk)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderIdFk)
                .Index(t => t.RepairManIdFk)
                .Index(t => t.WorkOrderIdFk);
            
            CreateTable(
                "dbo.RepairMen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Repairman_FullName = c.String(nullable: false, maxLength: 250),
                        RepairMan_Status = c.String(nullable: false, maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequestRepairs", "ApplicantID_FK", "dbo.Applicants");
            DropForeignKey("dbo.Machineries", "ApplicantID_FK", "dbo.Applicants");
            DropForeignKey("dbo.IdentityMachineries", "ApplicantID_FK", "dbo.Applicants");
            DropForeignKey("dbo.SubGroups", "CompanyID_FK", "dbo.Companies");
            DropForeignKey("dbo.RequestRepairs", "CompanyID_FK", "dbo.Companies");
            DropForeignKey("dbo.Groups", "CompanyID_FK", "dbo.Companies");
            DropForeignKey("dbo.Codings", "CompanyID_FK", "dbo.Companies");
            DropForeignKey("dbo.ApplicationUsers", "CompanyID_FK", "dbo.Companies");
            DropForeignKey("dbo.RequestRepairs", "UserID_FK", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Codings", "UserID_FK", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Machineries", "CodeID_FK", "dbo.Codings");
            DropForeignKey("dbo.SpareParts", "MachineryID_FK", "dbo.Machineries");
            DropForeignKey("dbo.ServicePeriodes", "MachineryID_FK", "dbo.Machineries");
            DropForeignKey("dbo.RequestRepairs", "MachineryID_FK", "dbo.Machineries");
            DropForeignKey("dbo.WorkOrders", "RequestID_FK", "dbo.RequestRepairs");
            DropForeignKey("dbo.RepairManListeds", "WorkOrderIdFk", "dbo.WorkOrders");
            DropForeignKey("dbo.RepairManListeds", "RepairManIdFk", "dbo.RepairMen");
            DropForeignKey("dbo.RequestRepairs", "PublicTypeID_FK", "dbo.PublicTypes");
            DropForeignKey("dbo.ConsumableParts", "RequestID_FK", "dbo.RequestRepairs");
            DropForeignKey("dbo.SpareParts", "UnitID_FK", "dbo.UnitOfMeasurements");
            DropForeignKey("dbo.ServicePeriodes", "UnitID_FK", "dbo.UnitOfMeasurements");
            DropForeignKey("dbo.ConsumableParts", "UnitID_FK", "dbo.UnitOfMeasurements");
            DropForeignKey("dbo.PowerElectricalMachineries", "MachineryID_FK", "dbo.Machineries");
            DropForeignKey("dbo.IdentityMachineries", "MachinerID_FK", "dbo.Machineries");
            DropForeignKey("dbo.SubGroups", "GroupID_FK", "dbo.Groups");
            DropForeignKey("dbo.Codings", "SubGroupID_FK", "dbo.SubGroups");
            DropForeignKey("dbo.Codings", "GroupID_FK", "dbo.Groups");
            DropForeignKey("dbo.Cleams", "UserID_FK", "dbo.ApplicationUsers");
            DropForeignKey("dbo.MenuItems", "GroupID_FK", "dbo.MenuGroups");
            DropForeignKey("dbo.Cleams", "MenuItemID_FK", "dbo.MenuItems");
            DropForeignKey("dbo.Cleams", "GroupID_FK", "dbo.MenuGroups");
            DropForeignKey("dbo.Applicants", "CompanyID_FK", "dbo.Companies");
            DropIndex("dbo.RepairManListeds", new[] { "WorkOrderIdFk" });
            DropIndex("dbo.RepairManListeds", new[] { "RepairManIdFk" });
            DropIndex("dbo.WorkOrders", new[] { "RequestID_FK" });
            DropIndex("dbo.SpareParts", new[] { "UnitID_FK" });
            DropIndex("dbo.SpareParts", new[] { "MachineryID_FK" });
            DropIndex("dbo.ServicePeriodes", new[] { "UnitID_FK" });
            DropIndex("dbo.ServicePeriodes", new[] { "MachineryID_FK" });
            DropIndex("dbo.ConsumableParts", new[] { "UnitID_FK" });
            DropIndex("dbo.ConsumableParts", new[] { "RequestID_FK" });
            DropIndex("dbo.RequestRepairs", new[] { "ApplicantID_FK" });
            DropIndex("dbo.RequestRepairs", new[] { "PublicTypeID_FK" });
            DropIndex("dbo.RequestRepairs", new[] { "UserID_FK" });
            DropIndex("dbo.RequestRepairs", new[] { "MachineryID_FK" });
            DropIndex("dbo.RequestRepairs", new[] { "CompanyID_FK" });
            DropIndex("dbo.PowerElectricalMachineries", new[] { "MachineryID_FK" });
            DropIndex("dbo.IdentityMachineries", new[] { "ApplicantID_FK" });
            DropIndex("dbo.IdentityMachineries", new[] { "MachinerID_FK" });
            DropIndex("dbo.Machineries", new[] { "ApplicantID_FK" });
            DropIndex("dbo.Machineries", new[] { "CodeID_FK" });
            DropIndex("dbo.SubGroups", new[] { "GroupID_FK" });
            DropIndex("dbo.SubGroups", new[] { "CompanyID_FK" });
            DropIndex("dbo.Groups", new[] { "CompanyID_FK" });
            DropIndex("dbo.Codings", new[] { "UserID_FK" });
            DropIndex("dbo.Codings", new[] { "SubGroupID_FK" });
            DropIndex("dbo.Codings", new[] { "GroupID_FK" });
            DropIndex("dbo.Codings", new[] { "CompanyID_FK" });
            DropIndex("dbo.MenuItems", new[] { "GroupID_FK" });
            DropIndex("dbo.Cleams", new[] { "MenuItemID_FK" });
            DropIndex("dbo.Cleams", new[] { "GroupID_FK" });
            DropIndex("dbo.Cleams", new[] { "UserID_FK" });
            DropIndex("dbo.ApplicationUsers", new[] { "CompanyID_FK" });
            DropIndex("dbo.Applicants", new[] { "CompanyID_FK" });
            DropTable("dbo.RepairMen");
            DropTable("dbo.RepairManListeds");
            DropTable("dbo.WorkOrders");
            DropTable("dbo.PublicTypes");
            DropTable("dbo.SpareParts");
            DropTable("dbo.ServicePeriodes");
            DropTable("dbo.UnitOfMeasurements");
            DropTable("dbo.ConsumableParts");
            DropTable("dbo.RequestRepairs");
            DropTable("dbo.PowerElectricalMachineries");
            DropTable("dbo.IdentityMachineries");
            DropTable("dbo.Machineries");
            DropTable("dbo.SubGroups");
            DropTable("dbo.Groups");
            DropTable("dbo.Codings");
            DropTable("dbo.MenuItems");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Cleams");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.Companies");
            DropTable("dbo.Applicants");
        }
    }
}
