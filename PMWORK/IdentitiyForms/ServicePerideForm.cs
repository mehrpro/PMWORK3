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
    public partial class ServicePerideForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private int machineryID;
        private string machineryName;
        private string code;
        private ServicePeriode SelectedRow;

        public int MachineryID { get => machineryID; set => machineryID = value; }
        public string MachineryName { get => machineryName; set => machineryName = value; }
        public string Code { get => code; set => code = value; }


        public ServicePerideForm(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
            cbxUnit.Properties.DisplayMember = "Unit";
            cbxUnit.Properties.ValueMember = "ID";
            cbxUnit.Properties.DataSource = _codingRepository.GetAllUnits();
        }

        private void ServicePerideForm_Load(object sender, EventArgs e)
        {
            txtMachineryID.EditValue = machineryID;
            txtMachineryName.EditValue = machineryName;
            txtCode.EditValue = code;
            UpdateServicePeriodeList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {
                btnClose.Text = PublicClass.CloseStr;
                ClearForm();
            }
            else
            {
                Close();
            }
        }

        private void ClearForm()
        {
            txtDescription.ResetText();
            txtServiceTitle.ResetText();
            numPeriode.EditValue = 0;
            cbxUnit.EditValue = null;
            SelectedRow = null;
            btnClose.Text = PublicClass.CloseStr;
        }

        private void UpdateServicePeriodeList()
        {
            dgvServiceList.DataSource = _codingRepository.GetServicePeriodesByMachineriId(machineryID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                if (btnClose.Text == PublicClass.CancelStr)
                {
                    SelectedRow.Description = txtDescription.Text.Trim();
                    SelectedRow.IsActive = chkStatus.Checked;
                    SelectedRow.MachineryID_FK = machineryID;
                    SelectedRow.Registred = DateTime.Now;
                    SelectedRow.Periode = Convert.ToInt32(numPeriode.EditValue);
                    SelectedRow.ServiceTitle = txtServiceTitle.Text.Trim();
                    SelectedRow.UnitID_FK = Convert.ToInt32(cbxUnit.EditValue);
                    var result = _codingRepository.AddServicePeriode(SelectedRow);
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
                    var obj = new ServicePeriode();
                    obj.Description = txtDescription.Text.Trim();
                    obj.IsActive = chkStatus.Checked;
                    obj.MachineryID_FK = machineryID;
                    obj.Registred = DateTime.Now;
                    obj.Periode = Convert.ToInt32(numPeriode.EditValue);
                    obj.ServiceTitle = txtServiceTitle.Text.Trim();
                    obj.UnitID_FK = Convert.ToInt32(cbxUnit.EditValue);

                    var result = _codingRepository.AddServicePeriode(obj);
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
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }
            UpdateServicePeriodeList();
        }

        private void btnSelectRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvServiceList.GetFocusedRowCellValue("ID") == null) return;
            SelectedRow = (Entities.ServicePeriode)gvServiceList.GetFocusedRow();
            txtDescription.Text = SelectedRow.Description;
            txtServiceTitle.Text = SelectedRow.ServiceTitle;
            chkStatus.Checked = SelectedRow.IsActive;
            numPeriode.EditValue = SelectedRow.Periode;
            cbxUnit.EditValue = SelectedRow.UnitID_FK;
            btnClose.Text = PublicClass.CancelStr;
        }
    }
}
