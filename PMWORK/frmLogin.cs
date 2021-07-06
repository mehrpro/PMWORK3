using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK
{
    public partial class frmLogin2 : XtraForm
    {

        public frmLogin2()
        {
            InitializeComponent();
            //////
            PublicClass.UserID = 1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var frm = new MainForm().ShowDialog();
        }

     
    }
}
