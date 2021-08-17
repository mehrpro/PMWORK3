using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;

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
        private List<string> _instanceList;

        public string ServerName { get => _serverName; set => _serverName = value; }
        public string AuthenticationMode { get => _authenticationMode; set => _authenticationMode = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public List<string> InstanceList { get => _instanceList; set => _instanceList = value; }

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
            cbxDataBase.Properties.Items.AddRange(_instanceList);              
        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            var srvServer = new Server(_connectionString);
            var db = new Database(srvServer, cbxDataBase.Text.Trim());
            db.Create();
        }
    }
}
