using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace PMWORK.MachineryForms
{
    public partial class RequestListForm : XtraForm
    {
        public RequestListForm()
        {
            InitializeComponent();
        }


        private async void UpdateRequestList(int id)
        {
            var qry = await PublicClass.db.RequestRepairs.Include(a => a.Machinery.Coding).Where(x => x.PublicTypeID_FK == id).ToListAsync();
            dgvRequestList.DataSource = qry;
        }

        private  void btnElectricalList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
             UpdateRequestList(1);
        }
    }
}
