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
            cbxServer.Properties.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbxServer.SelectedIndex = 3;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source = {0};Initial Catalog={1};User ID={2};Password={3};",
                cbxServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    XtraMessageBox.Show("Test Connection Succeeded", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.EditValue == "Windows Authentication")
            {
                txtUser.Enabled = txtPassword.Enabled = false;
            }
            else
            {
                txtUser.Enabled = txtPassword.Enabled = true;
            }
        }
    }
}
