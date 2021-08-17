using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMWORK.Admin
{
    public partial class NewDatabaseForm : XtraForm
    {

        private delegate void DelegateMaster();
        private string _serverName;
        private string _authenticationMode;
        private string _userName;
        private string _password;
        private string _connectionString;
        private List<string> _databaseList;

        public string ServerName { get => _serverName; set => _serverName = value; }
        public string AuthenticationMode { get => _authenticationMode; set => _authenticationMode = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public List<string> DatabaseList { get => _databaseList; set => _databaseList = value; }

        public string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value;
        }

        public NewDatabaseForm()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        private void NewDatabaseForm_Load(object sender, EventArgs e)
        {
            txtServer.Text = _serverName;
            txtAuthentication.Text = _authenticationMode;
            txtUser.Text = _userName;   
            cbxDataBase.Properties.Items.AddRange(_databaseList);              
        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                var folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    var folder = folderBrowserDialog.SelectedPath;
                    var scriptNew = Properties.Resources.sqlScriptForNewDatabase.Replace("95", cbxDataBase.Text).Replace("AddressFileForSave", folder);
                    var inst = _serverName.Split(new char[] { '\\' });
                    Server srv = new Server(inst[0]+ "\\"+inst[1]);
                    if (_authenticationMode == @"Windows Authentication")
                    {                        
                        srv.ConnectionContext.LoginSecure = true;                    
                        //srv.ConnectionContext.ServerInstance = inst[1];                    
                    }
                    else
                    {                        
                        srv.ConnectionContext.LoginSecure = false;
                        srv.ConnectionContext.Password = _password;
                        srv.ConnectionContext.Login = _userName;
                        srv.ConnectionContext.ServerInstance = inst[1];                      
                    }
                    srv.ConnectionContext.ExecuteNonQuery(scriptNew);

                    var appuser = srv.Databases["ApplicationUser"];
                    

                }            



                IList<ApplicationUser> defaultUsers = new List<ApplicationUser>();
                defaultUsers.Add(new ApplicationUser() { UserId = 1, Enabled = true, UserName = "admin", UserPassword = "admin", FullName = "مدیرسیستم", CompanyID_FK = 1, Editor = "Admin", LimetedCompany = false }); ;
                //context.ApplicationUsers.AddRange(defaultUsers);
          

                PublicClass.SuccessMessage(Text);
                Close();
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
