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

    }
}
