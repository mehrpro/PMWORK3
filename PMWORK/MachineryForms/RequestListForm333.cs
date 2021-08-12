using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;
using StructureMap;
using System.Windows.Forms;

namespace PMWORK.MachineryForms
{
    public partial class RequestListForm333 : XtraForm
    {
        private Container _container;
        public Container Container
        {
            get { return _container; }
            set { _container = value; }
        }


        private IRequestRepairRepository _request;
        public RequestListForm333(IRequestRepairRepository request)
        {
            InitializeComponent();
            _request = request;
            UpdateRequestList();
            }
        private void UpdateRequestList()
        {
            dgvRequestList.DataSource = _request.GetRepairouts();
        }
        
        private void btnEditRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRequestList.GetFocusedRowCellValue("ID") == null) return;
            var selectedRow = (RequestRepair)gvRequestList.GetFocusedRow();
            var repairFrom = _container.GetInstance<WorkOrderForm>();
            repairFrom.Editable = true;
            repairFrom.StartPosition = FormStartPosition.CenterScreen;
            repairFrom.RequestReapqirModel = selectedRow;
            repairFrom.ShowDialog();
            UpdateRequestList();
        }

        private void RequestListForm_Load(object sender, System.EventArgs e)
        {


        }

        private void btnDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRequestList.GetFocusedRowCellValue("ID") == null) return;
            var selectedRow = (Repairout)gvRequestList.GetFocusedRow();
            var dialogResult = XtraMessageBox.Show(@"آیا از حذف این مورد مطمئن هستید ؟", "حذف درخواست تعمیرات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var result = _request.RemoveRepairOut(selectedRow.ID);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }
            UpdateRequestList();
        }

        private void btnReportRepair_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRequestList.GetFocusedRowCellValue("ID") == null) return;
            var selectedRow = (Repairout)gvRequestList.GetFocusedRow();
            var repairFrom = _container.GetInstance<RepairOutForm3>();
            repairFrom.Repairout = selectedRow;
            repairFrom.StartPosition = FormStartPosition.CenterScreen;           
            repairFrom.ShowDialog();                         
            UpdateRequestList();                
            
        }
    }
}
