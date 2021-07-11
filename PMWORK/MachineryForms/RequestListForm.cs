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
using System.Data.SqlClient;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.MachineryForms
{
    public partial class RequestListForm : XtraForm
    {
        //private IRequestRepairRepository _request;
        private AppDbContext context;
        public RequestListForm()
        {
            InitializeComponent();
            // _request = new RequestRepairRepository();
            context = new AppDbContext();
        }



        private void UpdateRequestList(int type)
        {
            dgvRequestList.DataSource = context.RequestRepairs
                .Include(a => a.Machinery.Coding)
                .Include(s => s.Applicant)
                .Where(x => x.PublicTypeID_FK == type)
                .ToList();
        }

        private void btnElectricalList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UpdateRequestList(1);
        }

        private void btnMecanicalList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UpdateRequestList(2);

        }

        private void btnPipeLine_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UpdateRequestList(3);

        }

        private void btnBuilding_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UpdateRequestList(4);

        }

        private void btnEditRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRequestList.GetFocusedRowCellValue("ID") == null) return;
            var selectedRow = (RequestRepair)gvRequestList.GetFocusedRow();
            var editForm = new RequestRepairForm(selectedRow.PublicTypeID_FK)
            {
                Editor = true,
                RequestRepairEdit = selectedRow
            };
            editForm.ShowDialog();
        }
    }
}
