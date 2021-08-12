using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK.Entities
    {
 public   class CompanyViewMap : EntityTypeConfiguration<Company>
        {

        public CompanyViewMap()
            {
            HasKey(x => x.ID);
            ToTable("ViewCompany");
            }
        }
    }
