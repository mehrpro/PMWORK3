using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.CodingForms
{
    public partial class RepairManForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private RepairMan SelectedRow;

        public RepairManForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();
            UpdateRepairManList();
        }

        public void UpdateRepairManList()
        {
            dgvRepaiemanList.DataSource = _codingRepository.GetAllRepairMan();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
                ClearControlers();
            else
                Close();
        }

        private void ClearControlers()
        {
            txtFullName.ResetText();
            txtJob.ResetText();
            UpdateRepairManList();
            SelectedRow = null;
            chkActive.Checked = false;
            btnClose.Text = "بستن";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate())
            {
                if (btnClose.Text == "انصراف")
                {
                    SelectedRow.Repairman_FullName = txtFullName.Text;
                    SelectedRow.RepairMan_Status = txtJob.Text.Trim();
                    SelectedRow.IsActive = Convert.ToBoolean(chkActive.CheckState);

                    var result = _codingRepository.AddRepairMan(SelectedRow);
                    if (result)
                    {
                        XtraMessageBox.Show(PublicClass.SuccessSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateRepairManList();

                    }
                    else
                    {
                        XtraMessageBox.Show(PublicClass.ErrorSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var newobj = new RepairMan()
                    {
                        IsActive = Convert.ToBoolean(chkActive.CheckState),
                        RepairMan_Status = txtJob.Text.Trim(),
                        Repairman_FullName = txtFullName.Text.Trim()
                    };
                    var result = _codingRepository.AddRepairMan(newobj);
                    if (result)
                    {
                        XtraMessageBox.Show(PublicClass.SuccessSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateRepairManList();

                    }
                    else
                    {
                        XtraMessageBox.Show(PublicClass.ErrorSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ClearControlers();
            }
            else
            {
                XtraMessageBox.Show(PublicClass.ErrorValidation, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelectedRepairMan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRepairManList.GetFocusedRowCellValue("ID") != null)
            {
                var row = gvRepairManList.GetFocusedRow();
                SelectedRow = (RepairMan)row;
                txtFullName.Text = SelectedRow.Repairman_FullName;
                txtJob.Text = SelectedRow.RepairMan_Status;
                chkActive.EditValue = SelectedRow.IsActive;

                ////btnSave.Text = "ذخی"
                btnClose.Text = "انصراف";
            }
        }
    }
}
