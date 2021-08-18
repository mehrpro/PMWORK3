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
    }
}