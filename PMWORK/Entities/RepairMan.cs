using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Entities
{
    public class RepairMan
    {

        public RepairMan()
        {
            RepairManListeds = new HashSet<RepairManListed>();
        }

        public int ID { get; set; }
        public string Repairman_FullName { get; set; }
        public string RepairMan_Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<RepairManListed> RepairManListeds { get; set; }

    }
}
