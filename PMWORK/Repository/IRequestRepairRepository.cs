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
        List<RequestRepair> GetActiveRequestRepair(int type);
        Task<bool> UpdateRequestRepair(RequestRepair model);
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

        public  List<RequestRepair> GetActiveRequestRepair(int type)
        {
            var qry = new List<RequestRepair>();
             using (var db = new AppDbContext())
             {
               qry =  context.RequestRepairs
               .Include(a => a.Machinery.Coding)
               .Include(s => s.Applicant)
               .Where(x => x.PublicTypeID_FK == type)
               .ToList();
             }
            return qry;
        }

        public async Task<bool> UpdateRequestRepair(RequestRepair model)
        {
            try
            {
                //context.Entry(model).State = EntityState.Detached;
                context.Entry(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return true;

            }
            catch 
            {
                return false;
                
            }
        }
    }
}
