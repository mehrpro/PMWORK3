using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMWORK.Repository;

namespace PMWORK
{
    public partial class frmLogin2 : XtraForm
    {
        private readonly ICodingRepository _codingRepository;

        //private AppDbContext db;
        public frmLogin2(ICodingRepository codingRepository)
        {
            InitializeComponent();
            //////
            PublicClass.UserID = 1;
            _codingRepository = codingRepository;
            ////db = new AppDbContext();
            ////PublicClass.db = this.db;
            //// Open a Splash Screen
            //SplashScreenManager.ShowForm(this, typeof(Splash), true, true, false);

            //// The splash screen will be opened in a separate thread. To interact with it, use the SendCommand method.

            //for (int i = 1; i <= 100; i++)
            //{
            //    SplashScreenManager.Default.SendCommand(Splash.SplashScreenCommand.SetProgress, i);
            //    //To process commands, override the SplashScreen.ProcessCommand method.
            //    Thread.Sleep(25);
            //}

            //// Close the Splash Screen.
            //SplashScreenManager.CloseForm(false);
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                var result = _codingRepository.LoginUser(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                if (result)
                {
                    // XtraMessageBox.Show("کاربر گرامی", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("نام کاربری یا گذرواژه اشتباه است ", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Environment.Exit(1);
            Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new SettingForm();
            frm.ShowDialog();
            this.Show();
        }
    }
}
