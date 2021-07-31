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
        public string Location { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }



    }
}
