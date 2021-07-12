using System.Linq;
using DevExpress.XtraEditors;
using System.Data.Entity;
using PMWORK.Entities;
using PMWORK.Repository;
using StructureMap;

namespace PMWORK.MachineryForms
{
    public partial class RequestListForm : XtraForm
    {
        private readonly Container _container;
        public new Container Container { get; set; }


        private IRequestRepairRepository _request;
        public RequestListForm(IRequestRepairRepository request)
        {
            InitializeComponent();
            _container = Container;
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
            editForm.Editor = true;
            editForm.RequestRepairEdit = selectedRow;
            editForm.Show();
        }
    }
}
