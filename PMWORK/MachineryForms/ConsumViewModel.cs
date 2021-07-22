using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.MachineryForms
{
    public class ConsumViewModel
    {
        public long ID { get; set; }
        public long RequestID_FK { get; set; }
        public string ConsumablePartTitel { get; set; }
        public int Number { get; set; }
        public int UnitID_FK { get; set; }
        public string UnitOfMeasurement { get; set; }
    }
}
