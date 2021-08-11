using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;
using StructureMap;
using System.Windows.Forms;

namespace PMWORK.MachineryForms
{
    public partial class RequestListForm3 : XtraForm
    {
        private Container _container;
        public Container Container
        {
            get { return _container; }
            set { _container = value; }
        }


        private IRequestRepairRepository _request;
        public RequestListForm3(IRequestRepairRepository request)
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
            var dialogResult = XtraMessageBox.Show(@"آیا از حذف این مورد مطمئن هستید ؟", "حذف درخواست تعمیرات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var result = _request.RemoveRequestRepair(selectedRow.ID);
                if (result)
                   PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }
            UpdateRequestList(selectedRow.PublicTypeID_FK);
        }

        private void btnReportRepair_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRequestList.GetFocusedRowCellValue("ID") == null) return;
            var selectedRow = (RequestRepair)gvRequestList.GetFocusedRow();

            var repairFrom = _container.GetInstance<WorkOrderForm>();
            repairFrom.StartPosition = FormStartPosition.CenterScreen;
            repairFrom.RequestReapqirModel = selectedRow;
            repairFrom.ShowDialog();
            UpdateRequestList(selectedRow.PublicTypeID_FK);
        }

        private void btnRepairOut_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
            {
            if (gvRequestList.GetFocusedRowCellValue("ID") == null) return;
            var selectedRow = (RequestRepair)gvRequestList.GetFocusedRow();

            var frm = _container.GetInstance<RepairOutForm>();
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.RequestReapqirModel = selectedRow;
            frm.RequestID = selectedRow.ID ;
            frm.MachineryName =selectedRow.Machinery.MachineryTitle ;
            frm.Code = selectedRow.Machinery.Coding.Code.ToString() ;
            frm.RequestRepairTitle = selectedRow.RequestTitle;
            frm.ShowDialog();
            UpdateRequestList(selectedRow.PublicTypeID_FK);
            }
        }
}
