using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using PMWORK.Admin;
using PMWORK.Repository;
using StructureMap;

namespace PMWORK
{
    public partial class frmLogin2 : XtraForm
    {
        private Container _container;
        private readonly ICodingRepository _codingRepository;

        public Container Container
        {
            get { return _container; }
            set { _container = value; }
        }
        //private AppDbContext db;
        public frmLogin2(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
            txtPassword.Text = txtUserName.Text = @"admin";
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (PublicClass.CloseForce)
            {
                XtraMessageBox.Show("تنظیمات اتصال تغیر کرده است لطفا برنامه را بسته و مجدداً برای ورود اقدام کنید",
                    "تنظیمات سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {

                if (dx.Validate())
                {
                    var result = _codingRepository.LoginUser(txtUserName.Text.Trim(), txtPassword.Text.Trim(), false);
                    if (result)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("نام کاربری یا گذرواژه اشتباه است ", Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);
                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Environment.Exit(1);
            Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //if (dx.Validate())
            //{
            //    var result = _codingRepository.LoginUser(txtUserName.Text.Trim(), txtPassword.Text.Trim(), true);
            //    if (result)
            //    {
            this.Hide();
            var frm = _container.GetInstance<SettingForm>();
            frm.ShowDialog();
            this.Show();
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("نام کاربری یا گذرواژه اشتباه است ", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    PublicClass.ErrorValidationMessage(Text);
            //}


        }
    }
}
