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
        public static string ErrorValidation = @"مقادیر الزامی فرم را وارد کنید";
        public static string ErrorSave = @"خطا در ثبت اطلاعات!";
        public static string DeleteMessage = @"آیا از حذف این مورد مطمئن هستید ؟";
        public static string SuccessSave = @"عملیات با موفقیت انجام شد";


    }
}
