using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMWORK.Entities;


namespace PMWORK.Repository
{
    public interface ICodingRepository
    {
        List<UnitOfMeasurement> GetAllUnits();
        List<RepairMan> GetAllRepairMan();


        /// <summary>
        /// افزودن و ویرایش تعمیرکار
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddRepairMan(RepairMan model);
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
    }
}
