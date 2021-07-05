using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK
{
    public class ComboBoxBaseClass
    {
        [Display(AutoGenerateField = false)]
        public int ID { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        public string Tag { get; set; }
    }
}
