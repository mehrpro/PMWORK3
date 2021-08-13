using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace PMWORK.Admin
{
    public partial class SettingForm : XtraForm
    {
        public SettingForm()
        {
            InitializeComponent();
            cbxServer.Properties.Items.Add(".");
            cbxServer.Properties.Items.Add("(local)");
            cbxServer.Properties.Items.Add(@".\SQLEXPRESS");
            cbxServer.Properties.Items.Add(@"(LocalDB)\MSSQLLocalDB");
            cbxServer.Properties.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbxServer.SelectedIndex = 3;
            cbxAuthentication.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString;
            if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
            {
                if (dx.Validate(cbxServer) && dx.Validate(txtDatabase) && dx.Validate(cbxAuthentication))
                {
                    connectionString =
                        string.Format("Data Source= {0} ; Initial Catalog = {1} ; Integrated Security = SSPI;",
                            cbxServer.Text, txtDatabase.Text);
                    try
                    {
                        SqlHelper helper = new SqlHelper(connectionString);
                        if (helper.IsConnection)
                        {
                            XtraMessageBox.Show(@"اتصال موفقیت آمیز بود", "Message", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);
                }

            }
            else
            {
                if (dx.Validate())
                {
                    connectionString =
                        string.Format("Data Source = {0};Initial Catalog={1};User ID={2};Password={3};",
                            cbxServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
                    try
                    {
                        SqlHelper helper = new SqlHelper(connectionString);
                        if (helper.IsConnection)
                        {
                            XtraMessageBox.Show(@"اتصال موفقیت آمیز بود", "Message", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);
                }

            }

        }

        private void cbxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
            {
                txtUser.Enabled = txtPassword.Enabled = false;
            }
            else
            {
                txtUser.Enabled = txtPassword.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString;
            if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
            {
                if (dx.Validate(cbxServer) && dx.Validate(txtDatabase) && dx.Validate(cbxAuthentication))
                {
                    connectionString =
                        string.Format("Data Source= {0} ; Initial Catalog = {1} ; Integrated Security = SSPI;",
                            cbxServer.Text, txtDatabase.Text);
                    try
                    {
                        SqlHelper helper = new SqlHelper(connectionString);
                        if (helper.IsConnection)
                        {
                            AppSetting appSetting = new AppSetting();
                            appSetting.SaveConnectionString("Conn", connectionString);
                            PublicClass.SuccessMessage(Text);

                        }
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);
                }

            }
            else
            {
                if (dx.Validate())
                {
                    connectionString =
                        string.Format("Data Source = {0};Initial Catalog={1};User ID={2};Password={3};",
                            cbxServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
                    try
                    {
                        SqlHelper helper = new SqlHelper(connectionString);
                        if (helper.IsConnection)
                        {
                            AppSetting appSetting = new AppSetting();
                            appSetting.SaveConnectionString("Conn", connectionString);
                            PublicClass.SuccessMessage(Text);
                        }
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);
                }

            }
        }
    }
}
