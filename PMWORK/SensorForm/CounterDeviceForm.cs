using DevExpress.XtraEditors;
using System;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.SensorForm
{
    public partial class CounterDeviceForm : XtraForm
    {
        private readonly ISensorRepository _sensorRepository;
        private CounterDevice _selectedRow;
        private Company _selectCompany;
        private Applicant _selectApplicant;

        public CounterDeviceForm(ISensorRepository sensorRepository)
        {
            InitializeComponent();
            _sensorRepository = sensorRepository;

            cbxApplicant.Properties.DisplayMember = "ApplicantTitle";
            cbxApplicant.Properties.ValueMember = "ID";

            cbxCompany.Properties.DisplayMember = "CompanyTitle";
            cbxCompany.Properties.ValueMember = "ID";
        }

        private async void CounterDeviceForm_Load(object sender, EventArgs e)
        {
            cbxCompany.Properties.DataSource = await _sensorRepository.GetAllCompany();
        }

        private async void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (Company)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null)
            {
                cbxApplicant.Properties.DataSource = null;
                dgvCounterDevice.DataSource = null;
                return;
            }
            cbxApplicant.Properties.DataSource = await _sensorRepository.GetApplicantListByCompanyId(_selectCompany.ID);
            dgvCounterDevice.DataSource = await _sensorRepository.GetCounterDevicesByCompanyId(_selectCompany.ID);
        }

        private void cbxApplicant_EditValueChanged(object sender, EventArgs e)
        {
            _selectApplicant = (Applicant)cbxApplicant.GetSelectedDataRow();
            if (_selectApplicant == null)
            {
                return;
            }
        }

        private void ClearForm()
        {
            txtCounterName.Text = txtDescription.Text = txtID.Text = "";
            chkIsActive.Checked = true;
            //cbxCompany.EditValue = 0;
            btnClose.Text = PublicClass.CloseStr;
            txtCounterName.Focus();
            _selectedRow = null;

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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                if (_selectedRow != null)
                {
                    _selectedRow.CounterTitle = txtCounterName.Text.Trim();
                    _selectedRow.ApplicatinID_FK = _selectApplicant.ID;
                    _selectedRow.Description = txtDescription.Text.Trim();
                    _selectedRow.IsActive = chkIsActive.Checked;
                    var result = await _sensorRepository.AddEditCounterDevice(_selectedRow);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);
                        ClearForm();
                    }
                    else
                        PublicClass.ErrorSave(Text);

                }
                else
                {
                    var obj = new CounterDevice();
                    obj.CounterTitle = txtCounterName.Text.Trim();
                    obj.ApplicatinID_FK = _selectApplicant.ID;
                    obj.Description = txtDescription.Text.Trim();
                    obj.IsActive = chkIsActive.Checked;
                    var result = await _sensorRepository.AddEditCounterDevice(obj);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);
                        ClearForm();
                    }
                    else
                        PublicClass.ErrorSave(Text);

                }
            }
            else
                PublicClass.ErrorValidationMessage(Text);
        }



        private void gvCounterDevice_Click(object sender, EventArgs e)
        {
            if (gvCounterDevice.GetFocusedRowCellValue("ID") == null) return;
            _selectedRow = (CounterDevice)gvCounterDevice.GetFocusedRow();
            txtID.EditValue = _selectedRow.ID;
            txtCounterName.Text = _selectedRow.CounterTitle;
            txtDescription.EditValue = _selectedRow.Description;
            cbxApplicant.EditValue = _selectedRow.ApplicatinID_FK;
            cbxCompany.EditValue = _selectedRow.Applicant.CompanyID_FK;
            btnClose.Text = PublicClass.CancelStr;
        }
    }
}
