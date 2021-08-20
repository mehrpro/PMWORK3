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
        Task<List<Company>> GetAllCompany();
        Task<List<Applicant>> GetApplicantListByCompanyId(int companyId);
        Task<List<CounterDevice>> GetCounterDevicesByCompanyId(int companyId);



        Task<bool> AddEditCounterDevice(CounterDevice model);

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

        public async Task<List<Company>> GetAllCompany()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<List<Applicant>> GetApplicantListByCompanyId(int companyId)
        {
            return await _context.Applicants.Where(x => x.CompanyID_FK == companyId).ToListAsync();
        }

        public async Task<List<CounterDevice>> GetCounterDevicesByCompanyId(int companyId)
        {
            return await _context.CounterDevices.Include(x => x.Applicant).Where(x => x.Applicant.CompanyID_FK == companyId).ToListAsync();
        }
    }

}
