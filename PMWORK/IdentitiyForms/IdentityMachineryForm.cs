using DevExpress.XtraEditors;
using PMWORK.Repository;
using System;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using DevExpress.Utils.Extensions;
using PMWORK.Entities;

namespace PMWORK.PMForms
{
    public partial class IdentityMachineryForm : XtraForm
    {
        private readonly IDeviceIdentity _deviceIdentity;

        private int machineryID;
        private string machineryName;
        private string code;
        private IdentityMachinery _identityMachinery;




        public int MachineryID { get => machineryID; set => machineryID = value; }
        public string MachineryName { get => machineryName; set => machineryName = value; }
        public string Code { get => code; set => code = value; }
        public IdentityMachineryForm(IDeviceIdentity deviceIdentity)
        {
            _deviceIdentity = deviceIdentity;
            InitializeComponent();

        }

        private async void IdentityMachineryForm_Load(object sender, EventArgs e)
        {
            await SetForm(machineryID);
            txtMachineryName.EditValue = machineryName;
            txtMachineryID.EditValue = machineryID;
            txtCode.EditValue = code;
            datEndWaranty.DateTime = datStartWaranty.DateTime =
                datTimeImport.DateTime = datTimeStart.DateTime = DateTime.Today;
        }

        private async Task SetForm(int machinery)
        {
            _identityMachinery = await _deviceIdentity.GetIdentityMachineryByMachineryId(machinery);
            if (_identityMachinery == null)
            {
                _identityMachinery=new IdentityMachinery();
                return;
            };
            txtTypeDevice.Text = _identityMachinery.TypeDevice;
            datTimeImport.DateTime = _identityMachinery.dateTimeImport.Date;
            datTimeStart.DateTime = _identityMachinery.dateTimeStart.Date;
            datStartWaranty.DateTime = _identityMachinery.dateStartWaranty.Date;
            datEndWaranty.DateTime = _identityMachinery.dateEndWaranty.Date;
            chkCalibration.EditValue = _identityMachinery.Calibration;
            chkNewDevice.EditValue = _identityMachinery.NewDivice;
            numLenght.EditValue = _identityMachinery.Length;
            numHeight.EditValue = _identityMachinery.Height;
            numWidth.EditValue = _identityMachinery.Width;
            numWight.EditValue = _identityMachinery.Wight;
            txtCompany.EditValue = _identityMachinery.Company;
            txtCountery.EditValue = _identityMachinery.Countery;
            txtCompanyAddress.EditValue = _identityMachinery.CompanyAddress;
            txtCompanyTel.EditValue = _identityMachinery.CompanyTel;
            txtCompanyFax.EditValue = _identityMachinery.CompanyFax;
            txtSupplyName.EditValue = _identityMachinery.SupplyName;
            txtSuppluAddress.EditValue = _identityMachinery.SupplyAddress;
            txtSupplyFax.EditValue = _identityMachinery.SupplyFax;
            txtSupplyTel.EditValue = _identityMachinery.SupplyTel;
            txtCalibCompany.EditValue = _identityMachinery.CalibrationCompany;
            txtCalibAddress.EditValue = _identityMachinery.CalibrationAddress;
            txtCalibTel.EditValue = _identityMachinery.CalibrationTel;
            txtCalibFax.EditValue = _identityMachinery.CalibrationFax;

        }

        private void GetForm()
        {

            _identityMachinery.MachinerID_FK = machineryID;
            _identityMachinery.TypeDevice = txtTypeDevice.Text.Trim();
            _identityMachinery.dateTimeImport = datTimeImport.DateTime.Date;
            _identityMachinery.dateTimeStart = datTimeStart.DateTime.Date;
            _identityMachinery.dateStartWaranty = datStartWaranty.DateTime.Date;
            _identityMachinery.dateEndWaranty = datEndWaranty.DateTime.Date;
            _identityMachinery.Calibration = Convert.ToBoolean(chkCalibration.EditValue);
            _identityMachinery.NewDivice = Convert.ToBoolean(chkNewDevice.EditValue);
            _identityMachinery.Length = Convert.ToInt32(numLenght.EditValue);
            _identityMachinery.Width = Convert.ToInt32(numWidth.EditValue);
            _identityMachinery.Height = Convert.ToInt32(numHeight.EditValue);
            _identityMachinery.Wight = Convert.ToInt32(numWight.EditValue);
            _identityMachinery.Company = txtCompany.Text.Trim();
            _identityMachinery.Countery = txtCountery.Text.Trim();
            _identityMachinery.CompanyAddress = txtCompanyAddress.Text.Trim();
            _identityMachinery.CompanyTel = txtCompanyTel.Text.Trim();
            _identityMachinery.CompanyFax = txtCompanyFax.Text.Trim();
            _identityMachinery.SupplyName = txtSupplyName.Text.Trim();
            _identityMachinery.SupplyAddress = txtSuppluAddress.Text.Trim();
            _identityMachinery.SupplyTel = txtSupplyTel.Text.Trim();
            _identityMachinery.SupplyFax = txtSupplyFax.Text.Trim();
            _identityMachinery.CalibrationCompany = txtCalibCompany.Text.Trim();
            _identityMachinery.CalibrationAddress = txtCalibAddress.Text.Trim();
            _identityMachinery.CalibrationTel = txtCalibTel.Text.Trim();
            _identityMachinery.CalibrationFax = txtCalibFax.Text.Trim();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            GetForm();
            var result = await _deviceIdentity.AddEditIdentityMachinery(_identityMachinery);
            if (result)
            {
                PublicClass.SuccessMessage(Text);
                Close();
            }
            else
            {
                PublicClass.ErrorSave(Text);
            }
        }

        private void chkCalibration_Toggled(object sender, EventArgs e)
        {
            var se = (ToggleSwitch)sender;
            txtCalibTel.Enabled = txtCalibAddress.Enabled = txtCalibCompany.Enabled = txtCalibFax.Enabled = se.IsOn;
            txtCalibTel.Text = txtCalibAddress.Text = txtCalibCompany.Text = txtCalibFax.Text = null;
        }
    }
}
