using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using PMWORK.Entities;


namespace PMWORK.Repository
{
    public interface ICodingRepository
    {
        /// <summary>
        /// لیست واحدهای سنجش
        /// </summary>
        /// <returns></returns>
        List<UnitOfMeasurement> GetAllUnits();
        /// <summary>
        /// لیست تعمیرکاران
        /// </summary>
        /// <returns></returns>
        List<RepairMan> GetAllRepairMan();
        /// <summary>
        /// لیست کاربران نرم افزار
        /// </summary>
        /// <returns></returns>
        List<ApplicationUser> GetAllUsers();
        /// <summary>
        /// مجوز دسترسی بر اساس شناسه کاربر
        /// </summary>
        /// <param name="UserId">شناسه کاربر</param>
        /// <returns></returns>
        List<Cleam> GetCleams(int UserId);
        /// <summary>
        /// لیست منوهای نرم افزار
        /// </summary>
        /// <returns></returns>
        List<MenuGroup> GetMenuGroups();
        /// <summary>
        /// لیست زیر منوها براساس شناسه منوها
        /// </summary>
        /// <param name="menuGroup"></param>
        /// <returns></returns>
        List<MenuItem> GetMenuItemsByGroupId(int menuGroup);
        /// <summary>
        /// لیست شرکت ها
        /// </summary>
        /// <returns></returns>
        List<Company> GetAllCompanies();
        /// <summary>
        /// لیست گروه های اصلی
        /// </summary>
        /// <returns></returns>
        List<Group> GetAllGroups();
        /// <summary>
        /// لیست گروه های اصلی براساس شناسه شرکت
        /// </summary>
        /// <param name="companyId">شناسه شرکت</param>
        /// <returns></returns>
        List<Group> GetGroupsByCompanyId(int companyId);
        /// <summary>
        /// لیست گروه های فرعی
        /// </summary>
        /// <returns></returns>
        List<SubGroup> GetAllSubGroup();
        /// <summary>
        /// لیست گروه های فرعی براساس شناسه گروه اصلی
        /// </summary>
        /// <param name="groupId">شناسه گروه اصلی</param>
        /// <returns></returns>
        List<SubGroup> GetSubGroupsByGroupId(int groupId);

        /// <summary>
        /// لیست واحد ها براساس شناسه شرکت
        /// </summary>
        /// <param name="companyId">شناسه شرکت</param>
        /// <returns></returns>
        List<Applicant> GetApplicantsByCompanyId(int companyId);
        /// <summary>
        /// لیست ماشین آلات براساس شناسه شرکت
        /// </summary>
        /// <param name="companyId">شناسه شرکت</param>
        /// <returns></returns>
        List<Machinery> GetMachineriesListByApplicantId(int companyId);
        /// <summary>
        /// لیست سرویس دوره ای براساس شناسه ماشین
        /// </summary>
        /// <param name="MachineryID"></param>
        /// <returns></returns>
        List<ServicePeriode> GetServicePeriodesByMachineriId(int MachineryID);
        /// <summary>
        /// لیست قطعات یدکی براسا شناسه ماشین
        /// </summary>
        /// <param name="MachineryID"></param>
        /// <returns></returns>
        List<SparePart> GetSparePartByMachineriId(int MachineryID);
        /// <summary>
        /// لیست توان مصرفی ماشین بر اساس شناسه دستگاه
        /// </summary>
        /// <param name="machineryId"></param>
        /// <returns></returns>
        List<PowerElectricalMachinery> GetPowerListByMachineryId(int machineryId);
        /// <summary>
        /// لیست کدینگ 
        /// </summary>
        /// <param name="cid">شناسه شرکت</param>
        /// <param name="gid">شناسه گروه</param>
        /// <param name="sid">شناسه زیرگروه</param>
        /// <returns></returns>
        List<Coding> GetCodingsBy(int cid = 0, int gid = 0, int sid = 0);







        bool AddEditApplicant(Applicant model);
        /// <summary>
        /// افزودن و ویرایش تعمیرکار
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddRepairMan(RepairMan model);
        /// <summary>
        /// افزودن کاربر سیستم 
        /// </summary>
        /// <param name="user">مدل</param>
        /// <returns></returns>
        bool AddUsers(ApplicationUser user);
        /// <summary>
        /// ویرایش و افزودن سرویس دوره ای
        /// </summary>
        /// <param name="servicePeriode">مدل</param>
        /// <returns></returns>
        bool AddServicePeriode(ServicePeriode servicePeriode);
        /// <summary>
        /// ویرایش و افزودن قطعه یدکی
        /// </summary>
        /// <param name="sparePart">مدل</param>
        /// <returns></returns>
        bool AddSparePart(SparePart sparePart);
        /// <summary>
        /// افزودن و ویرایش توان مصرفی دستگاه
        /// </summary>
        /// <param name="powerElectrical"></param>
        /// <returns></returns>
        bool AddPowerElectrical(PowerElectricalMachinery powerElectrical);
        /// <summary>
        /// افزودن ویا ویرایش کدینگ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddEditCoding(Coding model);


        /// <summary>
        /// حذف رکورد توان مصرفی
        /// </summary>
        /// <param name="PowerElectricalID"></param>
        /// <returns></returns>
        bool DeletePowerElectrical(int PowerElectricalID);





        /// <summary>
        /// ویرایش و افزودن سطح دسترسی
        /// </summary>
        /// <param name="cleams">لیست مجوزها</param>
        /// <returns></returns>
        bool CleamUser(List<Cleam> cleams);




        bool LoginUser(string username, string password);



        /// <summary>
        /// ویرایش کاربر سیستم
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool UpdateUsers(ApplicationUser user);
    }


    public class CodingRepository : ICodingRepository
    {
        private readonly AppDbContext _context;

        public CodingRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<UnitOfMeasurement> GetAllUnits()
        {
            return _context.UnitOfMeasurements.AsNoTracking().ToList();
        }

        public List<RepairMan> GetAllRepairMan()
        {
            return _context.RepairMens.Where(x => x.IsActive).ToList();
        }

        public List<PowerElectricalMachinery> GetPowerListByMachineryId(int machineryId)
        {
            return _context.PowerElectricalMachineries.Where(x => x.MachineryID_FK == machineryId && !x.IsDelete).ToList();
        }

        public List<Coding> GetCodingsBy(int cid = 0, int gid = 0, int sid = 0)
        {
            if (cid > 0 && gid > 0 && sid > 0)
            {
                return _context.Codings.Where(a =>
                    a.CompanyID_FK == cid &&
                    a.GroupID_FK == gid &&
                    a.SubGroupID_FK == sid).ToList();

            }
            if (cid > 0 && gid > 0 && sid < 1)
            {
                return _context.Codings.Where(a =>
                   a.CompanyID_FK == cid &&
                   a.GroupID_FK == gid).ToList();
            }
            if (cid > 0 && gid < 1 && sid < 1)
            {
                return _context.Codings.Where(a =>
                   a.CompanyID_FK == cid).ToList();
            }
            return _context.Codings.ToList();

        }

        public bool AddEditApplicant(Applicant model)
        {
            if (model.ID > 0)
            {
                try
                {
                    var local = _context.Set<ServicePeriode>().Local.FirstOrDefault(x => x.ID == model.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                try
                {
                    _context.Applicants.Add(model);
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool AddRepairMan(RepairMan model)
        {
            if (model.ID > 0)
            {
                try
                {
                    var find = _context.RepairMens.Find(model.ID);
                    find.RepairMan_Status = model.RepairMan_Status;
                    find.IsActive = model.IsActive;
                    find.Repairman_FullName = model.Repairman_FullName;
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                try
                {
                    _context.RepairMens.Add(model);
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool AddUsers(ApplicationUser user)
        {
            try
            {
                _context.ApplicationUsers.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }

        public List<ApplicationUser> GetAllUsers()
        {
            return _context.ApplicationUsers.Include(x => x.Company).ToList();
        }

        public bool UpdateUsers(ApplicationUser user)
        {

            try
            {
                var local = _context.Set<ApplicationUser>().Local.FirstOrDefault(x => x.UserId == user.UserId);
                if (local != null) _context.Entry(local).State = EntityState.Detached;
                _context.Entry(local).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool LoginUser(string username, string password)
        {
            var qryUser = _context.ApplicationUsers.SingleOrDefault(x => x.UserName == username);
            if (qryUser == null || !qryUser.Enabled) return false;
            if (qryUser.UserPassword == password)
            {
                PublicClass.FullNameTask = qryUser.FullName;
                PublicClass.UserID = qryUser.UserId;
                PublicClass.Editor = qryUser.Editor;
                PublicClass.LimitedCompany = qryUser.LimetedCompany;
                PublicClass.CompanyID = qryUser.CompanyID_FK;
                return true;
            }
            else
                return false;
        }

        public List<Cleam> GetCleams(int UserId)
        {
            return _context.Cleams.Include(x => x.MenuGroup).Include(x => x.MenuItem).Where(x => x.UserID_FK == UserId).ToList();
        }

        public List<MenuGroup> GetMenuGroups()
        {
            return _context.MenuGroups.ToList();
        }

        public List<MenuItem> GetMenuItemsByGroupId(int menuGroup)
        {
            return _context.MenuItems.Where(x => x.GroupID_FK == menuGroup).ToList();
        }

        public bool AddPowerElectrical(PowerElectricalMachinery powerElectrical)
        {
            if (powerElectrical.ID > 0)
            {
                try
                {
                    var local = _context.Set<ServicePeriode>().Local.FirstOrDefault(x => x.ID == powerElectrical.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(powerElectrical).State = EntityState.Modified;
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                try
                {
                    _context.PowerElectricalMachineries.Add(powerElectrical);
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }

        public bool AddEditCoding(Coding model)
        {
            if (model.ID > 0)
            {
                try
                {
                    var local = _context.Set<ServicePeriode>().Local.FirstOrDefault(x => x.ID == model.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                try
                {
                    _context.Codings.Add(model);
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool CleamUser(List<Cleam> cleams)
        {
            try
            {
                var userid = cleams[0].UserID_FK;
                foreach (var item in cleams)
                {
                    var find = _context.Cleams.SingleOrDefault(x => x.MenuItemID_FK == item.MenuItemID_FK && x.UserID_FK == userid);
                    if (find == null)
                    {
                        _context.Cleams.Add(new Cleam()
                        {
                            UserID_FK = userid,
                            GroupID_FK = item.GroupID_FK,
                            MenuItemID_FK = item.MenuItemID_FK,
                            IsDelete = item.IsDelete,
                        });
                    }
                    else
                    {
                        find.IsDelete = item.IsDelete;
                    }
                }
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<Company> GetAllCompanies()
        {
            return _context.Companies.ToList();
        }

        public List<Group> GetAllGroups()
        {
            return _context.Groups.ToList();
        }

        public List<Group> GetGroupsByCompanyId(int companyId)
        {
            return _context.Groups.Where(x => x.CompanyID_FK == companyId).ToList();
        }

        public List<SubGroup> GetAllSubGroup()
        {
            return _context.SubGroups.ToList();
        }

        public List<SubGroup> GetSubGroupsByGroupId(int groupId)
        {
            return _context.SubGroups.Where(x => x.GroupID_FK == groupId).ToList();
        }



        public List<Applicant> GetApplicantsByCompanyId(int companyId)
        {
            return _context.Applicants.Where(x => x.CompanyID_FK == companyId).ToList();
        }

        public List<Machinery> GetMachineriesListByApplicantId(int applicantId)
        {
            return _context.Machineries.Include(x => x.Coding).Where(x => x.ApplicantID_FK == applicantId).ToList();
        }

        public bool AddServicePeriode(ServicePeriode servicePeriode)
        {
            if (servicePeriode.ID > 0)
            {
                try
                {
                    var local = _context.Set<ServicePeriode>().Local.FirstOrDefault(x => x.ID == servicePeriode.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(servicePeriode).State = EntityState.Modified;
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                try
                {
                    _context.ServicePeriodes.Add(servicePeriode);
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<ServicePeriode> GetServicePeriodesByMachineriId(int MachineryID)
        {
            return _context.ServicePeriodes.Include(x => x.UnitOfMeasurement).Where(x => x.MachineryID_FK == MachineryID).ToList();
        }

        public bool AddSparePart(SparePart sparePart)
        {
            if (sparePart.ID > 0)
            {
                try
                {
                    var local = _context.Set<ServicePeriode>().Local.FirstOrDefault(x => x.ID == sparePart.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(sparePart).State = EntityState.Modified;
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                try
                {
                    _context.SpareParts.Add(sparePart);
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<SparePart> GetSparePartByMachineriId(int MachineryID)
        {
            return _context.SpareParts.Include(x => x.UnitOfMeasurement).Where(x => x.MachineryID_FK == MachineryID).ToList();
        }

        public bool DeletePowerElectrical(int PowerElectricalID)
        {
            try
            {
                var local = _context.Set<PowerElectricalMachinery>().Local.FirstOrDefault(x => x.ID == PowerElectricalID);
                if (local != null)
                {
                    _context.Entry(local).State = EntityState.Detached;
                }
                local.IsDelete = true;
                _context.Entry(local).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

