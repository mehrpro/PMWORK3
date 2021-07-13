using System.Linq;
using DevExpress.XtraEditors;
using System.Data.Entity;
using PMWORK.Entities;
using PMWORK.Repository;
using StructureMap;
using System.Windows.Forms;

namespace PMWORK.MachineryForms
{
    public partial class RequestListForm : XtraForm
    {
        private  Container _container;
        public  Container Container
        {
            get { return _container; }
            set { _container = value; }
        }


        private IRequestRepairRepository _request;
        public RequestListForm(IRequestRepairRepository request)
        {
            InitializeComponent();
           // _container = Container;
            _request = request;
        }
        private void UpdateRequestList(int type)
        {
            dgvRequestList.DataSource = _request.GetActiveRequestRepair(type);
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
            var editForm = _container.GetInstance<RequestRepairForm>();
            editForm.StartPosition = FormStartPosition.CenterScreen;
            editForm.Editor = true;
            editForm.RequestRepairEdit = selectedRow;
            editForm.TypeOfRequest = selectedRow.PublicTypeID_FK;
            editForm.ShowDialog();
            UpdateRequestList(selectedRow.PublicTypeID_FK);
        }

        private void RequestListForm_Load(object sender, System.EventArgs e)
        {
            

        }

        private void btnDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRequestList.GetFocusedRowCellValue("ID") == null) return;
            var selectedRow = (RequestRepair)gvRequestList.GetFocusedRow();
            var dialogResult = XtraMessageBox.Show(PublicClass.DeleteMessage, "حذف درخواست تعمیرات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var result = _request.RemoveRequestRepair(selectedRow.ID);
                if (result)                
                    XtraMessageBox.Show(PublicClass.SuccessSave, "حذف درخواست تعمیرات", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                else                
                    XtraMessageBox.Show(PublicClass.ErrorSave, "حذف درخواست تعمیرات", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            UpdateRequestList(selectedRow.PublicTypeID_FK);
        }

        private void btnReportRepair_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRequestList.GetFocusedRowCellValue("ID") == null) return;
            var selectedRow = (RequestRepair)gvRequestList.GetFocusedRow();
        }
    }
}
