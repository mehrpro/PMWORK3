using DevExpress.XtraEditors;
using PMWORK.Entities;
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

namespace PMWORK.PMForms
{
    public partial class PowerElectricalForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private int machineryID;
        private string machineryName;
        private string code;
        private PowerElectricalMachinery SelectedRow;

        public int MachineryID { get => machineryID; set => machineryID = value; }
        public string MachineryName { get => machineryName; set => machineryName = value; }
        public string Code { get => code; set => code = value; }

        public PowerElectricalForm(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
        }

        private void UpdatePowerList()
        {
            dgvPowerList.DataSource = _codingRepository.GetPowerListByMachineryId(machineryID);
        }

        private void PowerElectricalForm_Load(object sender, EventArgs e)
        {
            UpdatePowerList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                if (btnClose.Text == PublicClass.CancelStr)
                {

                    SelectedRow.Amper = txtAmper.Text.Trim();
                    SelectedRow.Voltag = txtVoltag.Text.Trim();
                    SelectedRow.RPM = Convert.ToInt32(numRPM.EditValue);
                    SelectedRow.IsDelete = false;
                    SelectedRow.KW = txtKW.Text.Trim();
                    SelectedRow.MachineryID_FK = machineryID;
                    SelectedRow.Title = txtTitle.Text.Trim();
                    SelectedRow.Manifactor = txtManiFactory.Text.Trim();
                    var result = _codingRepository.AddPowerElectrical(SelectedRow);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);

                    }
                    else
                        PublicClass.ErrorSave(Text);
                }
                else
                {
                    var obj = new PowerElectricalMachinery();
                    obj.Amper = txtAmper.Text.Trim();
                    obj.Voltag = txtVoltag.Text.Trim();
                    obj.RPM = Convert.ToInt32(numRPM.EditValue);
                    obj.IsDelete = false;
                    obj.KW = txtKW.Text.Trim();
                    obj.MachineryID_FK = machineryID;
                    obj.Title = txtTitle.Text.Trim();
                    obj.Manifactor = txtManiFactory.Text.Trim();
                    var result = _codingRepository.AddPowerElectrical(obj);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);

                    }
                    else
                        PublicClass.ErrorSave(Text);

                }
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {

            }
            else
            {
                Close();
            }
        }
    }
}
