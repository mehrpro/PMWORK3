using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PMWORK.Repository;


namespace PMWORK.Admin
{
    public partial class NewDatabaseForm : XtraForm
    {
        private readonly ISetDatabase _setDatabase;
        private List<string> _databaseList;
        private ConnectionStrViewModel _connectionStr;


        public ConnectionStrViewModel ConnectionStrViewModel { get => _connectionStr; set => _connectionStr = value; }
        public List<string> DatabaseList { get => _databaseList; set => _databaseList = value; }
        public NewDatabaseForm(ISetDatabase setDatabase)
        {
            _setDatabase = setDatabase;
            InitializeComponent();
            progressBar.Visible = false;
        }

        private void NewDatabaseForm_Load(object sender, EventArgs e)
        {
            txtServer.Text = _connectionStr.ServerName;
            txtAuthentication.Text = _connectionStr.WindowsAuthentication ? @"Windows Authentication" : @"SQL Server Authentication";
            txtUser.Text = _connectionStr.UserID;
            cbxDataBase.Properties.Items.AddRange(_databaseList);
        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {

                var folderBrowserDialog = new FolderBrowserDialog { ShowNewFolderButton = true };
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    var folder = folderBrowserDialog.SelectedPath;
                    var scriptNew = Properties.Resources.sqlScriptForNewDatabase.Replace("95", cbxDataBase.Text).Replace("AddressFileForSave", folder);
                    var srvConn = new ServerConnection(_connectionStr.Server_Instance);
                    srvConn.LoginSecure = _connectionStr.WindowsAuthentication;
                    srvConn.ServerInstance = _connectionStr.Server_Instance;
                    if (!_connectionStr.WindowsAuthentication)
                    {
                        srvConn.Password = _connectionStr.Password;
                        srvConn.Login = _connectionStr.UserID;
                    }

                    var result = _setDatabase.SqlServerConnect(_connectionStr);
                    if (result)
                    {
                        var srv = new Server(srvConn);
                        srv.ConnectionContext.ExecuteNonQuery(scriptNew);
                        srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptCompany.Replace("95", cbxDataBase.Text.Trim()));
                        srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptApplicationUser.Replace("95", cbxDataBase.Text.Trim()));
                        srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptUnitOfMa.Replace("95", cbxDataBase.Text.Trim()));
                        _connectionStr.DatabaseName = cbxDataBase.Text.Trim();
                        var connectionString = _setDatabase.SaveAppSetting(_connectionStr);
                        XtraMessageBox.Show("بانک اطلاعاتی جدید با موفقیت ایجاد شد", "بانک اطلاعاتی",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PublicClass.CloseForce = true;
                        Close();
                    }
                    else
                        XtraMessageBox.Show("ازتباط با سرور ممکن نیست", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }

            }
            else
            {
                PublicClass.ErrorValidationMessage("حطا");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
