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
        private ConnectionStrViewModel _srvConnStr;

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
            Invoke(new Action(() => cbxServer.Enabled = true));
            Invoke(new Action(() => progressBar.Visible = false));
        }


        private void SettingForm_Load(object sender, EventArgs e)
        {
            cbxServer.Enabled = false;
            var str = EnCoding.ConnString();
            if (!string.IsNullOrWhiteSpace(str))
            {
                cbxServer.Text = str.Split(';')[0].Split('=')[1].Trim();
                cbxDatabase.Text = str.Split(';')[1].Split('=')[1].Trim();
            }
            progressBar.Visible = true;
            var cbxServerDelegate = new DelegateMaster(cbxServerInstance);
            cbxServerDelegate.BeginInvoke(null, null);
        }

        private bool TestConnection()
        {
            GetConnectionInfor();
            var startJob = new Func<ConnectionStrViewModel, List<string>>(_setDatabase.GetDatabaseListByServerName);

            if (cbxAuthentication.SelectedIndex == 0 && cbxAuthentication.Text == @"Windows Authentication")
            {
                if (dx.Validate(cbxServer) && dx.Validate(cbxAuthentication))
                {
                    try
                    {
                        progressBar.Visible = true;
                        btnConnecting.Enabled = false;
                        var result = _setDatabase.SqlServerConnect(_srvConnStr);
                        if (result)
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
                            startJob.BeginInvoke(_srvConnStr, callBack, null);
                            if (cbxDatabase.Properties.Items.Count > 0)
                                return true;
                        }
                        return false;
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                PublicClass.ErrorValidationMessage(Text);
                return false;

            }
            else
            {
                if (dx.Validate(cbxServer) && dx.Validate(cbxAuthentication) && dx.Validate(txtUser) && dx.Validate(txtPassword))
                {
                    try
                    {
                        var result = _setDatabase.SqlServerConnect(_srvConnStr);
                        if (result)
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
                            startJob.BeginInvoke(_srvConnStr, callBack, null);
                            if (cbxDatabase.Properties.Items.Count > 0)
                                return true;
                        }
                        return false;
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TestConnection();
        }

        private void GetConnectionInfor()
        {
            _srvConnStr = new ConnectionStrViewModel()
            {
                UserID = txtUser.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                WindowsAuthentication = cbxAuthentication.Text == @"Windows Authentication",
                Server_Instance = cbxServer.Text.Trim(),
                DatabaseName = cbxDatabase.Text.Trim(),
                ServerName = cbxServer.Text.Split('\\')[0],
                InstanceName = cbxServer.Text.Split('\\').Length > 1 ? cbxServer.Text.Split('\\')[1] : null,
            };
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

            _srvConnStr = new ConnectionStrViewModel()
            {
                UserID = txtUser.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                WindowsAuthentication = cbxAuthentication.Text == @"Windows Authentication",
                Server_Instance = cbxServer.Text.Trim(),
                DatabaseName = cbxDatabase.Text.Trim(),
                ServerName = cbxServer.Text.Split('\\')[0],
                InstanceName = cbxServer.Text.Split('\\').Length > 1 ? cbxServer.Text.Split('\\')[1] : null,
            };

            if (dx.Validate(cbxServer) && dx.Validate(cbxDatabase))
            {
                var result = _setDatabase.SqlServerConnect(_srvConnStr);
                if (result)
                {
                    var res = _setDatabase.SaveAppSetting(_srvConnStr);
                    if (res)
                    {
                        XtraMessageBox.Show("اطلاعات با موفقیت ذخیره شد", "بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PublicClass.CloseForce = true;
                        Close();
                    }
                    else
                    {
                        PublicClass.ErrorSave("خطا");
                    }
                }
            }
            else
                PublicClass.ErrorValidationMessage(Text);
        }

        private void newDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _srvConnStr = new ConnectionStrViewModel()
            {
                UserID = txtUser.Text,
                Password = txtPassword.Text,
                WindowsAuthentication = cbxAuthentication.Text == @"Windows Authentication",
                Server_Instance = cbxServer.Text.Trim(),
                ServerName = cbxServer.Text.Split('\\')[0],
                InstanceName = cbxServer.Text.Split('\\').Length > 1 ? cbxServer.Text.Split('\\')[1] : null,
            };
            if (_srvConnStr.WindowsAuthentication)
            {
                if (dx.Validate(cbxServer))
                {
                    var result = _setDatabase.SqlServerConnect(_srvConnStr);
                    if (!result) return;
                    if (!TestConnection()) return;
                    var contain = new StructureMap.Container(new TypeRegistery());
                    var frm = contain.GetInstance<NewDatabaseForm>();
                    frm.DatabaseList = _databaseList;
                    frm.ConnectionStrViewModel = _srvConnStr;
                    frm.ShowDialog();
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);

                }
            }
            else
            {
                if (dx.Validate(cbxServer) && dx.Validate(txtUser) && dx.Validate(txtPassword))
                {
                    var result = _setDatabase.SqlServerConnect(_srvConnStr);
                    if (result) return;
                    if (!TestConnection()) return;
                    var contain = new StructureMap.Container(new TypeRegistery());
                    var frm = contain.GetInstance<NewDatabaseForm>();
                    frm.DatabaseList = _databaseList;
                    frm.ConnectionStrViewModel = _srvConnStr;
                    frm.ShowDialog();
                }
                else
                {
                    PublicClass.ErrorValidationMessage(Text);

                }
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
                        XtraMessageBox.Show("فایل پشتیبان با موفقیت ایجاد شد", "پشتیبان گیری", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        XtraMessageBox.Show("خطا در پشتیبان گیری", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            var cbxServerDelegate = new DelegateMaster(cbxServerInstance);
            var result = cbxServerDelegate.BeginInvoke(null, null);

        }

        private void btnReadConnectionString_Click(object sender, EventArgs e)
        {
            var appsettimg = new AppSetting();
            var str = appsettimg.GetConnectionString("Conn");
            MessageBox.Show(EnCoding.ConnString().Split(';')[0] + "\n"
                                                                   + EnCoding.ConnString().Split(';')[1], "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var frm = new About();
            frm.ShowDialog();
        }


    }
}
