using System.Collections.Generic;

namespace PMWORK.Entities
{
    public class MenuGroup
    {
        public MenuGroup()
        {
            MenuItems = new HashSet<MenuItem>();
        }
        public int GroupID { get; set; }
        public string MenuGroupTitle { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
