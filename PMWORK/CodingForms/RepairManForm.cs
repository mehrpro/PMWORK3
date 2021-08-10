using System;
using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.CodingForms
{
    public partial class RepairManForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private RepairMan _selectedRow;

        public RepairManForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();
            UpdateRepairManList();
        }

        private void UpdateRepairManList()
        {
            dgvRepaiemanList.DataSource = _codingRepository.GetAllRepairMan();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
                ClearControlers();
            else
                Close();
        }

        private void ClearControlers()
        {
            txtFullName.ResetText();
            txtJob.ResetText();
            UpdateRepairManList();
            _selectedRow = null;
            chkActive.Checked = false;
            btnClose.Text = PublicClass.CloseStr;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate())
            {
                if (btnClose.Text == PublicClass.CancelStr)
                {
                    _selectedRow.Repairman_FullName = txtFullName.Text;
                    _selectedRow.RepairMan_Status = txtJob.Text.Trim();
                    _selectedRow.IsActive = Convert.ToBoolean(chkActive.CheckState);
                    var result = _codingRepository.AddRepairMan(_selectedRow);
                    if (result)
                        PublicClass.SuccessMessage(Text);
                    else
                        PublicClass.ErrorSave(Text);
                }
                else
                {
                    var model = new RepairMan()
                    {
                        IsActive = Convert.ToBoolean(chkActive.CheckState),
                        RepairMan_Status = txtJob.Text.Trim(),
                        Repairman_FullName = txtFullName.Text.Trim()
                    };
                    var result = _codingRepository.AddRepairMan(model);
                    if (result)
                        PublicClass.SuccessMessage(Text);
                    else
                        PublicClass.ErrorSave(Text);
                }
                UpdateRepairManList();
                ClearControlers();
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }
        }

        private void btnSelectedRepairMan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRepairManList.GetFocusedRowCellValue("ID") == null) return;
            var row = gvRepairManList.GetFocusedRow();
            _selectedRow = (RepairMan)row;
            txtFullName.Text = _selectedRow.Repairman_FullName;
            txtJob.Text = _selectedRow.RepairMan_Status;
            chkActive.EditValue = _selectedRow.IsActive;
            btnClose.Text = PublicClass.CancelStr;
        }
    }
}
