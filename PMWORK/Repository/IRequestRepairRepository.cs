using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Repository
{
   public interface IRequestRepairRepository :IDisposable
    {
        Task<List<RequestRepair>> GetActiveRequestRepair(int type);
    }

    public class RequestRepairRepository : IRequestRepairRepository
    {
        private AppDbContext context;
        public RequestRepairRepository()
        {
            context = new AppDbContext();
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<List<RequestRepair>> GetActiveRequestRepair(int type)
        {
            using (var db = new AppDbContext())
            {
                var qry = await context.RequestRepairs
        .Include(a => a.Machinery.Coding)
        .Include(s => s.Applicant)
        .Where(x => x.PublicTypeID_FK == type)
        .ToListAsync();


            }

            return qry;
        }
    }
}
