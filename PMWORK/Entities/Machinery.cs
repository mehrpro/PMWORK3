using System.Collections.Generic;

namespace PMWORK.Entities
{

    /// <summary>
    /// لیست ماشین آلات
    /// </summary>
    public class Machinery
    {
        public Machinery()
        {
            RequestRepairs = new HashSet<RequestRepair>();
        }

        public int ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public int CompanyID { get; set; }
        public long CodeID_FK { get; set; }
        public Coding Coding { get; set; }
        public string MachineryTitle { get; set; }
        public string Description { get; set; }



        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }

    }
}
