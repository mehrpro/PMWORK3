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
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.MachineryForms
{
    public partial class RequestListForm : XtraForm
    {
        private IRequestRepairRepository _request;
        public RequestListForm()
        {
            InitializeComponent();
            _request = new RequestRepairRepository();
        }



        private async void UpdateRequestList(int id)
        {              
           
            dgvRequestList.DataSource = await _request.GetActiveRequestRepair(id);
        }

        private  void btnElectricalList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
            var selected_Row = (RequestRepair)gvRequestList.GetFocusedRow();
            var editForm = new RequestRepairForm(selected_Row.PublicTypeID_FK);
            editForm.Editor = true;
            editForm.RequestRepairEdit = selected_Row;
            editForm.ShowDialog();            
        }
    }
}
