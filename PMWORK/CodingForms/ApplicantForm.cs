using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PMWORK.CodingForms
{
    public partial class ApplicantForm : XtraForm
    {

        private AppDbContext db;
        public ApplicantForm()
        {
            InitializeComponent();
            db = PublicClass.db;


            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxCompany.Properties.DataSource = db.Companies.Select(x => new ComboBoxBaseClass()
            {
                ID = x.ID,
                Title = x.CompanyTiltle,
                Tag = x.Description
            }).ToList();


        }

        private async Task UpdateApplicantList(int companyId)
        {
            dgvApplicantList.DataSource = await db.Applicants.Where(x => x.CompanyID_FK == companyId).ToListAsync();

        }


        private void ClearForm()
        {
            txtApplicantTitle.Text = txtDescription.Text = null;
          
        }

        private async void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            var SelectedCompany = (ComboBoxBaseClass) cbxCompany.GetSelectedDataRow();
            if (SelectedCompany == null)
            {
                dgvApplicantList.DataSource = null;
                return;
            }

            await UpdateApplicantList(SelectedCompany.ID);

        }
    }
}
