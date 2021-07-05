using PMWORK.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMWORK
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("Conn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<ApplicationUser>().HasKey(x => x.UserId);
            builder.Entity<ApplicationUser>().Property(x => x.UserId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<ApplicationUser>().Property(x => x.UserName).IsRequired().HasMaxLength(20);
            builder.Entity<ApplicationUser>().Property(x => x.UserPassword).IsRequired().HasMaxLength(100);
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





            builder.Entity<MenuGroup>().HasKey(x => x.GroupID);
            builder.Entity<MenuGroup>().Property(x => x.GroupID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<MenuGroup>().Property(x => x.MenuGroupTitle).IsRequired().HasMaxLength(100);
            builder.Entity<MenuGroup>()
                .HasMany(x => x.MenuItems)
                .WithRequired(x => x.MenuGroup)
                .HasForeignKey(x => x.GroupID_FK)
                .WillCascadeOnDelete(false);



            builder.Entity<MenuItem>().HasKey(x => x.ItemID);
            builder.Entity<MenuItem>().Property(x => x.ItemID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<MenuItem>().Property(x => x.GroupID_FK).IsRequired();
            builder.Entity<MenuItem>().Property(x => x.ItemTitel).HasMaxLength(150).IsRequired();
            builder.Entity<MenuItem>()
                .HasMany(x => x.Cleams)
                .WithRequired(x => x.MenuItem)
                .HasForeignKey(x => x.MenuItemID_FK)
                .WillCascadeOnDelete(false);

            builder.Entity<Cleam>().HasKey(x => x.ID);
            builder.Entity<Cleam>().Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<Cleam>().Property(x => x.UserID_FK).IsRequired();
            builder.Entity<Cleam>().Property(x => x.MenuItemID_FK).IsRequired();






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
            builder.Entity<Applicant>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Applicant>()
                .HasMany(x => x.RequestRepairs)
                .WithRequired(x => x.Applicant)
                .HasForeignKey(x => x.ApplicantID_FK)
                .WillCascadeOnDelete(false);

            builder.Entity<Company>().HasKey(x => x.ID);
            builder.Entity<Company>().Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            builder.Entity<Company>().Property(x => x.CompnayIndex).IsRequired();
            builder.Entity<Company>().Property(x => x.CompanyTiltle).IsRequired().HasMaxLength(150);
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
            builder.Entity<Machinery>().Property(x => x.CodeID_FK).IsRequired();
            builder.Entity<Machinery>().Property(x => x.MachineryTitle).HasMaxLength(150).IsRequired();
            builder.Entity<Machinery>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Machinery>()
                .HasMany(x => x.RequestRepairs)
                .WithRequired(x => x.Machinery)
                .HasForeignKey(x => x.MachineryID_FK)
                .WillCascadeOnDelete(false);



            builder.Entity<RequestRepair>().HasKey(x => x.ID);
            builder.Entity<RequestRepair>().Property(x => x.ID).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<RequestRepair>().Property(x => x.Registered).IsRequired().HasColumnType("datetime");
            builder.Entity<RequestRepair>().Property(x => x.IsActive).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.IsDelete).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.MachineryID_FK).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.UserID_FK).IsRequired();
            builder.Entity<RequestRepair>().Property(x => x.RequestDataTime).IsRequired().HasColumnType("datetime");
            builder.Entity<RequestRepair>().Property(x => x.TypeofRepairID_FK).IsRequired();
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


            builder.Entity<TypeofRepair>().HasKey(x => x.ID);
            builder.Entity<TypeofRepair>().Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<TypeofRepair>().Property(x => x.TypeTitle).IsRequired().HasMaxLength(250);
            builder.Entity<TypeofRepair>()
                .HasMany(x => x.RequestRepairs)
                .WithRequired(x => x.TypeofRepair)
                .HasForeignKey(x => x.TypeofRepairID_FK)
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


            builder.Entity<WorkOrder>().HasKey(x => x.ID);
            builder.Entity<WorkOrder>().Property(s => s.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<WorkOrder>().Property(s => s.IsActive).IsRequired();
            builder.Entity<WorkOrder>().Property(d => d.IsDelete).IsRequired();
            builder.Entity<WorkOrder>().Property(r => r.RequestID_FK).IsRequired();
            builder.Entity<WorkOrder>().Property(x => x.StartWorking).IsRequired().HasColumnType("datetime");
            builder.Entity<WorkOrder>().Property(x => x.OtherErrorDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>().Property(x => x.ReportRepair).HasMaxLength(700).IsRequired();
            builder.Entity<WorkOrder>().Property(p => p.PersonHoursDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>().Property(p => p.NoSparePartsDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>().Property(p => p.OtherDescription).HasMaxLength(250);
            builder.Entity<WorkOrder>().Property(p => p.ProductionPlanningDescription).HasMaxLength(250);




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
        public virtual DbSet<TypeofRepair> TypeofRepairs { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Cleam> Cleams { get; set; }


    }
}
