using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Repository
{
    public interface ISensorRepository
    {
        /// <summary>
        /// لیست شرکت ها
        /// </summary>
        /// <returns></returns>
        Task<List<Company>> GetAllCompany();
        /// <summary>
        /// لیست واحد های سنجش 
        /// </summary>
        /// <returns></returns>
        Task<List<UnitOfMeasurement>> GetUnitOfMeasurementsList();
        /// <summary>
        /// لیست واحد ها براساس شرکت
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        Task<List<Applicant>> GetApplicantListByCompanyId(int companyId);
        /// <summary>
        /// لیست مرکزداده براساس شرکت
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        Task<List<CounterDevice>> GetCounterDevicesByCompanyId(int companyId);
        /// <summary>
        /// لیست ترمینال ها براساس شرکت
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        Task<List<SubCounterDevice>> GetSubCounterDevicesByCompanyId(int companyId);
        /// <summary>
        /// لیست ترمینال های مرکز داده براساس مرکزداده
        /// </summary>
        /// <param name="counterId"></param>
        /// <returns></returns>
        Task<List<SubCounterDevice>> GetSubCounterDevicesByCounterDevice(int counterId);
        /// <summary>
        /// لیست ترمینال های استفاده نشده براساس مرکزداده
        /// </summary>
        /// <param name="counterId"></param>
        /// <returns></returns>
        Task<List<SubCounterDevice>> GetSubCounterDevicesByCounterDeviceSubUseTerminal(int counterId);
        /// <summary>
        /// لیست ماشین آلات براساس واحدها
        /// </summary>
        /// <param name="applicantId"></param>
        /// <returns></returns>
        Task<List<Machinery>> GetMachineriesByApplicantId(int applicantId);
        /// <summary>
        /// لیست ترمینال های استفاده شده براساس مرکز داده
        /// </summary>
        /// <param name="counterId"></param>
        /// <returns></returns>
        Task<List<MachineryCounterDevice>> GetMachineryCounterDevicesByCounterDevice(int counterId);



        Task<MachineryCounterDevice> machineryCounterDevices(int subCounterDevice);


        Task<bool> AddEditCounterDevice(CounterDevice model);
        Task<bool> AddEditSubCounterDevice(SubCounterDevice model);
        Task<bool> AddEditMachineryCounterDevice(MachineryCounterDevice model);
    }

    public class SensorRepository : ISensorRepository
    {
        private readonly AppDbContext _context;

        public SensorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddEditCounterDevice(CounterDevice model)
        {
            if (model.ID > 0)
            {
                try
                {
                    var local = _context.Set<CounterDevice>().Local.FirstOrDefault(x => x.ID == model.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(model).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
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
                    _context.CounterDevices.Add(model);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddEditMachineryCounterDevice(MachineryCounterDevice model)
        {
            if (model.ID > 0)
            {
                try
                {
                    var local = _context.Set<MachineryCounterDevice>().Local.FirstOrDefault(x => x.ID == model.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(model).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
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
                    _context.MachineryCounterDevices.Add(model);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddEditSubCounterDevice(SubCounterDevice model)
        {
            if (model.ID > 0)
            {
                try
                {
                    var local = _context.Set<SubCounterDevice>().Local.FirstOrDefault(x => x.ID == model.ID);
                    if (local != null)
                    {
                        _context.Entry(local).State = EntityState.Detached;
                    }
                    _context.Entry(model).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
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
                    _context.SubCounterDevices.Add(model);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public async Task<List<Company>> GetAllCompany()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<List<Applicant>> GetApplicantListByCompanyId(int companyId)
        {
            return await _context.Applicants
                .Where(x => x.CompanyID_FK == companyId)
                .ToListAsync();
        }

        public async Task<List<CounterDevice>> GetCounterDevicesByCompanyId(int companyId)
        {
            return await _context.CounterDevices
                .Include(x => x.Applicant)
                .Where(x => x.Applicant.CompanyID_FK == companyId)
                .ToListAsync();
        }

        public async Task<List<Machinery>> GetMachineriesByApplicantId(int applicantId)
        {
            return await _context.Machineries.Include(x => x.Coding).Where(x => x.ApplicantID_FK == applicantId).ToListAsync();
        }

        public async Task<List<MachineryCounterDevice>> GetMachineryCounterDevicesByCounterDevice(int counterId)
        {
            return await _context.MachineryCounterDevices
                .Include(x => x.SubCounterDevice.UnitOfMeasurement)
                .Include(x => x.Machinery.Applicant)
                .Include(x => x.Machinery)
                .Where(x => x.SubCounterDevice.CounterDeviceID_FK == counterId && x.IsActive)
                .ToListAsync();
        }

        public async Task<List<SubCounterDevice>> GetSubCounterDevicesByCompanyId(int companyId)
        {
            return await _context.SubCounterDevices
                .Include(x => x.CounterDevice.Applicant)
                .Include(x => x.UnitOfMeasurement)
                .Where(x => x.CounterDevice.Applicant.CompanyID_FK == companyId)
                .ToListAsync();
        }

        public async Task<List<SubCounterDevice>> GetSubCounterDevicesByCounterDevice(int counterId)
        {
            return await _context.SubCounterDevices
                      .Include(x => x.CounterDevice.Applicant)
                      .Include(x => x.UnitOfMeasurement)
                      .Where(x => x.CounterDeviceID_FK == counterId)
                      .ToListAsync();
        }

        public async Task<List<SubCounterDevice>> GetSubCounterDevicesByCounterDeviceSubUseTerminal(int counterId)
        {
            var resultList = new List<SubCounterDevice>();
            var result = await GetSubCounterDevicesByCounterDevice(counterId);
            var resultUse = await GetMachineryCounterDevicesByCounterDevice(counterId);
            foreach (var item in result)
            {
                if (!resultUse.Any(x => x.SubCounterDeviceID_FK == item.ID && x.IsActive))
                {
                    resultList.Add(item);
                }
                else
                {

                }
            }

            return resultList;
        }

        public async Task<List<UnitOfMeasurement>> GetUnitOfMeasurementsList()
        {
            return await _context.UnitOfMeasurements.ToListAsync();
        }

        public async Task<MachineryCounterDevice> machineryCounterDevices(int subCounterDevice)
        {
            return await _context.MachineryCounterDevices.FirstOrDefaultAsync(x => x.SubCounterDeviceID_FK == subCounterDevice && x.IsActive);
        }
    }

}
