using System;
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
            defaultCompany.Add(new Company() { ID = 1, CompanyTiltle = "کیمیای زنجان گستران", CompnayIndex = 1, Description = "کیمیای زنجان گستران" });
            defaultCompany.Add(new Company() { ID = 2, CompanyTiltle = "سرب و روی ایرانیان", CompnayIndex = 2, Description = "کیمیای زنجان گستران" });
            defaultCompany.Add(new Company() { ID = 3, CompanyTiltle = "ذوبگران رنگین فلز", CompnayIndex = 3, Description = "کیمیای زنجان گستران" });
            context.Companies.AddRange(defaultCompany);

            IList<Group> defaultGroup = new List<Group>();
            defaultGroup.Add(new Group() { ID = 1, GroupTitle = "تولیدی", CompanyID_FK = 1, GroupIndex = 1, Description = "تولیدی" });
            defaultGroup.Add(new Group() { ID = 2, GroupTitle = "کیفی و آزمایشگاهی", CompanyID_FK = 1, GroupIndex = 2, Description = "کیفی و آزمایشگاهی" });
            defaultGroup.Add(new Group() { ID = 3, GroupTitle = "کمک تولیدی", CompanyID_FK = 1, GroupIndex = 3, Description = "کمک تولیدی" });
            defaultGroup.Add(new Group() { ID = 4, GroupTitle = "نگهداری تعمیرات", CompanyID_FK = 1, GroupIndex = 4, Description = "نگهداری تعمیرات" });

            defaultGroup.Add(new Group() { ID = 5, GroupTitle = "تولیدی", CompanyID_FK = 2, GroupIndex = 5, Description = "تولیدی" });
            defaultGroup.Add(new Group() { ID = 6, GroupTitle = "کیفی و آزمایشگاهی", CompanyID_FK = 2, GroupIndex = 6, Description = "کیفی و آزمایشگاهی" });
            defaultGroup.Add(new Group() { ID = 7, GroupTitle = "کمک تولیدی", CompanyID_FK = 2, GroupIndex = 7, Description = "کمک تولیدی" });
            defaultGroup.Add(new Group() { ID = 8, GroupTitle = "نگهداری تعمیرات", CompanyID_FK = 2, GroupIndex = 8, Description = "نگهداری تعمیرات" });

            defaultGroup.Add(new Group() { ID = 9, GroupTitle = "تولیدی", CompanyID_FK = 3, GroupIndex = 9, Description = "تولیدی" });
            defaultGroup.Add(new Group() { ID = 10, GroupTitle = "کیفی و آزمایشگاهی", CompanyID_FK = 3, GroupIndex = 10, Description = "کیفی و آزمایشگاهی" });
            defaultGroup.Add(new Group() { ID = 11, GroupTitle = "کمک تولیدی", CompanyID_FK = 3, GroupIndex = 11, Description = "کمک تولیدی" });
            defaultGroup.Add(new Group() { ID = 12, GroupTitle = "نگهداری تعمیرات", CompanyID_FK = 3, GroupIndex = 12, Description = "نگهداری تعمیرات" });
            context.Groups.AddRange(defaultGroup);

            IList<SubGroup> defaultSubGroup = new List<SubGroup>();
            defaultSubGroup.Add(new SubGroup() { ID = 1, SubGroupTitle = "خردایش", CompanyID_FK = 1, GroupID_FK = 1, SubGroupIndex = 1, Description = "خردایش" });
            defaultSubGroup.Add(new SubGroup() { ID = 2, SubGroupTitle = "تلغیظ", CompanyID_FK = 1, GroupID_FK = 1, SubGroupIndex = 2, Description = "تلغیظ" });
            defaultSubGroup.Add(new SubGroup() { ID = 3, SubGroupTitle = "پمپ", CompanyID_FK = 1, GroupID_FK = 1, SubGroupIndex = 3, Description = "پمپ" });
            defaultSubGroup.Add(new SubGroup() { ID = 4, SubGroupTitle = "هواساز", CompanyID_FK = 1, GroupID_FK = 1, SubGroupIndex = 4, Description = "هواساز" });

            defaultSubGroup.Add(new SubGroup() { ID = 5, SubGroupTitle = "خردایش", CompanyID_FK = 2, GroupID_FK = 5, SubGroupIndex = 5, Description = "خردایش" });
            defaultSubGroup.Add(new SubGroup() { ID = 6, SubGroupTitle = "تلغیظ", CompanyID_FK = 2, GroupID_FK = 5, SubGroupIndex = 6, Description = "تلغیظ" });
            defaultSubGroup.Add(new SubGroup() { ID = 7, SubGroupTitle = "پمپ", CompanyID_FK = 2, GroupID_FK = 5, SubGroupIndex = 7, Description = "پمپ" });
            defaultSubGroup.Add(new SubGroup() { ID = 8, SubGroupTitle = "هواساز", CompanyID_FK = 2, GroupID_FK = 5, SubGroupIndex = 8, Description = "هواساز" });
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
            defaultApplica.Add(new Applicant() { ID = 3, ApplicantTitle = "فیلتراسیون", CompanyID_FK = 2 });
            defaultApplica.Add(new Applicant() { ID = 4, ApplicantTitle = "فلوتاسیون", CompanyID_FK = 2 });
            context.Applicants.AddRange(defaultApplica);





            base.Seed(context);
        }
    }
}
