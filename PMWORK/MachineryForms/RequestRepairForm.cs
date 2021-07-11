using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DevExpress.Utils.DirectXPaint;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.MachineryForms
{
    public partial class RequestRepairForm : XtraForm
    {
        private AppDbContext _db;
        private readonly int _typeofRequest;
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



        public RequestRepairForm(int typeofRequest)
        {
            InitializeComponent();
            _db = new AppDbContext();

            _typeofRequest = typeofRequest;
            dateRegistered.DateTime = DateTime.Now;

            cbxMachinery.Properties.DisplayMember = "Coding.Code";
            cbxMachinery.Properties.ValueMember = "ID";

            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxApplicant.Properties.DisplayMember = "ApplicantTitle";
            cbxApplicant.Properties.ValueMember = "ID";

            var str = _db.PublicTypes.Find(typeofRequest).Title;
            txtRequestTitle.Text += @" " + str;
            ClearForm();
            UpdateCompany();

        }

        private void UpdateApplicant(int companyId)
        {
            cbxApplicant.Properties.DataSource = _db.Applicants.Where(x => x.CompanyID_FK == companyId).ToList();
        }

        private void UpdateCompany()
        {
            cbxCompany.Properties.DataSource = _db.Companies.Select(x => new ComboBoxBaseClass() { ID = x.ID, Title = x.CompanyTiltle, Tag = x.Description }).ToList();
        }


        private void ClearForm()
        {
            dateRegistered.DateTime = DateTime.Now;
            radioGroupEMPM.SelectedIndex = 0;
            txtRequest.Text = "";

        }
        private void UpdateMachinery(int applicantIdFk)
        {
            cbxMachinery.Properties.DataSource = _db.Machineries
                .Include(c => c.Coding)
                .Where(x => x.ApplicantID_FK == applicantIdFk)
                .ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "ذخیره")
            {
                var select = _db.RequestRepairs.Find(_requestRepairEdit.ID);
                select.MachineryID_FK = Convert.ToInt32(cbxMachinery.EditValue);
                select.CompanyID_FK = Convert.ToInt32(cbxCompany.EditValue);
                select.ApplicantID_FK = Convert.ToInt32(cbxApplicant.EditValue);
                select.EM = Convert.ToBoolean(radioGroupEMPM.EditValue);
                select.RequestTitle = txtRequest.Text.Trim();
                _db.SaveChanges();
            }
            else
            {
                var obj = new RequestRepair()
                {
                    IsActive = true,
                    MachineryID_FK = Convert.ToInt32(cbxMachinery.EditValue),
                    CompanyID_FK = Convert.ToInt32(cbxCompany.EditValue),
                    ApplicantID_FK = Convert.ToInt32(cbxApplicant.EditValue),
                    UserID_FK = PublicClass.UserID,
                    PublicTypeID_FK = _typeofRequest,
                    EM = Convert.ToBoolean(radioGroupEMPM.EditValue),
                    RequestDataTime = DateTime.Now,
                    RequestTitle = txtRequest.Text.Trim()
                };
                _db.RequestRepairs.Add(obj);
                _db.SaveChanges();
            }
            Close();
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
