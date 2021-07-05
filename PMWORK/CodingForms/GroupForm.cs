using DevExpress.XtraEditors;
using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK.CodingForms
{
    public partial class GroupForm : XtraForm
    {

        private AppDbContext db;
        private ComboBoxBaseClass _selectCompany;
        private Group SelectedRow { get; set; }
        public GroupForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxCompany.Properties.DataSource = db.Companies
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.CompanyTiltle, Tag = s.CompnayIndex.ToString() }).ToList();


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

        public void UpdateList(int id)
        {
            dgvGroupList.DataSource = db.Groups.Where(s => s.CompanyID_FK == id).ToList();
            LastGroupIndex();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cbxCompany.ReadOnly)
            {
                var select = db.Groups.Find(SelectedRow.ID);
                select.GroupTitle = txtGroupTitle.Text.Trim();
                select.Description = txtDescription.Text.Trim();
            }
            else
            {
                var obj = new Entities.Group()
                {
                    CompanyID_FK = _selectCompany.ID,
                    GroupIndex = Convert.ToByte(numGroup.EditValue),
                    GroupTitle = txtGroupTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };
                db.Groups.Add(obj);
            }
            db.SaveChanges();
            UpdateList(_selectCompany.ID);
            ClearControlers();



        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null) return;
            txtCompanyIndex.Text = _selectCompany.Tag.ToString();
            UpdateList(_selectCompany.ID);

        }

        private void ClearControlers()
        {
            txtDescription.ResetText();
            txtGroupTitle.ResetText();
            LastGroupIndex();
            SelectedRow = null;
            cbxCompany.ReadOnly = false;
            btnClose.Text = "بستن";
        }

        private void LastGroupIndex()
        {
            int last = 0;
            var qry = db.Groups.AsNoTracking().Select(x => x.GroupIndex).ToList();
            if (qry.Count() > 0) last = qry.Max();
            numGroup.EditValue = last + 1;
        }

        private void btnSelectRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvGroupList.GetFocusedRowCellValue("ID") != null)
            {
                var row = gvGroupList.GetFocusedRow();
                SelectedRow = (Group)row;
                numGroup.EditValue = SelectedRow.GroupIndex;
                txtGroupTitle.EditValue = SelectedRow.GroupTitle;
                txtDescription.EditValue = SelectedRow.Description;
                cbxCompany.ReadOnly = true;
                btnClose.Text = "انصراف";
            }
        }
    }
}
