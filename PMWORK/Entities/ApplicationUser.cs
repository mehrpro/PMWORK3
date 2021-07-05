
using System;
using System.Collections.Generic;


namespace PMWORK.Entities
{
    /// <summary>
    /// کاربران
    /// </summary>
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            RequestRepairs = new HashSet<RequestRepair>();
            Codings = new HashSet<Coding>();
        }
        public int UserId { get; set; }      
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
        public virtual ICollection<Coding> Codings { get; set; }
    }
}