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
using PMWORK.Entities;

namespace PMWORK.CodingForms
{
    public partial class ApplicantForm : XtraForm
    {

        private AppDbContext db;
        private Applicant selectApplicant;
        private ComboBoxBaseClass SelectedCompany;

        public ApplicantForm()
        {
            InitializeComponent();
            db = new AppDbContext();


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
            cbxCompany.ReadOnly = false;
            txtApplicantTitle.Text = txtDescription.Text = null;
            btnClose.Text = "بستن";

        }

        private async void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            SelectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (SelectedCompany == null)
            {
                dgvApplicantList.DataSource = null;
                return;
            }

            await UpdateApplicantList(SelectedCompany.ID);

        }

        private void btnSelectRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvApplicantList.GetFocusedRowCellValue("ID") != null)
            {
                selectApplicant = (Applicant)gvApplicantList.GetFocusedRow();
                txtApplicantTitle.Text = selectApplicant.ApplicantTitle;
                txtDescription.Text = selectApplicant.Description;
                cbxCompany.ReadOnly = true;
                btnClose.Text = "انصراف";

            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                var select = db.Applicants.Find(selectApplicant.ID);
                select.ApplicantTitle = txtApplicantTitle.Text.Trim();
                select.Description = txtDescription.Text.Trim();

            }
            else
            {
                var obj = new Applicant
                {
                    ApplicantTitle = txtApplicantTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    CompanyID_FK = Convert.ToInt32(cbxCompany.EditValue)
                };
                db.Applicants.Add(obj);
            }

            await db.SaveChangesAsync();
            await UpdateApplicantList(SelectedCompany.ID);
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                ClearForm();
            }
            else
            {
                Close();
            }
        }
    }
}
