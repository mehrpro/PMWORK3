using DevExpress.XtraEditors;
using System;
using PMWORK.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PMWORK.Repository;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK.Admin
{
    public partial class UsersForm : XtraForm
    {
        private readonly IRequestRepairRepository _repairRepository;
        private readonly ICodingRepository _codingRepository;
        private ComboBoxBaseClass selectedCompany;
        private ApplicationUser Selected;

        public UsersForm(IRequestRepairRepository repairRepository,ICodingRepository codingRepository)
        {
            InitializeComponent();
            _repairRepository = repairRepository;
            _codingRepository = codingRepository;
            cbxCompany.Properties.DataSource = _repairRepository.GetAllCompanies();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                ClearForm();

            }else
            Close();
        }

            private void ClearForm()
        {
            btnClose.Text = "بستن";
            txtFullname.ResetText();
            txtPassword.ResetText();
            txtUsername.ResetText();
            cbxCompany.EditValue = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                var newobj = new ApplicationUser()
                {
                    CompanyID_FK = selectedCompany.ID,
                    UserName = txtUsername.Text.Trim(),
                    FullName = txtPassword.Text.Trim(),
                    Enabled = true,
                    UserPassword = txtPassword.Text.Trim(),                    
                };
                var result = _codingRepository.AddUsers(newobj);
                if (result)
                {
                 PublicClass.SuccessMessage( Text);
                }
            }
            else
            {
                PublicClass.ErrorValidationMessage( Text);
            }
        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            selectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (selectedCompany == null) return;
            
            
        }

        private void btnSelectedRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvUsersList.GetFocusedRowCellValue("ID") != null)
            {
                 Selected = (ApplicationUser)gvUsersList.GetFocusedRow();
                txtFullname.Text = Selected.FullName;
                txtUsername.Text = Selected.UserName;
                txtPassword.Text = Selected.UserPassword;
                cbxCompany.EditValue = Selected.CompanyID_FK;
                btnClose.Text = "انصراف";
            }
        }
    }
}
