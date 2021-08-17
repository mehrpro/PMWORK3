using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity;
using PMWORK.Repository;


namespace PMWORK.Admin
{
    public partial class NewDatabaseForm : XtraForm
    {
        private readonly ISetDatabase _setDatabase;

        //private string _serverName;


        //private string _authenticationMode;
        //private string _userName;
        //private string _password;
        // private string _connectionString;
        private List<string> _databaseList;
        private ConnectionStrViewModel _connectionStr;


        public ConnectionStrViewModel ConnectionStrViewModel { get => _connectionStr; set => _connectionStr = value; }
        //public string ServerName { get => _serverName; set => _serverName = value; }
        //public string AuthenticationMode { get => _authenticationMode; set => _authenticationMode = value; }
        //public string UserName { get => _userName; set => _userName = value; }
        //public string Password { get => _password; set => _password = value; }
        public List<string> DatabaseList { get => _databaseList; set => _databaseList = value; }

        //public string ConnectionString
        //{
        //    get => _connectionString;
        //    set => _connectionString = value;
        //}

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
                    var srvConn = new ServerConnection(_connectionStr.ServerName);
                    srvConn.LoginSecure = _connectionStr.WindowsAuthentication;
                    srvConn.ServerInstance = _connectionStr.ServerName;
                    srvConn.Password = _connectionStr.Password;
                    srvConn.Login = _connectionStr.UserID;
                    //srvConn.ServerInstance = _connectionStr.InstanceName;
                    var result = _setDatabase.SqlServerConnect(_connectionStr);
                    if (result)
                    {
                        var srv = new Server(srvConn);
                        srv.ConnectionContext.ExecuteNonQuery(scriptNew);
                        srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptCompany);
                        srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptApplicationUser);
                        srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptUnitOfMa);

                        XtraMessageBox.Show("Database Created Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("The Connection to the Server is Lost", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }

            }
            else
            {
                XtraMessageBox.Show("Please Enter the Required Values", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
