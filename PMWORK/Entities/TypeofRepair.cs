using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PMWORK.Entities
{
    public class TypeofRepair
    {
        public TypeofRepair()
        {
            RequestRepairs = new HashSet<RequestRepair>();
        }
        public int ID { get; set; }
        public string TypeTitle { get; set; }


        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
    }
}
