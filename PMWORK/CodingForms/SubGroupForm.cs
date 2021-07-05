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
using DevExpress.XtraGrid.Views.Grid;

namespace PMWORK.CodingForms
{
    public partial class SubGroupForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDbContext db;
        private ComboBoxBaseClass _selectCompany;
        private ComboBoxBaseClass _selectGroup;
        private SubGroup Row { get; set; }


        public SubGroupForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxGroup.Properties.DisplayMember = "Title";
            cbxGroup.Properties.ValueMember = "ID";

            cbxCompany.Properties.DataSource = db.Companies
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.CompanyTiltle, Tag = s.CompnayIndex.ToString() }).ToList();



        }

        public void cbxGroupList(int id)
        {
            cbxGroup.Properties.DataSource = db.Groups.Where(g => g.CompanyID_FK == id)
                .Select(s => new ComboBoxBaseClass()
                {
                    ID = s.ID,
                    Title = s.GroupTitle,
                    Tag = s.GroupIndex.ToString()
                }).ToList();
        }

        private void UpdateList(int companyid, int group)
        {
            dgvSubGroupList.DataSource = db.SubGroups.Where(x => x.CompanyID_FK == companyid && x.GroupID_FK == group).ToList();
            gvGroup.RefreshData();
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

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null)
            {
                cbxGroup.EditValue = null;
                cbxGroup.Properties.DataSource = null;
                return;
            }
            cbxGroupList(_selectCompany.ID);
            txtCompanyIndex.Text = _selectCompany.Tag;

        }

        private void cbxGroup_EditValueChanged(object sender, EventArgs e)
        {

            _selectGroup = (ComboBoxBaseClass)cbxGroup.GetSelectedDataRow();
            if (_selectGroup == null)
            {
                dgvSubGroupList.DataSource = null;
                dgvSubGroupList.Refresh();
                return;
            }
            UpdateList(_selectCompany.ID, _selectGroup.ID);
            txtGroupIndex.Text = _selectGroup.Tag.ToString();

        }

        private void ClearControlers()
        {
            txtDescription.ResetText();
            txtSubGroupTitle.ResetText();
            LastGroupIndex();
            Row = null;
            cbxGroup.ReadOnly = cbxCompany.ReadOnly = false;
            btnClose.Text = "بستن";


        }

        private void LastGroupIndex()
        {
            int last = 0;
            var qry = db.SubGroups.AsNoTracking().Select(x => x.SubGroupIndex).ToList();
            if (qry.Count() > 0) last = qry.Max();
            numSubGroup.EditValue = last + 1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cbxCompany.ReadOnly && cbxGroup.ReadOnly)
            {
                var select = db.SubGroups.Find(Row.ID);
                select.SubGroupTitle = txtSubGroupTitle.Text.Trim();
                select.Description = txtDescription.Text.Trim();
            }
            else
            {
                var obj = new SubGroup
                {
                    CompanyID_FK = Convert.ToInt32(cbxCompany.EditValue),
                    GroupID_FK = Convert.ToInt32(cbxGroup.EditValue),
                    SubGroupIndex = Convert.ToByte(numSubGroup.EditValue),
                    SubGroupTitle = txtSubGroupTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                };
                db.SubGroups.Add(obj);


            }
            db.SaveChanges();
            UpdateList(_selectCompany.ID, _selectGroup.ID);
            ClearControlers();


        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvSubGroupList.GetFocusedRowCellValue("ID") != null)
            {
                var row = gvSubGroupList.GetFocusedRow();
                Row = (SubGroup)row;
                txtSubGroupTitle.EditValue = Row.SubGroupTitle;
                txtDescription.EditValue = Row.Description;
                numSubGroup.EditValue = Row.SubGroupIndex;
                cbxGroup.ReadOnly = cbxCompany.ReadOnly = true;
                btnClose.Text = "انصراف";
            }
        }



        //if (gridView2.GetFocusedRowCellValue("ID") != null)
        //{
        //    var sel = gridView2.GetFocusedRow();
        //    var idBomList = (BomList)sel;
        //    var id = idBomList.ID;
        //    bomList.Remove(idBomList);
        //    var ide = _emBoms.Single(x => x.ID == id);
        //    _emBoms.Remove(ide);
        //    dgvListBom.DataSource = bomList;
        //    gridView2.RefreshData();
        //}


    }
}
