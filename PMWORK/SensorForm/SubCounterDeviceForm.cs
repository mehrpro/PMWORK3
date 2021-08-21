using DevExpress.XtraEditors;
using PMWORK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using PMWORK.Entities;

namespace PMWORK.SensorForm
{
    public partial class SubCounterDeviceForm : XtraForm
    {
        private readonly ISensorRepository _sensorRepository;
        private Company _selectCompany;
        private CounterDevice _selectCounterDevice;
        private SubCounterDevice _selectedRow;

        public SubCounterDeviceForm(ISensorRepository sensorRepository)
        {
            InitializeComponent();
            _sensorRepository = sensorRepository;

            cbxCounterDevice.Properties.DisplayMember = "CounterTitle";
            cbxCounterDevice.Properties.ValueMember = "ID";

            cbxCompany.Properties.DisplayMember = "CompanyTitle";
            cbxCompany.Properties.ValueMember = "ID";

            cbxType.Properties.DisplayMember = "Unit";
            cbxType.Properties.ValueMember = "ID";



        }

        private async void SubCounterDeviceForm_Load(object sender, EventArgs e)
        {
            cbxCompany.Properties.DataSource = await _sensorRepository.GetAllCompany();
            cbxType.Properties.DataSource = await _sensorRepository.GetUnitOfMeasurementsList();
        }

        private async void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (Company)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null)
            {
                cbxCounterDevice.Properties.DataSource = null;
                return;
            }
            cbxCounterDevice.Properties.DataSource =
                await _sensorRepository.GetCounterDevicesByCompanyId(_selectCompany.ID);
            dgvSubCounterDevice.DataSource =
                await _sensorRepository.GetSubCounterDevicesByCompanyId(_selectCompany.ID);
        }

        private async void cbxCounterDevice_EditValueChanged(object sender, EventArgs e)
        {
            _selectCounterDevice = (CounterDevice)cbxCounterDevice.GetSelectedDataRow();
            if (_selectCounterDevice == null)
            {
                dgvSubCounterDevice.DataSource = null;
                return;
            }
            dgvSubCounterDevice.DataSource =
                await _sensorRepository.GetSubCounterDevicesByCounterDevice(_selectCounterDevice.ID);
        }
        private void ClearForm()
        {
            txtID.Text = txtTerminal.Text = txtDescription.Text = null;
            cbxType.EditValue = 0;  //cbxCounterDevice.EditValue = 0;
            btnClose.Text = PublicClass.CloseStr;
            _selectedRow = null;

        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                if (_selectedRow != null)
                {
                    _selectedRow.Description = txtDescription.Text.Trim();
                    _selectedRow.CounterDeviceID_FK = _selectCounterDevice.ID;
                    _selectedRow.IsActive = chkIsActive.Checked;
                    _selectedRow.TerminalNumber = txtTerminal.Text.Trim();
                    _selectedRow.UnitID_FK = Convert.ToInt32(cbxType.EditValue);
                    var result = await _sensorRepository.AddEditSubCounterDevice(_selectedRow);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);
                        ClearForm();
                    }
                    else
                    {
                        PublicClass.ErrorSave(Text);
                    }
                }
                else
                {
                    var model = new SubCounterDevice();
                    model.Description = txtDescription.Text.Trim();
                    model.CounterDeviceID_FK = _selectCounterDevice.ID;
                    model.IsActive = chkIsActive.Checked;
                    model.TerminalNumber = txtTerminal.Text.Trim();
                    model.UnitID_FK = Convert.ToInt32(cbxType.EditValue);
                    var result = await _sensorRepository.AddEditSubCounterDevice(model);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);
                        ClearForm();
                    }
                    else
                    {
                        PublicClass.ErrorSave(Text);
                    }
                }
                dgvSubCounterDevice.DataSource =
                        await _sensorRepository.GetSubCounterDevicesByCounterDevice(_selectCounterDevice.ID);
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }
        }

        private void gvSubCounterDevice_Click(object sender, EventArgs e)
        {
            if (gvSubCounterDevice.GetFocusedRowCellValue("ID") == null) return;
            _selectedRow = (SubCounterDevice)gvSubCounterDevice.GetFocusedRow();
            txtID.EditValue = _selectedRow.ID;
            txtDescription.EditValue = _selectedRow.Description;
            txtTerminal.EditValue = _selectedRow.TerminalNumber;
            cbxType.EditValue = _selectedRow.UnitID_FK;
            cbxCompany.EditValue = _selectedRow.CounterDevice.Applicant.CompanyID_FK;
            cbxCounterDevice.EditValue = _selectedRow.CounterDeviceID_FK;
            chkIsActive.Checked = _selectedRow.IsActive;
            txtTerminal.Focus();
            btnClose.Text = PublicClass.CancelStr;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {
                ClearForm();
            }
            else
                Close();
        }
    }
}
