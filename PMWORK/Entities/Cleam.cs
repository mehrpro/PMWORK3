﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Entities
{
   public class Cleam
    {
        public int ID { get; set; }

        public int UserID_FK { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int GroupID_FK { get; set; }
        public MenuGroup MenuGroup { get; set; }

        public int MenuItemID_FK { get; set; }
        public MenuItem MenuItem { get; set; }

        public bool IsDelete { get; set; }





    }
}
