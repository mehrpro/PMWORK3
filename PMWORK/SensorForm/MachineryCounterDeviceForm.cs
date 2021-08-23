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
    public partial class MachineryCounterDeviceForm : XtraForm
    {
        private readonly ISensorRepository _sensorRepository;
        private CounterDevice _selectCounterDevice;
        private Company _selectComapany;
        private SubCounterDevice _selectTerminal;
        private MachineryCounterDevice _selectedRow;
        private Machinery _selectMachinery;

        public MachineryCounterDeviceForm(ISensorRepository sensorRepository)
        {
            InitializeComponent();
            _sensorRepository = sensorRepository;

            cbxCounterDevice.Properties.DisplayMember = "CounterTitle";
            cbxCounterDevice.Properties.ValueMember = "ID";

            cbxCompany.Properties.DisplayMember = "CompanyTitle";
            cbxCompany.Properties.ValueMember = "ID";


            cbxTerminal.Properties.DisplayMember = "TerminalNumber";
            cbxTerminal.Properties.ValueMember = "ID";

            cbxMachineryList.Properties.DisplayMember = "Coding.Code";
            cbxMachineryList.Properties.ValueMember = "ID";

        }

        private async void MachineryCounterDeviceForm_Load(object sender, EventArgs e)
        {
            cbxCompany.Properties.DataSource = await _sensorRepository.GetAllCompany();

        }

        private async void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectComapany = (Company)cbxCompany.GetSelectedDataRow();
            if (_selectComapany == null)
            {
                cbxCounterDevice.Properties.DataSource = null;
                return;
            }
            cbxCounterDevice.Properties.DataSource =
                await _sensorRepository.GetCounterDevicesByCompanyId(_selectComapany.ID);

        }

        private async void UpdateList()
        {
            dgvMachineryCounter.DataSource = await _sensorRepository.GetMachineryCounterDevicesByCounterDevice(_selectCounterDevice.ID);
        }

        private async void cbxCounterDevice_EditValueChanged(object sender, EventArgs e)
        {
            _selectCounterDevice = (CounterDevice)cbxCounterDevice.GetSelectedDataRow();
            if (_selectCounterDevice == null)
            {
                cbxTerminal.Properties.DataSource = null;
                return;
            }
            cbxTerminal.Properties.DataSource =
                await _sensorRepository.GetSubCounterDevicesByCounterDevice(_selectCounterDevice.ID);
            cbxMachineryList.Properties.DataSource =
                await _sensorRepository.GetMachineriesByApplicantId(_selectCounterDevice.ApplicatinID_FK);
            UpdateList();
        }

        private  void cbxTerminal_EditValueChanged(object sender, EventArgs e)
        {
            _selectTerminal = (SubCounterDevice)cbxTerminal.GetSelectedDataRow();
            if (_selectTerminal == null)
            {
                return;
            }


        }

        private void ClearForm()
        {
            btnClose.Text = PublicClass.CloseStr;
            cbxTerminal.EditValue = 0;
            cbxMachineryList.EditValue = 0;
            chkActive.Checked = true;
            txtID.Text = null;
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

        private void gvMachineryCounter_Click(object sender, EventArgs e)
        {
            if (gvMachineryCounter.GetFocusedRowCellValue("ID") == null)
            {
                return;
            }
            _selectedRow = (MachineryCounterDevice)gvMachineryCounter.GetFocusedRow();
            txtID.EditValue = _selectedRow.ID;
            cbxTerminal.EditValue = _selectedRow.SubCounterDeviceID_FK;
            cbxMachineryList.EditValue = _selectedRow.MachineryID_FK;
            cbxCounterDevice.EditValue = _selectedRow.SubCounterDevice.CounterDeviceID_FK;
            cbxCompany.EditValue = _selectedRow.Machinery.CompanyID;
            btnClose.Text = PublicClass.CancelStr;
            chkActive.Checked = _selectedRow.IsActive;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                if (btnClose.Text == PublicClass.CancelStr)
                {

                    _selectedRow.IsActive = chkActive.Checked;
                    _selectedRow.MachineryID_FK = _selectMachinery.ID;
                    _selectedRow.SubCounterDeviceID_FK = _selectTerminal.ID;
                    var result = await _sensorRepository.AddEditMachineryCounterDevice(_selectedRow);
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
                    var reultTerminal = await _sensorRepository.machineryCounterDevices(_selectTerminal.ID);
                    if (reultTerminal == null)
                    {
                        var model = new MachineryCounterDevice();
                        model.IsActive = chkActive.Checked;
                        model.MachineryID_FK = _selectMachinery.ID;
                        model.SubCounterDeviceID_FK = _selectTerminal.ID;
                        var result = await _sensorRepository.AddEditMachineryCounterDevice(model);
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
                        XtraMessageBox.Show(
                            $"ترمینال {reultTerminal.SubCounterDevice.TerminalNumber} برای دستگاه " +
                            $"{reultTerminal.Machinery.MachineryTitle} مورد استفاده قرار گرفته است!"
                            , Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                UpdateList();
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }
        }

        private void cbxMachineryList_EditValueChanged(object sender, EventArgs e)
        {
            _selectMachinery = (Machinery)cbxMachineryList.GetSelectedDataRow();
            if (_selectMachinery == null)
            {
                return;
            }
        }
    }
}
