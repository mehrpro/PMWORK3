using DevExpress.XtraEditors;
using System;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.Admin
{
    public partial class UsersForm : XtraForm
    {
        private readonly IRequestRepairRepository _repairRepository;
        private readonly ICodingRepository _codingRepository;
        private ComboBoxBaseClass selectedCompany;
        private ApplicationUser Selected;

        public UsersForm(IRequestRepairRepository repairRepository, ICodingRepository codingRepository)
        {
            InitializeComponent();
            _repairRepository = repairRepository;
            _codingRepository = codingRepository;
            cbxCompany.Properties.DataSource = _repairRepository.GetAllCompanies();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            UpdateUserList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                ClearForm();

            }
            else
                Close();
        }

        private void ClearForm()
        {
            btnClose.Text = "بستن";
            txtFullname.ResetText();
            txtPassword.ResetText();
            txtUsername.ResetText();
            cbxCompany.EditValue = 0;
            Selected = null;
            UpdateUserList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                if (Selected != null)
                {
                    Selected.FullName = txtFullname.Text.Trim();
                    Selected.UserPassword = txtPassword.Text.Trim();
                    Selected.UserName = txtUsername.Text.Trim();
                    Selected.CompanyID_FK = selectedCompany.ID;
                    Selected.Enabled = Convert.ToBoolean(chkEnabled.CheckState);
                    Selected.LimetedCompany = Convert.ToBoolean(chkLimetedCompany.CheckState);
                    Selected.Editor = cbxEditor.EditValue.ToString();
                    var result = _codingRepository.UpdateUsers(Selected);
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
                    var newobj = new ApplicationUser()
                    {
                        CompanyID_FK = selectedCompany.ID,
                        UserName = txtUsername.Text.Trim(),
                        FullName = txtFullname.Text.Trim(),
                        Enabled = true,
                        UserPassword = txtPassword.Text.Trim(),
                        Editor = cbxEditor.EditValue.ToString(),
                        LimetedCompany = chkLimetedCompany.Checked
                    };
                    var result = _codingRepository.AddUsers(newobj);
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

        private void UpdateUserList()
        {
            dgvUsersList.DataSource = _codingRepository.GetAllUsers();
        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            selectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (selectedCompany == null) return;


        }

        private void btnSelectedRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvUsersList.GetFocusedRowCellValue("UserId") != null)
            {
                Selected = (ApplicationUser)gvUsersList.GetFocusedRow();
                txtFullname.Text = Selected.FullName;
                txtUsername.Text = Selected.UserName;
                txtPassword.Text = Selected.UserPassword;
                cbxCompany.EditValue = Selected.CompanyID_FK;
                chkEnabled.Checked = Selected.Enabled;
                chkLimetedCompany.Checked = Selected.LimetedCompany;
                cbxEditor.EditValue = Selected.Editor;
                btnClose.Text = "انصراف";
            }
        }
    }
}
