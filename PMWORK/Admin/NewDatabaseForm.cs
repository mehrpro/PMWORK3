using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK.Admin
{
    public partial class NewDatabaseForm : XtraForm
    {

        private delegate void DelegateMaster();
        private string serverName;
        private string authenticationMode;
        private string userName;
        private string password;

        public string ServerName { get => serverName; set => serverName = value; }
        public string AuthenticationMode { get => authenticationMode; set => authenticationMode = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public NewDatabaseForm()
        {
            InitializeComponent();

            progressBar.Visible = false;
        }

        private void NewDatabaseForm_Load(object sender, EventArgs e)
        {
            txtServer.Text = serverName;
            txtAuthentication.Text = authenticationMode;
            txtUser.Text = userName;
            DatabaseList();

        }

        private void DatabaseList()
        {
            var databaseList = new Server().Databases;
            foreach (var item in databaseList)
            {
                var str = item.ToString();
            }
        }
    }
}
