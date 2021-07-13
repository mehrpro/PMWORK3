using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Repository
{
    public interface IRequestRepairRepository
    {
        /// <summary>
        /// لیست درخواست تعمیرات فعال بر اساس نوع تعمیر
        /// </summary>
        /// <param name="type">شناسه نوع تعمیر</param>
        /// <returns></returns>
        List<RequestRepair> GetActiveRequestRepair(int type);

        /// <summary>
        /// عنوان نوع تعمیرات برای نمایش در کادر فرم درخواست تعمیر
        /// </summary>
        /// <param name="typeofReq">شناسه</param>
        /// <returns></returns>
        string GetStringTypeOfRequest(int typeofReq);
        /// <summary>
        /// لیست واحد ها براساس شناسه هر شرکت
        /// </summary>
        /// <param name="companyId">شناسه شرکت</param>
        /// <returns></returns>
        List<Applicant> GetAllApplicantsByCompanyId(int companyId);
        /// <summary>
        /// لیست شرکت ها و گروه ها
        /// </summary>
        /// <returns></returns>
        List<ComboBoxBaseClass> GetAllCompanies();
        /// <summary>
        /// لیست ماشین آلات 
        /// </summary>
        /// <param name="applicantId"></param>
        /// <returns></returns>
        List<Machinery> GetMachineriesByApplicantId(int applicantId);


        /// <summary>
        /// جستجو درخواست تعمیرات براساس شناسه
        /// </summary>
        /// <param name="Id">شناسه</param>
        /// <returns></returns>
        RequestRepair FindRequestRepairById(long Id);


        /// <summary>
        /// درخواست تعمیر جدید
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddNewRequestRepair(RequestRepair model);




        /// <summary>
        /// حذف درخواست تعمیر
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        bool RemoveRequestRepair(long requestId);



        /// <summary>
        /// ویرایش و بروزرسانی درخواست تعمیرات
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateRequestRepair(RequestRepair model);

    }

    public class RequestRepairRepository : IRequestRepairRepository
    {
        private AppDbContext _context;
        public RequestRepairRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<RequestRepair> GetActiveRequestRepair(int type)
        {
            return _context.RequestRepairs
                .Include(a => a.Machinery.Coding)
                .Include(s => s.Applicant)
                .Where(x => x.PublicTypeID_FK == type && x.IsActive && !x.IsDelete)
                .ToList();
        }


        public string GetStringTypeOfRequest(int typeofReq)
        {
            return _context.PublicTypes.Find(typeofReq)?.Title;
        }
        public List<Applicant> GetAllApplicantsByCompanyId(int companyId)
        {
            return _context.Applicants.Where(x => x.CompanyID_FK == companyId).ToList();
        }
        public List<ComboBoxBaseClass> GetAllCompanies()
        {
            return _context.Companies.Select(x => new ComboBoxBaseClass() { ID = x.ID, Title = x.CompanyTiltle, Tag = x.Description }).ToList();
        }
        public List<Machinery> GetMachineriesByApplicantId(int applicantId)
        {
            return _context.Machineries
                .Include(c => c.Coding)
                .Where(x => x.ApplicantID_FK == applicantId)
                .ToList();
        }

        public RequestRepair FindRequestRepairById(long Id)
        {
            return _context.RequestRepairs.Find(Id);
        }

        public bool AddNewRequestRepair(RequestRepair model)
        {
            try
            {
                _context.RequestRepairs.Add(model);
                var result = _context.SaveChanges();
                return Convert.ToBoolean(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        bool IRequestRepairRepository.UpdateRequestRepair(RequestRepair model)
        {
            try
            {
                _context.Entry(model).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool RemoveRequestRepair(long requestId)
        {
            var find = _context.RequestRepairs.Find(requestId);
            try
            {
                find.IsActive = false;
                find.IsDelete = true;
                find.IsClose = true;
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
