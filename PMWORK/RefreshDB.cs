using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK
{
   public static class RefreshDB
    {
        public static void ReloadEntity<TEntity>(this DbContext context,TEntity entity)where TEntity : class
        {
            context.Entry(entity).Reload();
        }


    }
}
