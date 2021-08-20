using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using PMWORK.Entities;


namespace PMWORK.Repository
{
    public interface IDeviceIdentity
    {
        /// <summary>
        /// شناسنامه عمومی دستگاه براساس شناسه دستگاه
        /// </summary>
        /// <param name="Id">شناسه دستگاه</param>
        /// <returns></returns>
        Task<IdentityMachinery> GetIdentityMachineryByMachineryId(int Id);
        /// <summary>
        /// افزودن و بروزرسانی شناسنامه دستگاه
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> AddEditIdentityMachinery(IdentityMachinery model);

    }

    public class DeviceIdentity : IDeviceIdentity
    {
        private readonly AppDbContext _context;

        public DeviceIdentity(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IdentityMachinery> GetIdentityMachineryByMachineryId(int Id)
        {
            return await _context.IdentityMachineries.SingleOrDefaultAsync(x => x.MachinerID_FK == Id);
        }

        public async Task<bool> AddEditIdentityMachinery(IdentityMachinery model)
        {
            if (model.ID > 0)
            {
                try
                {
                    var local = _context.Set<SparePart>().Local.FirstOrDefault(x => x.ID == model.ID);
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
            try
            {
                _context.IdentityMachineries.Add(model);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}