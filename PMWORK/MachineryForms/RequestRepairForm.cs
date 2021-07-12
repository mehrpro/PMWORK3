using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.MachineryForms
{
    public partial class RequestRepairForm : XtraForm
    {
        private readonly IRequestRepairRepository _request;
        private int _typeofRequest;
        private ComboBoxBaseClass _selectCompany;
        private Applicant _selectApplicant;
        private Machinery _selectedMachinery;
        private RequestRepair _requestRepairEdit;
        private bool _editor;
        public RequestRepair RequestRepairEdit
        {
            get { return _requestRepairEdit; }
            set => _requestRepairEdit = value;
        }
        public bool Editor
        {
            get { return _editor; }
            set => _editor = value;
        }
        public int TypeOfRequest { get; set; }
        public RequestRepairForm(IRequestRepairRepository request)
        {

            InitializeComponent();
            _typeofRequest = TypeOfRequest;
            //dateRegistered.DateTime = DateTime.Now;
            _request = request;
            cbxMachinery.Properties.DisplayMember = "Coding.Code";
            cbxMachinery.Properties.ValueMember = "ID";

            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxApplicant.Properties.DisplayMember = "ApplicantTitle";
            cbxApplicant.Properties.ValueMember = "ID";

            txtRequestTitle.Text += @" " + _request.GetStringTypeOfRequest(_typeofRequest);
            ClearForm();
            UpdateCompany();

        }
        private void UpdateApplicant(int companyId)
        {
            cbxApplicant.Properties.DataSource = _request.GetAllApplicantsByCompanyId(companyId);
        }
        private void UpdateCompany()
        {
            cbxCompany.Properties.DataSource = _request.GetAllCompanies();
        }
        private void ClearForm()
        {
            dateRegistered.DateTime = DateTime.Now;
            radioGroupEMPM.SelectedIndex = 0;
            txtRequest.Text = "";

        }
        private void UpdateMachinery(int applicantIdFk)
        {
            cbxMachinery.Properties.DataSource = _request.GetMachineriesByApplicantId(applicantIdFk);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "ذخیره")
            {
                var select = _request.FindRequestRepairById(_requestRepairEdit.ID);
                select.MachineryID_FK = Convert.ToInt32(cbxMachinery.EditValue);
                select.CompanyID_FK = Convert.ToInt32(cbxCompany.EditValue);
                select.ApplicantID_FK = Convert.ToInt32(cbxApplicant.EditValue);
                select.EM = Convert.ToBoolean(radioGroupEMPM.EditValue);
                select.RequestTitle = txtRequest.Text.Trim();
                var result = _request.UpdateRequestRepair(select);
                if (!result)
                    XtraMessageBox.Show(PublicClass.ErrorSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    Close();
            }
            else
            {
                var model = new RequestRepair();
                model.IsActive = true;
                model.UserID_FK = PublicClass.UserID;
                model.RequestDataTime = DateTime.Now;
                model.MachineryID_FK = Convert.ToInt32(cbxMachinery.EditValue);
                model.CompanyID_FK = Convert.ToInt32(cbxCompany.EditValue);
                model.ApplicantID_FK = Convert.ToInt32(cbxApplicant.EditValue);
                model.PublicTypeID_FK = _typeofRequest;
                model.EM = Convert.ToBoolean(radioGroupEMPM.EditValue);
                model.RequestTitle = txtRequest.Text.Trim();
                var result = _request.AddNewRequestRepair(model);
                if (result)
                    XtraMessageBox.Show(PublicClass.ErrorSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    Close();
            }

        }
        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null)
            {
                txtMachinery.Text = "";
                cbxApplicant.Properties.DataSource = null;
                return;
            }
            UpdateApplicant(_selectCompany.ID);
        }
        private void cbxMachinery_EditValueChanged_1(object sender, EventArgs e)
        {
            _selectedMachinery = (Machinery)cbxMachinery.GetSelectedDataRow();
            if (_selectedMachinery == null)
            {
                txtMachinery.Text = "";
                return;
            }
            txtMachinery.Text = _selectedMachinery.MachineryTitle;
        }
        private void cbxApplicant_EditValueChanged(object sender, EventArgs e)
        {
            _selectApplicant = (Applicant)cbxApplicant.GetSelectedDataRow();
            if (_selectApplicant == null)
            {
                cbxMachinery.EditValue = null;
                return;
            }
            UpdateMachinery(_selectApplicant.ID);
        }
        private void RequestRepairForm_Load(object sender, EventArgs e)
        {
            if (_editor)
            {
                dateRegistered.DateTime = _requestRepairEdit.RequestDataTime;
                cbxCompany.EditValue = _requestRepairEdit.CompanyID_FK;
                UpdateApplicant(_requestRepairEdit.CompanyID_FK);
                cbxApplicant.EditValue = _requestRepairEdit.ApplicantID_FK;
                UpdateMachinery(_requestRepairEdit.ApplicantID_FK);
                cbxMachinery.EditValue = _requestRepairEdit.MachineryID_FK;
                txtRequest.EditValue = _requestRepairEdit.RequestTitle;
                radioGroupEMPM.EditValue = _requestRepairEdit.EM;
                btnSave.Text = "ذخیره";
            }
        }
    }
}
