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
            txtMachineryID.EditValue = machineryID;
            txtMachineryName.EditValue = machineryName;
            txtCode.EditValue = code;
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
                        ClearForm();
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
                        ClearForm();
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


        void ClearForm()
        {
            txtAmper.ResetText();
            txtKW.ResetText();
            txtTitle.ResetText();
            txtManiFactory.ResetText();
            txtKW.ResetText();
            txtVoltag.ResetText();
            numRPM.EditValue = 0;
            SelectedRow = null;
            txtTitle.Focus();
            btnClose.Text = PublicClass.CloseStr;
            UpdatePowerList();
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

        private void btnSelected_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvPowerList.GetFocusedRowCellValue("ID") == null) return;
            SelectedRow = (PowerElectricalMachinery)gvPowerList.GetFocusedRow();
            txtAmper.Text = SelectedRow.Amper ;
            txtVoltag.Text = SelectedRow.Voltag ;
            numRPM.EditValue = SelectedRow.RPM ;
            txtKW.Text = SelectedRow.KW ;
            txtTitle.Text = SelectedRow.Title ;
            txtManiFactory.Text = SelectedRow.Manifactor ;
            btnClose.Text = PublicClass.CancelStr;
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
            {
            if (gvPowerList.GetFocusedRowCellValue("ID") == null) return;
            var selectedDelte = (PowerElectricalMachinery)gvPowerList.GetFocusedRow();
            var dialogResult = XtraMessageBox.Show("از حذف این ردیف مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
                {
                _codingRepository.DeletePowerElectrical(selectedDelte.ID);
                UpdatePowerList();
                }
            else
                {
                return;
                }
            }
        }
}
