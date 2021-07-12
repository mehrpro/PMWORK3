using PMWORK.Entities;
using System;
using System.Linq;

namespace PMWORK.CodingForms
{
    public partial class UnitForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDbContext db;
        private UnitOfMeasurement Row { get; set; }

        public UnitForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            UpdateList();
        }

        public void UpdateList()
        {
            dgvUnit.DataSource = db.UnitOfMeasurements.ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                ClearControlers();
            }
            else
                Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                var select = db.UnitOfMeasurements.Find(Row.ID);
                select.Unit = txtUnitTitle.Text.Trim();
                select.Description = txtDescription.Text.Trim();
            }
            else
            {
                var obj = new UnitOfMeasurement()
                {
                    Unit = txtUnitTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };
                db.UnitOfMeasurements.Add(obj);
            }
            db.SaveChanges();
            UpdateList();
            ClearControlers();

        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvUnit.GetFocusedRowCellValue("ID") != null)
            {
                var row = gvUnit.GetFocusedRow();
                Row = (UnitOfMeasurement)row;
                txtUnitTitle.EditValue = Row.Unit;
                txtDescription.EditValue = Row.Description;
                btnClose.Text = "انصراف";
            }
        }
        private void ClearControlers()
        {
            txtDescription.ResetText();
            txtUnitTitle.ResetText();
            Row = null;

            btnClose.Text = "بستن";
        }
    }
}
