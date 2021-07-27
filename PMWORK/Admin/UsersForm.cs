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
            Close();
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

            }
            else
            {
                XtraMessageBox.Show(PublicClass.ErrorValidation, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            selectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (selectedCompany == null) return;
            
            
        }
    }
}
