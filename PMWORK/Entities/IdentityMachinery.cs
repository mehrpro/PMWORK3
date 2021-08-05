using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Entities
{
    public class IdentityMachinery
    {
        public int ID { get; set; }
        public int MachinerID_FK { get; set; }
        public Machinery Machinery { get; set; }
        public string TypeDevice { get; set; }
        public DateTime dateTimeImport { get; set; }
        public DateTime dateTimeStart { get; set; }
        public int ApplicantID_FK { get; set; }
        public Applicant Applicant { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Wight { get; set; }
        public string Wather { get; set; }
        public string oil { get; set; }




    }
}
