using System.ComponentModel.DataAnnotations;

namespace PMWORK
{
    public class ComboBoxCoding
    {
        [Display(AutoGenerateField = false)]
        public long ID { get; set; }
        [Display(Name = "کد")]
        public int Cod { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        public string Des { get; set; }
    }
}
