using DevExpress.XtraEditors;
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
        public static bool  LimitedCompany { get; set; }
        public static string Editor { get; set; }

        public static string CancelStr { get => "انصراف"; }
        public static string CloseStr { get => "بستن"; }

        public static string FullNameTask { get; set; }

        public static void SuccessMessage(string title)
        {
            XtraMessageBox.Show(@"عملیات با موفقیت انجام شد", title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        public static void ErrorValidationMessage(string title)
        {
            XtraMessageBox.Show(@"مقادیر الزامی فرم را وارد کنید", title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
        public static void DeleteMessage(string title)
        {
            XtraMessageBox.Show(@"آیا از حذف این مورد مطمئن هستید ؟", title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
        }
        public static void ErrorSave(string title)
        {
            XtraMessageBox.Show(@"خطا در ثبت اطلاعات!", title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static string TodayPersian()
        {
            var today = DateTime.Now;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            return $"{pc.GetYear(today)}/{pc.GetMonth(today)}/{pc.GetDayOfMonth(today)}";
        }

        

    }
}
