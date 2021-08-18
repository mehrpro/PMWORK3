using DevExpress.XtraEditors;
using PMWORK.Repository;
using System;
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

        private void IdentityMachineryForm_Load(object sender, EventArgs e)
        {

        }

        private async void SetForm(int machinery)
        {
            _identityMachinery = await _deviceIdentity.GetIdentityMachineryByMachineryId(machinery);

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
            _identityMachinery = new IdentityMachinery
            {

                MachinerID_FK = machineryID,
                TypeDevice = txtTypeDevice.Text.Trim(),
                dateTimeImport = datTimeImport.DateTime.Date,
                dateTimeStart = datTimeStart.DateTime.Date,
                dateStartWaranty = datStartWaranty.DateTime.Date,
                dateEndWaranty = datEndWaranty.DateTime.Date,
                Calibration = Convert.ToBoolean(chkCalibration.EditValue),
                NewDivice = Convert.ToBoolean(chkNewDevice.EditValue),
                Length = Convert.ToInt32(numLenght.EditValue),
                Width = Convert.ToInt32(numWidth.EditValue),
                Height = Convert.ToInt32(numHeight.EditValue),
                Wight = Convert.ToInt32(numWight.EditValue),
                Company = txtCompany.Text.Trim(),
                Countery = txtCountery.Text.Trim(),
                CompanyAddress = txtCompanyAddress.Text.Trim(),
                CompanyTel = txtCompanyTel.Text.Trim(),
                CompanyFax = txtCompanyFax.Text.Trim(),
                SupplyName = txtSupplyName.Text.Trim(),
                SupplyAddress = txtSuppluAddress.Text.Trim(),
                SupplyTel = txtSupplyTel.Text.Trim(),
                SupplyFax = txtSupplyFax.Text.Trim(),
                CalibrationCompany = txtCalibCompany.Text.Trim(),
                CalibrationAddress = txtCalibAddress.Text.Trim(),
                CalibrationTel = txtCalibTel.Text.Trim(),
                CalibrationFax = txtCalibFax.Text.Trim()
            };
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
