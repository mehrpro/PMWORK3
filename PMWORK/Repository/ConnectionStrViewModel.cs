using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Repository
{
  public  class ConnectionStrViewModel
    {
        public string ServerName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public bool WindowsAuthentication { get; set; }

    }
}
