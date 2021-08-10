using System;
using System.Linq;
using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.CodingForms
{
    public partial class ApplicantForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;


        private Applicant _selectApplicant;
        private ComboBoxBaseClass _selectedCompany;

        public ApplicantForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxCompany.Properties.DataSource = _codingRepository.GetAllCompanies().Select(x => new ComboBoxBaseClass()
            {
                ID = x.ID,
                Title = x.CompanyTitle,
                Tag = x.Description
            }).ToList();
        }

        private void UpdateApplicantList(int companyId)
        {
            dgvApplicantList.DataSource = _codingRepository.GetApplicantsByCompanyId(companyId);

        }


        private void ClearForm()
        {
            cbxCompany.ReadOnly = false;
            _selectApplicant = null;
            txtApplicantTitle.Text = txtDescription.Text = null;
            btnClose.Text = PublicClass.CloseStr;

        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectedCompany == null)
            {
                dgvApplicantList.DataSource = null;
                return;
            }

            UpdateApplicantList(_selectedCompany.ID);

        }

        private void btnSelectRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvApplicantList.GetFocusedRowCellValue("ID") != null)
            {
                _selectApplicant = (Applicant)gvApplicantList.GetFocusedRow();
                txtApplicantTitle.Text = _selectApplicant.ApplicantTitle;
                txtDescription.Text = _selectApplicant.Description;

                cbxCompany.ReadOnly = true;


                btnClose.Text = PublicClass.CancelStr;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {
                _selectApplicant.ApplicantTitle = txtApplicantTitle.Text.Trim();
                _selectApplicant.Description = txtDescription.Text.Trim();
                var result = _codingRepository.AddEditApplicant(_selectApplicant);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);

            }
            else
            {
                var obj = new Applicant
                {
                    ApplicantTitle = txtApplicantTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    CompanyID_FK = Convert.ToInt32(cbxCompany.EditValue)
                };
                var result = _codingRepository.AddEditApplicant(obj);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);

            }
            UpdateApplicantList(_selectedCompany.ID);
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {
                ClearForm();
            }
            else
            {
                Close();
            }
        }
    }
}
