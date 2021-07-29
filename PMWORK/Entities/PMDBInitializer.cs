﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PMWORK.Entities
{
    public class PMDBInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            IList<ApplicationUser> defaultUsers = new List<ApplicationUser>();
            defaultUsers.Add(new ApplicationUser() { UserId = 1, Enabled = true, UserName = "admin", UserPassword = "admin" }); ;
            context.ApplicationUsers.AddRange(defaultUsers);

            IList<Company> defaultCompany = new List<Company>();
            defaultCompany.Add(new Company() { ID = 1, CompanyTitle = "کیمیای زنجان گستران", CompnayIndex = 1, Description = "کیمیای زنجان گستران" });
            defaultCompany.Add(new Company() { ID = 2, CompanyTitle = "سرب و روی ایرانیان", CompnayIndex = 2, Description = "کیمیای زنجان گستران" });
            defaultCompany.Add(new Company() { ID = 3, CompanyTitle = "ذوبگران رنگین فلز", CompnayIndex = 3, Description = "کیمیای زنجان گستران" });
            context.Companies.AddRange(defaultCompany);

            IList<Group> defaultGroup = new List<Group>();
            defaultGroup.Add(new Group() { ID = 1, GroupTitle = "تولیدی", CompanyID_FK = 1, GroupIndex = 1, Description = "تولیدی" });
            defaultGroup.Add(new Group() { ID = 2, GroupTitle = "کیفی و آزمایشگاهی", CompanyID_FK = 1, GroupIndex = 2, Description = "کیفی و آزمایشگاهی" });
            defaultGroup.Add(new Group() { ID = 3, GroupTitle = "کمک تولیدی", CompanyID_FK = 1, GroupIndex = 3, Description = "کمک تولیدی" });
            defaultGroup.Add(new Group() { ID = 4, GroupTitle = "نگهداری تعمیرات", CompanyID_FK = 1, GroupIndex = 4, Description = "نگهداری تعمیرات" });

            defaultGroup.Add(new Group() { ID = 5, GroupTitle = "تولیدی", CompanyID_FK = 2, GroupIndex = 1, Description = "تولیدی" });
            defaultGroup.Add(new Group() { ID = 6, GroupTitle = "کیفی و آزمایشگاهی", CompanyID_FK = 2, GroupIndex = 2, Description = "کیفی و آزمایشگاهی" });
            defaultGroup.Add(new Group() { ID = 7, GroupTitle = "کمک تولیدی", CompanyID_FK = 2, GroupIndex = 3, Description = "کمک تولیدی" });
            defaultGroup.Add(new Group() { ID = 8, GroupTitle = "نگهداری تعمیرات", CompanyID_FK = 2, GroupIndex = 4, Description = "نگهداری تعمیرات" });

            defaultGroup.Add(new Group() { ID = 9, GroupTitle = "تولیدی", CompanyID_FK = 3, GroupIndex = 1, Description = "تولیدی" });
            defaultGroup.Add(new Group() { ID = 10, GroupTitle = "کیفی و آزمایشگاهی", CompanyID_FK = 3, GroupIndex = 2, Description = "کیفی و آزمایشگاهی" });
            defaultGroup.Add(new Group() { ID = 11, GroupTitle = "کمک تولیدی", CompanyID_FK = 3, GroupIndex = 3, Description = "کمک تولیدی" });
            defaultGroup.Add(new Group() { ID = 12, GroupTitle = "نگهداری تعمیرات", CompanyID_FK = 3, GroupIndex = 4, Description = "نگهداری تعمیرات" });
            context.Groups.AddRange(defaultGroup);

            IList<SubGroup> defaultSubGroup = new List<SubGroup>();
            defaultSubGroup.Add(new SubGroup() { ID = 1, SubGroupTitle = "خردایش", CompanyID_FK = 1, GroupID_FK = 1, SubGroupIndex = 1, Description = "خردایش" });
            defaultSubGroup.Add(new SubGroup() { ID = 2, SubGroupTitle = "تلغیظ", CompanyID_FK = 1, GroupID_FK = 1, SubGroupIndex = 2, Description = "تلغیظ" });
            defaultSubGroup.Add(new SubGroup() { ID = 3, SubGroupTitle = "پمپ", CompanyID_FK = 1, GroupID_FK = 1, SubGroupIndex = 3, Description = "پمپ" });
            defaultSubGroup.Add(new SubGroup() { ID = 4, SubGroupTitle = "هواساز", CompanyID_FK = 1, GroupID_FK = 1, SubGroupIndex = 4, Description = "هواساز" });

            defaultSubGroup.Add(new SubGroup() { ID = 5, SubGroupTitle = "خردایش", CompanyID_FK = 2, GroupID_FK = 5, SubGroupIndex = 1, Description = "خردایش" });
            defaultSubGroup.Add(new SubGroup() { ID = 6, SubGroupTitle = "تلغیظ", CompanyID_FK = 2, GroupID_FK = 5, SubGroupIndex = 2, Description = "تلغیظ" });
            defaultSubGroup.Add(new SubGroup() { ID = 7, SubGroupTitle = "پمپ", CompanyID_FK = 2, GroupID_FK = 5, SubGroupIndex = 3, Description = "پمپ" });
            defaultSubGroup.Add(new SubGroup() { ID = 8, SubGroupTitle = "هواساز", CompanyID_FK = 2, GroupID_FK = 5, SubGroupIndex = 4, Description = "هواساز" });
            context.SubGroups.AddRange(defaultSubGroup);


            IList<PublicType> defaultType = new List<PublicType>();
            defaultType.Add(new PublicType() { ID = 1, Title = "برقی", Group = 1 });
            defaultType.Add(new PublicType() { ID = 2, Title = "مکانیکی", Group = 1 });
            defaultType.Add(new PublicType() { ID = 3, Title = "تاسیساتی", Group = 1 });
            defaultType.Add(new PublicType() { ID = 4, Title = "تجهیز", Group = 1 });
            defaultType.Add(new PublicType() { ID = 5, Title = "ساخت", Group = 1 });
            context.PublicTypes.AddRange(defaultType);




            IList<Applicant> defaultApplica = new List<Applicant>();
            defaultApplica.Add(new Applicant() { ID = 1, ApplicantTitle = "فیلتراسیون", CompanyID_FK = 1 });
            defaultApplica.Add(new Applicant() { ID = 2, ApplicantTitle = "فلوتاسیون", CompanyID_FK = 1 });
            defaultApplica.Add(new Applicant() { ID = 3, ApplicantTitle = "خردایش", CompanyID_FK = 1 });
            defaultApplica.Add(new Applicant() { ID = 4, ApplicantTitle = "فیلتراسیون", CompanyID_FK = 2 });
            defaultApplica.Add(new Applicant() { ID = 5, ApplicantTitle = "فلوتاسیون", CompanyID_FK = 2 });
            defaultApplica.Add(new Applicant() { ID = 6, ApplicantTitle = "خردایش", CompanyID_FK = 2 });
            context.Applicants.AddRange(defaultApplica);



            IList<RepairMan> DefaultRepairMan = new List<RepairMan>();
            DefaultRepairMan.Add(new RepairMan() { ID = 1, IsActive = true, Repairman_FullName = "مصطفی عسگری", RepairMan_Status = "سرویس کار" });
            DefaultRepairMan.Add(new RepairMan() { ID = 2, IsActive = true, Repairman_FullName = "حسن عسگری", RepairMan_Status = "فنی تاسیسات" });
            DefaultRepairMan.Add(new RepairMan() { ID = 3, IsActive = true, Repairman_FullName = "مهرداد مرادخانی", RepairMan_Status = "فنی تاسیسات" });
            DefaultRepairMan.Add(new RepairMan() { ID = 4, IsActive = true, Repairman_FullName = "حسن رستم خانی", RepairMan_Status = "برق کار" });
            DefaultRepairMan.Add(new RepairMan() { ID = 5, IsActive = true, Repairman_FullName = "غلام رضایی", RepairMan_Status = "جوشکار" });
            DefaultRepairMan.Add(new RepairMan() { ID = 6, IsActive = true, Repairman_FullName = "حمید سهرابی", RepairMan_Status = "جوشکار" });
            DefaultRepairMan.Add(new RepairMan() { ID = 7, IsActive = true, Repairman_FullName = "مسلم عباسی", RepairMan_Status = "جوشکار" });
            DefaultRepairMan.Add(new RepairMan() { ID = 8, IsActive = true, Repairman_FullName = "حجت محمدی", RepairMan_Status = "برق کار" });
            DefaultRepairMan.Add(new RepairMan() { ID = 9, IsActive = true, Repairman_FullName = "مهدی باقری", RepairMan_Status = "برق کار" });
            DefaultRepairMan.Add(new RepairMan() { ID = 10, IsActive = true, Repairman_FullName = "هادی خاصی پور", RepairMan_Status = "برق کار" });
            context.RepairMens.AddRange(DefaultRepairMan);

            IList<UnitOfMeasurement> DefaultUnit = new List<UnitOfMeasurement>();
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 1, Unit = "عدد", Description = "عدد" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 2, Unit = "دستگاه", Description = "دستگاه" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 3, Unit = "بسته", Description = "بسته" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 4, Unit = "کیلوگرم", Description = "Kg" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 5, Unit = "گرم", Description = "g" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 6, Unit = "برگ", Description = "برگ" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 7, Unit = "ورق", Description = "ورق" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 8, Unit = "متر", Description = "m" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 9, Unit = "سانتیمتر", Description = "cm" });
            DefaultUnit.Add(new UnitOfMeasurement() { ID = 10, Unit = "میلیمتر", Description = "mm" });
            context.UnitOfMeasurements.AddRange(DefaultUnit);

            IList<Coding> codings = new List<Coding>();
            codings.Add(new Coding() { ID = 1, UserID_FK = 1, Code = 1101001, CompanyID_FK = 1, GroupID_FK = 1, SubGroupID_FK = 1, CodeIndex = 1, CodeTitle = "سنگ شکن فکی" });
            codings.Add(new Coding() { ID = 2, UserID_FK = 1, Code = 1101002, CompanyID_FK = 1, GroupID_FK = 1, SubGroupID_FK = 1, CodeIndex = 1, CodeTitle = "سنگ شکن مخروطی" });
            codings.Add(new Coding() { ID = 3, UserID_FK = 1, Code = 1101003, CompanyID_FK = 1, GroupID_FK = 1, SubGroupID_FK = 1, CodeIndex = 1, CodeTitle = "نوار نقاله" });
            codings.Add(new Coding() { ID = 4, UserID_FK = 1, Code = 2101001, CompanyID_FK = 2, GroupID_FK = 1, SubGroupID_FK = 1, CodeIndex = 1, CodeTitle = "سنگ شکن فکی" });
            codings.Add(new Coding() { ID = 5, UserID_FK = 1, Code = 2101002, CompanyID_FK = 2, GroupID_FK = 1, SubGroupID_FK = 1, CodeIndex = 1, CodeTitle = "سنگ شکن مخروطی" });
            codings.Add(new Coding() { ID = 6, UserID_FK = 1, Code = 2101003, CompanyID_FK = 2, GroupID_FK = 1, SubGroupID_FK = 1, CodeIndex = 1, CodeTitle = "نوار نقاله" });
            context.Codings.AddRange(codings);



            base.Seed(context);
        }
    }
}
