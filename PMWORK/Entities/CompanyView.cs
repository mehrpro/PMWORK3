using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Entities
    {
    [Table("CompanyView")]
  public  class CompanyView
        {
        [Key]
        public int ID { get; set; }
        public byte CompnayIndex { get; set; }
        public string CompanyTitle { get; set; }
        public string Description { get; set; }
        }
    }
