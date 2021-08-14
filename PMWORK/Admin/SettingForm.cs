using System;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

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

        private void cbxServerInstance()
            {
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
                {
                cbxServer.Properties.Items.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
                }
            }

        private void SettingForm_Load(object sender, EventArgs e)
        {

            //cbxServerInstance();

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
                    PublicClass.ErrorValidationMessage(Text);

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
                    PublicClass.ErrorValidationMessage(Text);

            }
        }

        private void newDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var folder = string.Empty;
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    folder = folderBrowserDialog.SelectedPath;
                    try
                        {
                        var srv = default(Server);

                        if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
                            srv = new Server(new ServerConnection(cbxServer.Text));
                        else
                            srv = new Server(new ServerConnection(cbxServer.Text, txtUser.Text, txtPassword.Text));
                        var db = default(Database);
                        db = srv.Databases[txtDatabase.Text];

                        //int recoverymod;
                        //recoverymod = (int)db.DatabaseOptions.RecoveryModel;
                        var bk = new Backup();
                        bk.Action = BackupActionType.Database;
                        bk.BackupSetDescription = "Full Backup of " + txtDatabase.Text;
                        bk.BackupSetName = txtDatabase.Text + "_Backup";
                        bk.Database = txtDatabase.Text;
                        var backupdevice = new BackupDevice();
                        backupdevice.Parent = srv;
                        backupdevice.Name = "backupdevice";
                        backupdevice.BackupDeviceType = BackupDeviceType.Disk;
                        backupdevice.PhysicalLocation = $"{folder}\\{txtDatabase.Text + "_Full_Backup_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bak"}";
                        bk.Devices.AddDevice(backupdevice.PhysicalLocation.ToString(), DeviceType.File);
                        bk.Incremental = false;
                        var backupdate = new DateTime();
                        backupdate = DateTime.Today;
                        bk.ExpirationDate = DateTime.Today.AddDays(25);
                        bk.LogTruncation = BackupTruncateLogType.Truncate;
                        bk.SqlBackup(srv);
                        XtraMessageBox.Show("Full Backup Complate.");
                        }

                        catch (Exception exception)
                        {
                        XtraMessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }

            }
        }



        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
           {
               progressBar.Position = e.Percent;
               progressBar.Update();
           });

        }
    }
}
