using System.Collections.Generic;
namespace PMWORK.Entities
{
  public  class MenuItem
    {

        public MenuItem()
        {
            Cleams = new HashSet<Cleam>();
        }


        public int ItemID { get; set; }
        public int GroupID_FK { get; set; }
        public MenuGroup MenuGroup { get; set; }
        public string ItemTitel { get; set; }


        public virtual ICollection<Cleam> Cleams { get; set; }

    }
}
