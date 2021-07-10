using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK
{
    public static class PublicClass
    {
        public static int UserID { get; set; }
        public static int CompanyID { get; set; }
        public static AppDbContext db { get; set;}
        public static string ErrorValidation = @"مقادیر الزامی فرم را وارد کنید";


        public static void ReloadEntity<TEntity>(
         this DbContext context,
         TEntity entity)
         where TEntity : class
        {
            context.Entry(entity).Reload();
        }


    }
}
