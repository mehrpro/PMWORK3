using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using PMWORK.MachineryForms;

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
        /// لیست درخواست های بسته شده بر اساس نوع تعمیر
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        List<RequestRepair> GetClosedRequestRepair(int type);
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
        /// لیست تعمیرکاران براساس شناسه گزارش تعمیر
        /// </summary>
        /// <param name="workOrderID">شناسه گزارش تعمیر</param>
        /// <returns></returns>
        List<RepairMan> GetRepairManByWorkOrderID(long workOrderID);
        /// <summary>
        /// لیست قطعات یدکی براساس شناسه تعمیر
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        List<ConsumViewModel> GetConsumViewModelsByRequestId(long requestId);
        /// <summary>
        /// لیست تعمیرات خارج از شرکت
        /// </summary>
        /// <returns></returns>
        List<Repairout> GetRepairouts();





        /// <summary>
        /// جستجو درخواست تعمیرات براساس شناسه
        /// </summary>
        /// <param name="Id">شناسه</param>
        /// <returns></returns>
        RequestRepair FindRequestRepairById(long Id);
        /// <summary>
        /// گزارش تعمیر براساس شناسه تعمیر
        /// </summary>
        /// <param name="Id">شناسه تعمیر</param>
        /// <returns></returns>
        WorkOrder FindWorkOrderByRequestId(long Id);








        /// <summary>
        /// درخواست تعمیر جدید
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddNewRequestRepair(RequestRepair model);
        /// <summary>
        /// ثبت گزارش تعمیر
        /// </summary>
        /// <param name="requestRepair">گزارش تعمیر</param>
        /// <param name="repairManListed">لیست سرویس کار</param>
        /// <param name="consumablePart">قطعات یدکی مصرفی</param>
        /// <returns></returns>
        bool AddNewWorkOrder(WorkOrder workOrder, List<RepairMan> repairMan, List<ConsumViewModel> consumViewModels);
        /// <summary>
        /// افزودن یا ویرایش تعمیرات خارج از شرکت
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddEditRepairOut(Repairout model);



        /// <summary>
        /// حذف درخواست تعمیر
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        bool RemoveRequestRepair(long requestId);
        /// <summary>
        /// حذف دستورکار تعمیر خارج از شرکت
        /// </summary>
        /// <param name="repairoutId"></param>
        /// <returns></returns>
        bool RemoveRepairOut(int repairoutId);



        /// <summary>
        /// ویرایش و بروزرسانی درخواست تعمیرات
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateRequestRepair(RequestRepair model);
        /// <summary>
        /// ویرایش گزارش کار 
        /// </summary>
        /// <param name="workOrder">گزارش تعمیر</param>
        /// <param name="repairMan">تعمیرکاران</param>
        /// <param name="consumViewModels">قطعات یدکی مصرفی</param>
        /// <returns></returns>
        bool UpdateWorkOrder(WorkOrder workOrder, List<RepairMan> repairMan, List<ConsumViewModel> consumViewModels);

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
                .Where(x => x.PublicTypeID_FK == type && x.IsActive && x.CompanyID_FK == PublicClass.CompanyID && !x.IsRepairOut)
                .ToList();
        }

        public List<RequestRepair> GetClosedRequestRepair(int type)
        {
            return _context.RequestRepairs
                .Include(a => a.Machinery.Coding)
                .Include(s => s.Applicant)
                .Where(x => x.PublicTypeID_FK == type && x.IsClose && x.CompanyID_FK == PublicClass.CompanyID && !x.IsRepairOut)
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
            return _context.Companies.Select(x => new ComboBoxBaseClass() { ID = x.ID, Title = x.CompanyTitle, Tag = x.Description }).ToList();
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

        public bool AddNewWorkOrder(WorkOrder workOrder, List<RepairMan> repairMan, List<ConsumViewModel> consumViewModels)
        {
            using (var trans = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.WorkOrders.Add(workOrder);
                    _context.SaveChanges();
                    var req = _context.RequestRepairs.Find(workOrder.RequestID_FK);
                    req.IsClose = true;
                    req.IsActive = false;
                    if (repairMan.Any())
                    {
                        var newRepairManListed = new List<RepairManListed>();
                        foreach (var item in repairMan)
                        {
                            newRepairManListed.Add(new RepairManListed()
                            {
                                IsDelete = false,
                                RepairManIdFk = item.ID,
                                WorkOrderIdFk = workOrder.ID,
                            });
                        }
                        _context.RepairManListeds.AddRange(newRepairManListed);
                    }
                    if (consumViewModels.Any())
                    {
                        var newConsum = new List<ConsumablePart>();
                        foreach (var item in consumViewModels)
                        {
                            newConsum.Add(new ConsumablePart()
                            {
                                ConsumablePartTitel = item.ConsumablePartTitel,
                                Number = item.Number,
                                RequestID_FK = item.RequestID_FK,
                                UnitID_FK = item.UnitID_FK
                            });
                        }
                        _context.ConsumableParts.AddRange(newConsum);
                    }
                    _context.SaveChanges();
                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }

            }
        }

        public List<RepairMan> GetRepairManByWorkOrderID(long workOrderID)
        {
            var list = new List<RepairMan>();
            foreach (var item in _context.RepairManListeds.Where(x => x.WorkOrderIdFk == workOrderID && !x.IsDelete))
            {
                list.Add(item: _context.RepairMens.Find(item.RepairManIdFk));
            }
            return list;
        }

        public WorkOrder FindWorkOrderByRequestId(long Id)
        {
            return _context.WorkOrders.FirstOrDefault(x => x.RequestID_FK == Id && !x.IsDelete);
        }

        public List<ConsumViewModel> GetConsumViewModelsByRequestId(long requestId)
        {
            var list = new List<ConsumViewModel>();
            var qry = _context.ConsumableParts.Include(x => x.UnitOfMeasurement).Where(x => x.RequestID_FK == requestId);
            foreach (var item in qry)
            {
                list.Add(new ConsumViewModel()
                {
                    ID = item.ID,
                    ConsumablePartTitel = item.ConsumablePartTitel,
                    Number = item.Number,
                    RequestID_FK = item.RequestID_FK,
                    UnitID_FK = item.UnitID_FK,
                    UnitOfMeasurement = item.UnitOfMeasurement.Unit,
                });
            }
            return list;
        }

        public bool UpdateWorkOrder(WorkOrder workOrder, List<RepairMan> repairMan, List<ConsumViewModel> consumViewModels)
        {
            using (var trans = _context.Database.BeginTransaction())
            {
                try
                {

                    var local = _context.Set<WorkOrder>().Local.FirstOrDefault(x => x.ID == workOrder.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(workOrder).State = EntityState.Modified;
                    _context.SaveChanges();
                    if (repairMan.Any())
                    {
                        var qry = _context.RepairManListeds.Where(x => x.WorkOrderIdFk == workOrder.ID);
                        foreach (var item in qry)
                            item.IsDelete = true;
                        foreach (var item in repairMan)
                        {
                            var find = qry.SingleOrDefault(x => x.RepairManIdFk == item.ID);
                            if (find == null)
                            {
                                _context.RepairManListeds.Add(new RepairManListed()
                                {
                                    IsDelete = false,
                                    RepairManIdFk = item.ID,
                                    WorkOrderIdFk = workOrder.ID,
                                });
                            }
                            else
                                find.IsDelete = false;
                        }
                        _context.SaveChanges();

                    }
                    else
                    {
                        var qry = _context.RepairManListeds.Where(x => x.WorkOrderIdFk == workOrder.ID);
                        foreach (var item in qry)
                        {
                            item.IsDelete = true;
                        }
                    }
                    if (consumViewModels.Any())
                    {
                        var qry = _context.ConsumableParts.Where(x => x.RequestID_FK == workOrder.RequestID_FK);
                        _context.ConsumableParts.RemoveRange(qry);
                        _context.SaveChanges();

                        var newConsum = new List<ConsumablePart>();
                        foreach (var item in consumViewModels)
                        {
                            newConsum.Add(new ConsumablePart()
                            {
                                ConsumablePartTitel = item.ConsumablePartTitel,
                                Number = item.Number,
                                RequestID_FK = item.RequestID_FK,
                                UnitID_FK = item.UnitID_FK
                            });
                        }
                        _context.ConsumableParts.AddRange(newConsum);
                    }
                    else
                    {
                        var qry = _context.ConsumableParts.Where(x => x.RequestID_FK == workOrder.RequestID_FK);
                        _context.ConsumableParts.RemoveRange(qry);
                    }
                    _context.SaveChanges();
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    var str = ex.Message;
                    trans.Rollback();
                    return false;
                }

            }
        }

        public bool AddEditRepairOut(Repairout model)
        {
            if (model.ID > 0)
            {
                try
                {
                    var local = _context.Set<Repairout>().Local.FirstOrDefault(x => x.ID == model.ID);
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
                using (var trans = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.Repairouts.Add(model);
                        var re = _context.RequestRepairs.Find(model.RequestID_FK);
                        re.IsRepairOut = true;
                        _context.SaveChanges();
                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool RemoveRepairOut(int repairoutId)
            {
            try
                {
                var find = _context.Repairouts.Find(repairoutId);
                find.IsActive = find.IsClosed = false;
                find.IsDelete = true;
                var findReq = _context.RequestRepairs.Find(find.RequestID_FK);
                findReq.IsRepairOut = false;
                findReq.IsClose = false;
                findReq.IsActive = true;
                _context.SaveChanges();
                return true;
                }
            catch 
                {
                return false;
                }
            }

        public List<Repairout> GetRepairouts()
            {
            return _context.Repairouts
                .Include(x => x.RequestRepair)
                .Include(x => x.RequestRepair.Machinery.Coding)
                .Include(x => x.RequestRepair.Applicant)
                .Where(x => !x.IsDelete && x.IsActive)
                .ToList();
            }
        }
}
