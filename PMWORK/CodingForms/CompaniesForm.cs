using PMWORK.Entities;
using System;
using System.Data;
using System.Linq;

namespace PMWORK.CodingForms
{
    public partial class CompaniesForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDbContext db;
        private Company Row { get; set; }

        public CompaniesForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            UpdateList();
        }

        public void UpdateList()
        {
            dgvCompany.DataSource = db.Companies.AsNoTracking().ToList();
            LastGroupIndex();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                ClearControlers();
            }
            else
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                var select = db.Companies.Find(Row.ID);
                select.CompanyTiltle = txtCompanyTitle.Text.Trim();
                select.Description = txtDescription.Text.Trim();
            }
            else
            {
                var obj = new Company();
                obj.CompnayIndex = Convert.ToByte(numCompanyIndex.EditValue);
                obj.CompanyTiltle = txtCompanyTitle.EditValue.ToString().Trim();
                obj.Description = txtDescription.Text.ToString().Trim();
                db.Companies.Add(obj);
            }
            db.SaveChanges();
            UpdateList();
            ClearControlers();

        }

        private void ClearControlers()
        {
            txtDescription.ResetText();
            txtCompanyTitle.ResetText();
            LastGroupIndex();
            Row = null;
            btnClose.Text = "بستن";
        }


        private void LastGroupIndex()
        {
            int last = 0;
            var qry = db.Companies.AsNoTracking().Select(x => x.CompnayIndex).ToArray();
            if (qry != null) last = qry.Max();
            numCompanyIndex.EditValue = last + 1;
        }

        private void btnSelectRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvCompany.GetFocusedRowCellValue("ID") != null)
            {
                var row = gvCompany.GetFocusedRow();
                Row = (Company)row;
                numCompanyIndex.EditValue = Row.CompnayIndex;
                txtCompanyTitle.EditValue = Row.CompanyTiltle;
                txtDescription.EditValue = Row.Description;
                btnClose.Text = "انصراف";
            }
        }
    }
}
