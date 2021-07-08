using DevExpress.XtraEditors;
using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PMWORK.MachineryForms
{
    public partial class MachineryForm : XtraForm
    {

        private AppDbContext db;
        private List<ComboBoxCoding> CodingListForComboBox;
        private ComboBoxCoding SelectedCoding;
        private ComboBoxBaseClass SelectedCompany;
        private Machinery SelectedRow;

        public MachineryForm()
        {
            InitializeComponent();
            db = PublicClass.db;
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxCompany.Properties.DataSource = db.Companies.Select(x => new ComboBoxBaseClass()
            {
                ID = x.ID,
                Title = x.CompanyTiltle,
                Tag = x.CompnayIndex.ToString()
            }).ToList();
        }


        void UpdateCodingList(int cid)
        {
            UpdateCbxCoding(cid);
            var qryMachineryList = db.Machineries.Where(x=>x.CompanyID == cid && x.IsActive && !x.IsDelete).ToList();
            foreach (var item in qryMachineryList)
            {
                var resultFind = CodingListForComboBox.SingleOrDefault(x => x.ID == item.CodeID_FK);
                if (resultFind != null)
                {
                    CodingListForComboBox.Remove(resultFind);
                }
            }            
            cbxCoding.Properties.DataSource = CodingListForComboBox;
            dgvMachineryList.DataSource = qryMachineryList;
        }


      public  void UpdateCbxCoding(int cid)
        {
            cbxCoding.Properties.DisplayMember = "Cod";
            cbxCoding.Properties.ValueMember = "ID";
            var qry = db.Codings.Include(a => a.Group).Include(a => a.SubGroup).Where(x=>x.CompanyID_FK == cid).ToList();
            CodingListForComboBox = new List<ComboBoxCoding>();
            foreach (var x in qry)
            {
                var item = new ComboBoxCoding();
                item.ID = x.ID;
                item.Cod = x.Code;
                item.Title = x.CodeTitle;
                item.Des = $"{x.Group.GroupTitle}---{x.SubGroup.SubGroupTitle}";
                CodingListForComboBox.Add(item);             
            }
            
        }


        internal void MachineryList()
        {
            dgvMachineryList.DataSource = db.Machineries.ToList();
        }

        private void cbxCompany_EditValueChanged(object sender, System.EventArgs e)
        {
            SelectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (SelectedCompany == null)
            {
                cbxCoding.EditValue = null;
                cbxCoding.Properties.DataSource = null;
                dgvMachineryList.DataSource = null;
                return;
            }
            UpdateCodingList(SelectedCompany.ID);
            
        }

        private void cbxCoding_EditValueChanged(object sender, System.EventArgs e)
        {
            SelectedCoding = (ComboBoxCoding)cbxCoding.GetSelectedDataRow();
            if (SelectedCoding == null)
            {
                txtDescription.ResetText();txtTitle.ResetText();return;
            }
            txtTitle.Text = SelectedCoding.Title;
           

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (Convert.ToBoolean(btnAdd.Tag))
            {
                var selected = db.Machineries.SingleOrDefault(x => x.ID == SelectedRow.ID);
                selected.IsActive = Convert.ToBoolean(chkActive.CheckState);
                selected.IsDelete = Convert.ToBoolean(chkDelete.CheckState);
                selected.Description = txtDescription.Text.Trim();
            }
            else
            {
                var newObj = new Machinery()
                {
                    IsActive = true,
                    IsDelete = false,
                    MachineryTitle = SelectedCoding.Title,
                    CodeID_FK = SelectedCoding.ID,
                    Description = txtDescription.Text.Trim(),
                    CompanyID = SelectedCompany.ID

                };

                db.Machineries.Add(newObj);
            }

            db.SaveChanges();
            ClearForm();
            UpdateCodingList(SelectedCompany.ID);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
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

        private void ClearForm()
        {
            cbxCompany.ReadOnly = cbxCoding.ReadOnly = false;
            txtTitle.Text = txtDescription.Text = null;
            chkActive.Checked = chkDelete.Checked = false;
            btnAdd.Text = "افزودن";
            btnClose.Text = "بستن";

        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvMachineryList.GetFocusedRowCellValue("ID") != null)
            {
                var row = gvMachineryList.GetFocusedRow();
                SelectedRow = (Machinery)row;
                txtTitle.EditValue = SelectedRow.MachineryTitle;
                txtDescription.EditValue = SelectedRow.Description;
                chkActive.EditValue = SelectedRow.IsActive;
                chkDelete.EditValue = SelectedRow.IsDelete;
                
                cbxCompany.ReadOnly= cbxCoding.ReadOnly = true;
                btnAdd.Tag = true ;
                btnAdd.Text = "ذخیره" ;
                btnClose.Text = "انصراف" ;
            }
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(chkDelete.CheckState))
            {
                chkActive.Enabled = false;
            }
            else
            {
                chkActive.Enabled = true;
            }
            
        }
    }



}
