using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Internal;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace PMWORK.Admin
{
    public partial class SettingForm : XtraForm
    {

        private delegate void DelegateMaster();

        public SettingForm()
        {
            InitializeComponent();
            cbxAuthentication.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            progressBar.Visible = false;



        }

        private void cbxServerInstance()
        {
            //Invoke(new Action(() => lblStatus.Text = "Searching"));
            Invoke(new Action(() => cbxServer.Properties.Items.Clear()));
            var list = new List<string>();
            list.Add(".");
            list.Add("(local)");
            list.Add(@".\SQLEXPRESS");
            list.Add(@"(LocalDB)\MSSQLLocalDB");
            list.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
                list.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            Invoke(new Action(() => cbxServer.Properties.Items.AddRange(list)));
            Invoke(new Action(() => progressBar.Visible = false));
            //Invoke(new Action(() => lblStatus.Text = "Finish"));
        }


        private void SettingForm_Load(object sender, EventArgs e)
        {



        }

        private bool TestConnection()
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
                        return true;
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);
                    return false;
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
                        return true;
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);
                    return false;
                }

            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            var result = TestConnection();
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
            var result = TestConnection();
            if (result)
            {
                var frm = new NewDatabaseForm();
                frm.ServerName = cbxAuthentication.Text.Trim();
                frm.AuthenticationMode = cbxAuthentication.Text;
                if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
                {
                    frm.UserName = frm.Password = string.Empty;
                }
                else
                {
                    frm.UserName = txtUser.Text;
                    frm.Password = txtPassword.Text;
                }
                frm.ShowDialog();
            }
       

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    var folder2 = folderBrowserDialog.SelectedPath;
                    var delegateBackup = new Func<string,bool>(BackupToFile);
                var callBack = new AsyncCallback(asyncRes =>
                {
                    var resultFinal = delegateBackup.EndInvoke(asyncRes);
                    if (resultFinal)
                    {
                        XtraMessageBox.Show("Full Backup Complate.");

                    }
                    else
                    {
                        XtraMessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                });
                    delegateBackup.BeginInvoke(folder2, callBack, null);
                }

            

        }



        private bool BackupToFile(string folder)
        {
            Invoke(new Action(() => progressBar.Visible = true));
 
                    try
                    {
                        var srv = default(Server);

                        if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
                            srv = new Server(new ServerConnection(cbxServer.Text));
                        else
                            srv = new Server(new ServerConnection(cbxServer.Text, txtUser.Text, txtPassword.Text));
                        var db = default(Database);
                        db = srv.Databases[txtDatabase.Text];
                        var bk = new Backup();
                        bk.Action = BackupActionType.Database;
                        bk.BackupSetDescription = "Full Backup of " + txtDatabase.Text;
                        bk.BackupSetName = txtDatabase.Text + "_Backup";
                        bk.Database = txtDatabase.Text;
                        var backupdevice = new BackupDevice();
                        backupdevice.Parent = srv;
                        backupdevice.Name = "backupdevice";
                        backupdevice.BackupDeviceType = BackupDeviceType.Disk;
                        backupdevice.PhysicalLocation = $"{folder}\\{txtDatabase.Text + "_FullBackup_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bak"}";
                        bk.Devices.AddDevice(backupdevice.PhysicalLocation.ToString(), DeviceType.File);
                        bk.Incremental = false;
                        var backupdate = new DateTime();
                        backupdate = DateTime.Today;
                        bk.ExpirationDate = DateTime.Today.AddDays(25);
                        bk.LogTruncation = BackupTruncateLogType.Truncate;
                        bk.SqlBackup(srv);
                Invoke(new Action(() => progressBar.Visible = false));
                return true;
                     
                    }
                    catch (Exception exception)
                    {
                Invoke(new Action(() => progressBar.Visible = false));
                return false;
            }
       
            
        }

        private void cbxServer_BeforePopup(object sender, EventArgs e)
        {

        }

        private void cbxServer_Popup(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            var cbxServerDelegate = new DelegateMaster(cbxServerInstance);
            //var cbxServerDelegate = new Func<bool>(cbxServerInstance);
            //var callBack = new AsyncCallback(asyncRes =>
            //{
            //    bool fibalResult = cbxServerDelegate.EndInvoke(asyncRes);
            //    //progressBar.Visible = !fibalResult;
            //});
            var result = cbxServerDelegate.BeginInvoke(null, null);

        }
    }
}
