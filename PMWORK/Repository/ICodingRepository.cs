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
        /// افزودن و ویرایش تعمیرکار
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddRepairMan(RepairMan model);
        /// <summary>
        /// افزودن کاربر سیستم 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool AddUsers(ApplicationUser user);




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
                throw;
            }




        }

        public bool LoginUser(string username, string password)
        {
            var qryUser = _context.ApplicationUsers.SingleOrDefault(x => x.UserName == username);
            if (qryUser == null) return false;
            if (qryUser.UserPassword == password)
                return true;
            else
                return false;



        }

        public List<Cleam> GetCleams(int UserId)
        {
            return _context.Cleams.Include(x => x.MenuGroup).Include(x => x.MenuItem).Where(x => x.UserID_FK == UserId && !x.IsDelete).ToList();
        }

        public List<MenuGroup> GetMenuGroups()
        {
            return _context.MenuGroups.ToList();
        }

        public List<MenuItem> GetMenuItemsByGroupId(int menuGroup)
        {
            return _context.MenuItems.Where(x => x.GroupID_FK == menuGroup).ToList();
        }


    }
}
