using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using PMWORK.Repository;

namespace PMWORK.Admin
{
    public partial class SettingForm : XtraForm
    {

        private delegate void DelegateMaster();

        private string connectionString;
        private List<string> _databaseList;

        private ISetDatabase _setDatabase;

        public SettingForm(ISetDatabase setDatabase)
        {
            InitializeComponent();
            cbxAuthentication.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            progressBar.Visible = false;
            _setDatabase = setDatabase;
        }

        private void cbxServerInstance()
        {
            Invoke(new Action(() => cbxServer.Properties.Items.Clear()));
            var list = _setDatabase.GetServerInstance();
            Invoke(new Action(() => cbxServer.Properties.Items.AddRange(list)));
            Invoke(new Action(() => progressBar.Visible = false));
        }


        private void SettingForm_Load(object sender, EventArgs e)
        {



        }

        private bool TestConnection()
        {
            var connectionstr = new ConnectionStrViewModel();
            var startJob = new Func<ConnectionStrViewModel, List<string>>(_setDatabase.GetDatabaseListByServerName);

            if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
            {
                if (dx.Validate(cbxServer) && dx.Validate(cbxAuthentication))
                {
                    connectionString = $"Data Source= {cbxServer.Text} ; Integrated Security = SSPI;";
                    connectionstr.WindowsAuthentication = true;
                    connectionstr.ServerName = cbxServer.Text;
                    connectionstr.UserID = connectionstr.Password = "";
                    try
                    {
                        progressBar.Visible = true;
                        btnConnecting.Enabled = false;
                        SqlHelper helper = new SqlHelper(connectionString);
                        if (helper.IsConnection)
                        {

                            var callBack = new AsyncCallback(asyncRes =>
                            {
                                var list = startJob.EndInvoke(asyncRes);
                                Invoke(new Action(() => _databaseList = new List<string>()));
                                Invoke(new Action(() => _databaseList.AddRange(list)));
                                Invoke(new Action(() => cbxDatabase.Properties.Items.Clear()));
                                Invoke(new Action(() => cbxDatabase.Properties.Items.AddRange(list)));
                                Invoke(new Action(() => btnSave.Enabled = cbxDatabase.Enabled = true));
                                Invoke(new Action(() => progressBar.Visible = false));
                                Invoke(new Action(() => btnConnecting.Enabled = true));
                            });
                            var result = startJob.BeginInvoke(connectionstr, callBack, null);
                            return true;
                        }
                        else
                        {
                            return false;
                        }

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
                if (dx.Validate(cbxServer) && dx.Validate(cbxAuthentication) && dx.Validate(txtUser) && dx.Validate(txtPassword))
                {
                    connectionString =
                        $"Data Source = {cbxServer.Text};" +
                        $"User ID={txtUser.Text};" +
                        $"Password={txtPassword.Text};";
                    connectionstr.WindowsAuthentication = false;
                    connectionstr.ServerName = cbxServer.Text;
                    connectionstr.UserID = txtUser.Text;
                    connectionstr.Password = txtPassword.Text;
                    try
                    {
                        SqlHelper helper = new SqlHelper(connectionString);
                        if (helper.IsConnection)
                        {
                            var callBack = new AsyncCallback(asyncRes =>
                            {
                                var list = startJob.EndInvoke(asyncRes);
                                Invoke(new Action(() => _databaseList = new List<string>()));
                                Invoke(new Action(() => _databaseList.AddRange(list)));
                                Invoke(new Action(() => cbxDatabase.Properties.Items.Clear()));
                                Invoke(new Action(() => cbxDatabase.Properties.Items.AddRange(list)));
                                Invoke(new Action(() => btnSave.Enabled = cbxDatabase.Enabled = true));
                                Invoke(new Action(() => progressBar.Visible = false));
                                Invoke(new Action(() => btnConnecting.Enabled = true));
                            });
                            var result = startJob.BeginInvoke(connectionstr, callBack, null);
                            return true;
                        }
                        else
                            return false;
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
            //https://docs.microsoft.com/en-us/sql/relational-databases/server-management-objects-smo/create-program/connecting-to-an-instance-of-sql-server?view=sql-server-ver15

        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            TestConnection();
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

            if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
            {
                if (dx.Validate(cbxServer) && dx.Validate(cbxDatabase) && dx.Validate(cbxAuthentication))
                {
                    connectionString =
                        $"Data Source= {cbxServer.Text} ; Initial Catalog = {cbxDatabase.Text} ; Integrated Security = SSPI;";
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
                        $"Data Source = {cbxServer.Text};Initial Catalog={cbxDatabase.Text};User ID={txtUser.Text};Password={txtPassword.Text};";
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
            //var result = TestConnection();


            var srvconn = new ConnectionStrViewModel()
            {
                UserID = txtUser.Text,
                Password = txtPassword.Text,
                WindowsAuthentication = cbxAuthentication.Text == @"Windows Authentication",
                ServerName = cbxServer.Text.Split('\\')[0],
                InstanceName = cbxServer.Text.Split('\\').Length > 1 ? cbxServer.Text.Split('\\')[1] : string.Empty,
            };

            var result = _setDatabase.SqlServerConnect(srvconn);
            if (result)
            {
                var contain = new StructureMap.Container(new TypeRegistery());

                var frm = contain.GetInstance<NewDatabaseForm>();
                //frm.ServerName = cbxServer.Text.Trim();
                //frm.AuthenticationMode = cbxAuthentication.Text;
                //frm.ConnectionString = connectionString;
                frm.DatabaseList = _databaseList;
                frm.ConnectionStrViewModel = srvconn;
                //if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
                //{
                //    frm.UserName = frm.Password = string.Empty;
                //}
                //else
                //{
                //    frm.UserName = txtUser.Text;
                //    frm.Password = txtPassword.Text;
                //}
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
                var delegateBackup = new Func<string, bool>(BackupToFile);
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
                db = srv.Databases[cbxDatabase.Text];
                var bk = new Backup
                {
                    Action = BackupActionType.Database,
                    BackupSetDescription = "Full Backup of " + cbxDatabase.Text,
                    BackupSetName = cbxDatabase.Text + "_Backup",
                    Database = cbxDatabase.Text
                };
                var backupdevice = new BackupDevice
                {
                    Parent = srv,
                    Name = "backupdevice",
                    BackupDeviceType = BackupDeviceType.Disk,
                    PhysicalLocation =
                        $"{folder}\\{cbxDatabase.Text + "_FullBackup_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bak"}"
                };
                bk.Devices.AddDevice(backupdevice.PhysicalLocation, DeviceType.File);
                bk.Incremental = false;
                //var backupdate = new DateTime();
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
