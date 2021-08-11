using PMWORK.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMWORK
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("Conn")
        {
            //Database.SetInitializer(new PMDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<ApplicationUser>().HasKey(x => x.UserId);
            builder.Entity<ApplicationUser>().Property(x => x.UserId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<ApplicationUser>().Property(x => x.UserName).IsRequired().HasMaxLength(20);
            builder.Entity<ApplicationUser>().Property(x => x.UserPassword).IsRequired().HasMaxLength(100);
            builder.Entity<ApplicationUser>().Property(x => x.FullName).IsRequired().HasMaxLength(200);
            builder.Entity<ApplicationUser>().Property(x => x.LimetedCompany).IsRequired();
            builder.Entity<ApplicationUser>().Property(x => x.Editor).IsRequired().HasMaxLength(10);
            builder.Entity<ApplicationUser>()
                .HasMany(x => x.RequestRepairs)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.UserID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<ApplicationUser>()
                .HasMany(x => x.Codings)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.UserID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<ApplicationUser>()
    .HasMany(x => x.Cleams)
    .WithRequired(x => x.ApplicationUser)
    .HasForeignKey(x => x.UserID_FK)
    .WillCascadeOnDelete(false);





            builder.Entity<MenuGroup>().HasKey(x => x.GroupID);
            builder.Entity<MenuGroup>().Property(x => x.GroupID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<MenuGroup>().Property(x => x.MenuGroupTitle).IsRequired().HasMaxLength(100);
            builder.Entity<MenuGroup>().Property(x => x.Description).IsRequired().HasMaxLength(250);
            builder.Entity<MenuGroup>()
                .HasMany(x => x.MenuItems)
                .WithRequired(x => x.MenuGroup)
                .HasForeignKey(x => x.GroupID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<MenuGroup>()
                .HasMany(x => x.Cleams)
                .WithRequired(x => x.MenuGroup)
                .HasForeignKey(x => x.GroupID_FK)
                .WillCascadeOnDelete(false);



            builder.Entity<MenuItem>().HasKey(x => x.ItemID);
            builder.Entity<MenuItem>().Property(x => x.ItemID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<MenuItem>().Property(x => x.GroupID_FK).IsRequired();
            builder.Entity<MenuItem>().Property(x => x.ItemTitel).HasMaxLength(150).IsRequired();
            builder.Entity<MenuItem>().Property(x => x.Description).IsRequired().HasMaxLength(250);
            builder.Entity<MenuItem>()
                .HasMany(x => x.Cleams)
                .WithRequired(x => x.MenuItem)
                .HasForeignKey(x => x.MenuItemID_FK)
                .WillCascadeOnDelete(false);

            builder.Entity<Cleam>().HasKey(x => x.ID);
            builder.Entity<Cleam>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<Cleam>().Property(x => x.UserID_FK).IsRequired();
            builder.Entity<Cleam>().Property(x => x.MenuItemID_FK).IsRequired();
            builder.Entity<Cleam>().Property(x => x.GroupID_FK).IsRequired();
            builder.Entity<Cleam>().Property(x => x.IsDelete).IsRequired();


            builder.Entity<Coding>().HasKey(x => x.ID);
            builder.Entity<Coding>().Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<Coding>().Property(x => x.CodeIndex).IsRequired();
            builder.Entity<Coding>().Property(x => x.Code).IsRequired();
            builder.Entity<Coding>().Property(x => x.CodeTitle).IsRequired().HasMaxLength(150);
            builder.Entity<Coding>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Coding>()
                .HasMany(x => x.Machineries)
                .WithRequired(x => x.Coding)
                .HasForeignKey(x => x.CodeID_FK)
                .WillCascadeOnDelete(false);




            builder.Entity<Applicant>().HasKey(x => x.ID);
            builder.Entity<Applicant>().Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            builder.Entity<Applicant>().Property(x => x.ApplicantTitle).IsRequired().HasMaxLength(150);
            builder.Entity<Applicant>().Property(x => x.CompanyID_FK).IsRequired();
            builder.Entity<Applicant>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Applicant>()
                .HasMany(x => x.RequestRepairs)
                .WithRequired(x => x.Applicant)
                .HasForeignKey(x => x.ApplicantID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<Applicant>()
                 .HasMany(x => x.Machineries)
                 .WithRequired(x => x.Applicant)
                  .HasForeignKey(x => x.ApplicantID_FK)
                  .WillCascadeOnDelete(false);
            builder.Entity<Applicant>()
     .HasMany(x => x.IdentityMachineries)
     .WithRequired(x => x.Applicant)
      .HasForeignKey(x => x.ApplicantID_FK)
      .WillCascadeOnDelete(false);




            builder.Entity<Company>().HasKey(x => x.ID);
            builder.Entity<Company>().Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            builder.Entity<Company>().Property(x => x.CompnayIndex).IsRequired();
            builder.Entity<Company>().Property(x => x.CompanyTitle).IsRequired().HasMaxLength(150);
            builder.Entity<Company>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Company>()
                .HasMany(x => x.Groups)
                .WithRequired(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<Company>()
                .HasMany(x => x.SubGroups)
                .WithRequired(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<Company>()
                .HasMany<Coding>(x => x.Codings)
                .WithRequired(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<Company>()
                 .HasMany<Applicant>(x => x.Applicants)
                 .WithRequired(x => x.Company)
                 .HasForeignKey(x => x.CompanyID_FK)
                 .WillCascadeOnDelete(false);
            builder.Entity<Company>()
                 .HasMany<RequestRepair>(x => x.RequestRepairs)
                 .WithRequired(x => x.Company)
                 .HasForeignKey(x => x.CompanyID_FK)
                 .WillCascadeOnDelete(false);
            builder.Entity<Company>()
                  .HasMany<ApplicationUser>(x => x.ApplicationUsers)
                  .WithRequired(x => x.Company)
                  .HasForeignKey(x => x.CompanyID_FK)
                  .WillCascadeOnDelete(false);




            builder.Entity<ConsumablePart>().HasKey(x => x.ID);
            builder.Entity<ConsumablePart>().Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            builder.Entity<ConsumablePart>().Property(x => x.ConsumablePartTitel).HasMaxLength(250).IsRequired();
            builder.Entity<ConsumablePart>().Property(x => x.Number).IsRequired();
            builder.Entity<ConsumablePart>().Property(x => x.RequestID_FK).IsRequired();
            builder.Entity<ConsumablePart>().Property(x => x.UnitID_FK).IsRequired();


            builder.Entity<Group>().HasKey(x => x.ID);
            builder.Entity<Group>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<Group>().Property(x => x.GroupIndex).IsRequired();
            builder.Entity<Group>().Property(x => x.GroupTitle).IsRequired().HasMaxLength(150);
            builder.Entity<Group>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Group>()
                .HasMany(x => x.SubGroups)
                .WithRequired(x => x.Group)
                .HasForeignKey(x => x.GroupID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<Group>()
                .HasMany(x => x.Codings)
                .WithRequired(x => x.Group)
                .HasForeignKey(x => x.GroupID_FK)
                .WillCascadeOnDelete(false);


            builder.Entity<Machinery>().HasKey(x => x.ID);
            builder.Entity<Machinery>().Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            builder.Entity<Machinery>().Property(x => x.IsActive).IsRequired();
            builder.Entity<Machinery>().Property(x => x.IsDelete).IsRequired();
            builder.Entity<Machinery>().Property(x => x.CompanyID).IsRequired();
            builder.Entity<Machinery>().Property(x => x.CodeID_FK).IsRequired();
            builder.Entity<Machinery>().Property(x => x.ApplicantID_FK).IsRequired();
            builder.Entity<Machinery>().Property(x => x.MachineryTitle).HasMaxLength(150).IsRequired();
            builder.Entity<Machinery>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Machinery>()
                .HasMany(x => x.RequestRepairs)
                .WithRequired(x => x.Machinery)
                .HasForeignKey(x => x.MachineryID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<Machinery>()
    .HasMany(x => x.SpareParts)
    .WithRequired(x => x.Machinery)
    .HasForeignKey(x => x.MachineryID_FK)
    .WillCascadeOnDelete(false);
            builder.Entity<Machinery>()
    .HasMany(x => x.ServicePeriodes)
    .WithRequired(x => x.Machinery)
    .HasForeignKey(x => x.MachineryID_FK)
    .WillCascadeOnDelete(false);
            builder.Entity<Machinery>()
.HasMany(x => x.PowerElectricalMachineries)
.WithRequired(x => x.Machinery)
.HasForeignKey(x => x.MachineryID_FK)
.WillCascadeOnDelete(false);
            builder.Entity<Machinery>()
.HasMany(x => x.IdentityMachineries)
.WithRequired(x => x.Machinery)
.HasForeignKey(x => x.MachinerID_FK)
.WillCascadeOnDelete(false);



            builder.Entity<RequestRepair>().HasKey(x => x.ID);
            builder.Entity<RequestRepair>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<RequestRepair>().Property(x => x.IsActive).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.IsDelete).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.EM).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.IsClose).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.IsRepairOut).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.PublicTypeID_FK).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.MachineryID_FK).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.UserID_FK).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.CompanyID_FK).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.RequestDataTime).IsRequired().HasColumnType("datetime");
            builder.Entity<RequestRepair>().Property(x => x.ApplicantID_FK).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.RequestTitle).HasMaxLength(500).IsRequired();
            builder.Entity<RequestRepair>()
                .HasMany(x => x.ConsumableParts)
                .WithRequired(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<RequestRepair>()
                .HasMany(x => x.WorkOrders)
                .WithRequired(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<RequestRepair>()
                .HasMany(x => x.Repairouts)
                .WithRequired(x => x.RequestRepair)
                .HasForeignKey(x => x.RequestID_FK)
                .WillCascadeOnDelete(false);




            builder.Entity<SubGroup>().HasKey(x => x.ID);
            builder.Entity<SubGroup>().Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<SubGroup>().Property(x => x.CompanyID_FK).IsRequired();
            builder.Entity<SubGroup>().Property(x => x.GroupID_FK).IsRequired();
            builder.Entity<SubGroup>().Property(x => x.SubGroupIndex).IsRequired();
            builder.Entity<SubGroup>().Property(x => x.SubGroupTitle).IsRequired().HasMaxLength(150);
            builder.Entity<SubGroup>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<SubGroup>()
                .HasMany(x => x.Codings)
                .WithRequired(x => x.SubGroup)
                .HasForeignKey(x => x.SubGroupID_FK)
                .WillCascadeOnDelete(false);



            builder.Entity<UnitOfMeasurement>().HasKey(x => x.ID);
            builder.Entity<UnitOfMeasurement>().Property(a => a.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<UnitOfMeasurement>().Property(u => u.Unit).HasMaxLength(150).IsRequired();
            builder.Entity<UnitOfMeasurement>().Property(u => u.Description).HasMaxLength(250);
            builder.Entity<UnitOfMeasurement>()
                .HasMany(x => x.ConsumableParts)
                .WithRequired(x => x.UnitOfMeasurement)
                .HasForeignKey(x => x.UnitID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<UnitOfMeasurement>()
                 .HasMany(x => x.ServicePeriodes)
                 .WithRequired(x => x.UnitOfMeasurement)
                 .HasForeignKey(x => x.UnitID_FK)
                 .WillCascadeOnDelete(false);
            builder.Entity<UnitOfMeasurement>()
                 .HasMany(x => x.SpareParts)
                 .WithRequired(x => x.UnitOfMeasurement)
                 .HasForeignKey(x => x.UnitID_FK)
                 .WillCascadeOnDelete(false);


            builder.Entity<WorkOrder>().HasKey(x => x.ID);
            builder.Entity<WorkOrder>().Property(s => s.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<WorkOrder>().Property(d => d.IsDelete).IsRequired();
            builder.Entity<WorkOrder>().Property(d => d.WorkingTotalMin).IsRequired();
            builder.Entity<WorkOrder>().Property(d => d.StopTotalMin).IsRequired();
            builder.Entity<WorkOrder>().Property(r => r.RequestID_FK).IsRequired();
            builder.Entity<WorkOrder>().Property(x => x.StartWorking).IsRequired().HasColumnType("datetime");
            builder.Entity<WorkOrder>().Property(x => x.EndWorking).IsRequired().HasColumnType("datetime");
            builder.Entity<WorkOrder>().Property(x => x.OtherErrorDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>().Property(x => x.ReportRepair).HasMaxLength(700).IsRequired();
            builder.Entity<WorkOrder>().Property(p => p.PersonHoursDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>().Property(p => p.NoSparePartsDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>().Property(p => p.OtherDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>().Property(p => p.ProductionPlanningDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>()
                .HasMany(x => x.RepairManListeds)
                .WithRequired(x => x.WorkOrder)
                .HasForeignKey(x => x.WorkOrderIdFk)
                .WillCascadeOnDelete(false);

            builder.Entity<PublicType>().HasKey(x => x.ID);
            builder.Entity<PublicType>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<PublicType>().Property(x => x.Title).IsRequired();
            builder.Entity<PublicType>().Property(x => x.Group).IsRequired();
            builder.Entity<PublicType>()
                .HasMany(x => x.RequestRepairs)
                .WithRequired(x => x.PublicType)
                .HasForeignKey(x => x.PublicTypeID_FK)
                .WillCascadeOnDelete(false);



            builder.Entity<RepairMan>().HasKey(x => x.ID);
            builder.Entity<RepairMan>().Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<RepairMan>().Property(x => x.IsActive).IsRequired();
            builder.Entity<RepairMan>().Property(x => x.Repairman_FullName).IsRequired().HasMaxLength(250);
            builder.Entity<RepairMan>().Property(x => x.RepairMan_Status).IsRequired().HasMaxLength(250);
            builder.Entity<RepairMan>()
                .HasMany(x => x.RepairManListeds)
                .WithRequired(x => x.RepairMan)
                .HasForeignKey(x => x.RepairManIdFk)
                .WillCascadeOnDelete(false);


            builder.Entity<RepairManListed>().HasKey(x => x.ID);
            builder.Entity<RepairManListed>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<RepairManListed>().Property(x => x.IsDelete).IsRequired();
            builder.Entity<RepairManListed>().Property(x => x.RepairManIdFk).IsRequired();
            builder.Entity<RepairManListed>().Property(x => x.WorkOrderIdFk).IsRequired();


            builder.Entity<SparePart>().HasKey(x => x.ID);
            builder.Entity<SparePart>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<SparePart>().Property(x => x.MachineryID_FK).IsRequired();
            builder.Entity<SparePart>().Property(x => x.Minimal).IsRequired();
            builder.Entity<SparePart>().Property(x => x.SparePartNumber).HasMaxLength(150);
            builder.Entity<SparePart>().Property(x => x.SparePartTitle).IsRequired().HasMaxLength(250);
            builder.Entity<SparePart>().Property(x => x.UnitID_FK).IsRequired();
            builder.Entity<SparePart>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<SparePart>().Property(x => x.IsActive).IsRequired();


            builder.Entity<ServicePeriode>().HasKey(x => x.ID);
            builder.Entity<ServicePeriode>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<ServicePeriode>().Property(x => x.MachineryID_FK).IsRequired();
            builder.Entity<ServicePeriode>().Property(x => x.Periode).IsRequired();
            builder.Entity<ServicePeriode>().Property(x => x.ServiceTitle).IsRequired().HasMaxLength(250);
            builder.Entity<ServicePeriode>().Property(x => x.UnitID_FK).IsRequired();
            builder.Entity<ServicePeriode>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<ServicePeriode>().Property(x => x.IsActive).IsRequired();
            builder.Entity<ServicePeriode>().Property(x => x.Registred).IsRequired().HasColumnType("datetime");


            builder.Entity<IdentityMachinery>().HasKey(x => x.ID);
            builder.Entity<IdentityMachinery>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<IdentityMachinery>().Property(x => x.dateTimeImport).IsRequired().HasColumnType("datetime");
            builder.Entity<IdentityMachinery>().Property(x => x.dateTimeStart).IsRequired().HasColumnType("datetime");
            builder.Entity<IdentityMachinery>().Property(x => x.MachinerID_FK).IsRequired();
            builder.Entity<IdentityMachinery>().Property(x => x.TypeDevice).HasMaxLength(250);
            builder.Entity<IdentityMachinery>().Property(x => x.ApplicantID_FK).IsRequired();




            builder.Entity<PowerElectricalMachinery>().HasKey(x => x.ID);
            builder.Entity<PowerElectricalMachinery>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<PowerElectricalMachinery>().Property(x => x.MachineryID_FK).IsRequired();
            builder.Entity<PowerElectricalMachinery>().Property(x => x.Manifactor).HasMaxLength(250);
            builder.Entity<PowerElectricalMachinery>().Property(x => x.Title).HasMaxLength(250);
            builder.Entity<PowerElectricalMachinery>().Property(x => x.KW).HasMaxLength(10);
            builder.Entity<PowerElectricalMachinery>().Property(x => x.Voltag).HasMaxLength(10);
            builder.Entity<PowerElectricalMachinery>().Property(x => x.Amper).HasMaxLength(10);
            builder.Entity<PowerElectricalMachinery>().Property(x => x.IsDelete).IsRequired();


            builder.Entity<Repairout>().HasKey(x => x.ID);
            builder.Entity<Repairout>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<Repairout>().Property(x => x.IsClosed).IsRequired();
            builder.Entity<Repairout>().Property(x => x.IsActive).IsRequired();
            builder.Entity<Repairout>().Property(x => x.IsDelete).IsRequired();
            builder.Entity<Repairout>().Property(x => x.Regidtered).IsRequired().HasColumnType("datetime");
            builder.Entity<Repairout>().Property(x => x.BackendRequest).IsRequired().HasColumnType("datetime");
            builder.Entity<Repairout>().Property(x => x.CompanyID_FK).IsRequired();
            builder.Entity<Repairout>().Property(x => x.RequestID_FK).IsRequired();
            builder.Entity<Repairout>().Property(x => x.RepairOutFullName).IsRequired().HasMaxLength(250);
            builder.Entity<Repairout>().Property(x => x.RepairReportOut).HasMaxLength(500);
            builder.Entity<Repairout>().Property(x => x.RequestRepairOut).IsRequired().HasMaxLength(500);



        }



        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Coding> Codings { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ConsumablePart> ConsumableParts { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Machinery> Machineries { get; set; }
        public virtual DbSet<RequestRepair> RequestRepairs { get; set; }
        public virtual DbSet<SubGroup> SubGroups { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Cleam> Cleams { get; set; }
        public virtual DbSet<PublicType> PublicTypes { get; set; }
        public virtual DbSet<RepairMan> RepairMens { get; set; }
        public virtual DbSet<RepairManListed> RepairManListeds { get; set; }
        public virtual DbSet<SparePart> SpareParts { get; set; }
        public virtual DbSet<ServicePeriode> ServicePeriodes { get; set; }
        public virtual DbSet<IdentityMachinery> IdentityMachineries { get; set; }
        public virtual DbSet<PowerElectricalMachinery> PowerElectricalMachineries { get; set; }
        public virtual DbSet<Repairout> Repairouts { get; set; }

    }
}
