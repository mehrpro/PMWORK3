using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace PMWORK.Entities
{
    /// <summary>
    /// واحدهای اندازه گیری
    /// </summary>
    public class UnitOfMeasurement
    {

        public UnitOfMeasurement()
        {
            ConsumableParts = new HashSet<ConsumablePart>();
            ServicePeriodes = new HashSet<ServicePeriode>();
            SpareParts = new HashSet<SparePart>();
        }


        public int ID { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }


        public virtual ICollection<ConsumablePart> ConsumableParts { get; set; }
        public virtual ICollection<ServicePeriode> ServicePeriodes { get; set; }
        public virtual ICollection<SparePart> SpareParts { get; set; }
    }
}
