using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using PMWORK.Repository;
using PMWORK.PMForms;
using StructureMap;

namespace PMWORK.CodingForms
{
    public partial class IdentityDeviceForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private ComboBoxBaseClass _selectedCompany;
        private ComboBoxBaseClass _selectedApplicant;
        private Container _container;
        public Container Container
        {
            get { return _container; }
            set { _container = value; }
        }

        public IdentityDeviceForm(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxCompany.Properties.DataSource = _codingRepository.GetAllCompanies()
            .Select(x => new ComboBoxBaseClass
            {
                ID = x.ID,
                Title = x.CompanyTitle,
                Tag = x.Description
            })
            .ToList(); ;
            cbxApplicantList.Properties.DisplayMember = "Title";
            cbxApplicantList.Properties.ValueMember = "ID";
        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectedCompany == null)
            {
                dgvMachineryList.DataSource = null;

                cbxApplicantList.Properties.DataSource = null;
                return;
            }
            dgvMachineryList.DataSource = null;
            cbxApplicantList.Properties.DataSource =
                _codingRepository.GetApplicantsByCompanyId(_selectedCompany.ID)
            .Select(x => new ComboBoxBaseClass
            {
                ID = x.ID,
                Title = x.ApplicantTitle,
                Tag = x.Description
            }).ToList();
        }


        private void cbxApplicantList_EditValueChanged(object sender, EventArgs e)
        {
            _selectedApplicant = (ComboBoxBaseClass)cbxApplicantList.GetSelectedDataRow();
            if (_selectedApplicant == null)
            {
                return;
            }
            dgvMachineryList.DataSource = _codingRepository.GetMachineriesListByApplicantId(_selectedApplicant.ID);
        }

        private void btnIdentity_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvMachineryList.GetFocusedRowCellValue("ID") == null)
            {
                return;
            }
            var selected = (Entities.Machinery)gvMachineryList.GetFocusedRow();
            var frm = _container.GetInstance<IdentityMachineryForm>();
            frm.Code = selected.Coding.Code.ToString();
            frm.MachineryID = selected.ID;
            frm.MachineryName = selected.MachineryTitle;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();

        }

        private void btnServices_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvMachineryList.GetFocusedRowCellValue("ID") == null)
            {
                return;
            }
            var selected = (Entities.Machinery)gvMachineryList.GetFocusedRow();

            var frm = _container.GetInstance<ServicePerideForm>();
            frm.Code = selected.Coding.Code.ToString();
            frm.MachineryID = selected.ID;
            frm.MachineryName = selected.MachineryTitle;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();
        }

        private void btnSpareParts_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvMachineryList.GetFocusedRowCellValue("ID") == null)
            {
                return;
            }
            var selected = (Entities.Machinery)gvMachineryList.GetFocusedRow();

            var frm = _container.GetInstance<SparePartsForm>();
            frm.Code = selected.Coding.Code.ToString();
            frm.MachineryID = selected.ID;
            frm.MachineryName = selected.MachineryTitle;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();

        }

        private void btnElectrical_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvMachineryList.GetFocusedRowCellValue("ID") == null)
            {
                return;
            }
            var selected = (Entities.Machinery)gvMachineryList.GetFocusedRow();

            var frm = _container.GetInstance<PowerElectricalForm>();
            frm.Code = selected.Coding.Code.ToString();
            frm.MachineryID = selected.ID;
            frm.MachineryName = selected.MachineryTitle;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();

        }

        private void btnRecodOrders_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvMachineryList.GetFocusedRowCellValue("ID") == null)
            {
                return;
            }
            var selected = (Entities.Machinery)gvMachineryList.GetFocusedRow();

            var frm = _container.GetInstance<ReportWorkOrderForm>();
            frm.Code = selected.Coding.Code.ToString();
            frm.MachineryID = selected.ID;
            frm.MachineryName = selected.MachineryTitle;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();
        }

        private void IdentityDeviceForm_Load(object sender, EventArgs e)
            {
            if (PublicClass.LimitedCompany)
                {
                cbxCompany.EditValue = PublicClass.CompanyID;
                cbxCompany.Enabled = false;
                }
            }
        }
}
