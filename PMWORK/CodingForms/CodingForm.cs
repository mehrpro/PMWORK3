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
    public partial class CodingForm : XtraForm
    {
        private AppDbContext db;
        private ComboBoxBaseClass _selectCompany;
        private ComboBoxBaseClass _selectGroup;
        private ComboBoxBaseClass _selectSubGroup;
        private List<Coding> _MasterList;
        private Coding Row { get; set; }


        public CodingForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxGroup.Properties.DisplayMember = "Title";
            cbxGroup.Properties.ValueMember = "ID";
            cbxSubGroup.Properties.DisplayMember = "Title";
            cbxSubGroup.Properties.ValueMember = "ID";
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

        public void cbxSubGroupList(int cid, int gid)
        {
            cbxSubGroup.Properties.DataSource = db.SubGroups.Where(g => g.CompanyID_FK == cid && g.GroupID_FK == gid)
                .Select(s => new ComboBoxBaseClass()
                {
                    ID = s.ID,
                    Title = s.SubGroupTitle,
                    Tag = s.SubGroupIndex.ToString()
                }).ToList();
        }

        public void CodeList()
        {
            _MasterList = new List<Coding>();

            if (_selectCompany != null && _selectGroup != null && _selectSubGroup != null)
            {
                _MasterList = db.Codings.Where(a =>
                a.CompanyID_FK == _selectCompany.ID &&
                a.GroupID_FK == _selectGroup.ID &&
                a.SubGroupID_FK == _selectSubGroup.ID).ToList();

            }
            else if (_selectCompany != null && _selectGroup != null)
            {
                _MasterList = db.Codings.Where(a =>
                a.CompanyID_FK == _selectCompany.ID &&
                a.GroupID_FK == _selectGroup.ID).ToList();
            }
            else if (_selectCompany != null)
            {
                _MasterList = db.Codings.Where(a =>
                a.CompanyID_FK == _selectCompany.ID).ToList();
            }
            else
            {
                _MasterList = db.Codings.ToList();
            }

            dgvCodeList.DataSource = _MasterList;
            CodeBox();

        }

        private string LastNumber()
        {
            if (_MasterList.Count() > 0)
            {
                var lastNumber = _MasterList.Max(x => x.CodeIndex);
                lastNumber++;
                return lastNumber.ToString("000");
            }
            else
            {
                int firstNumber = 1;
                return firstNumber.ToString("000");
            }

        }

        private void CodeBox()
        {
            var lastNumber = "";
            string companyStr, groupStr, subgroupStr;
            companyStr = groupStr = subgroupStr = "";
            if (_selectCompany != null)
                if (Convert.ToInt32(_selectCompany.ID) > 0)
                    companyStr = Convert.ToInt32(_selectCompany.Tag).ToString();
            if (_selectGroup != null)
                if (Convert.ToInt32(_selectGroup.ID) > 0)
                    groupStr = Convert.ToInt32(_selectGroup.Tag).ToString();
            if (_selectSubGroup != null)
                if (Convert.ToInt32(_selectSubGroup.ID) > 0)
                {
                    subgroupStr = Convert.ToInt32(_selectSubGroup.Tag).ToString("00");
                    lastNumber = LastNumber();
                }
            txtCode.Text = companyStr + groupStr + subgroupStr + lastNumber;
        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null)
            {
                cbxGroup.EditValue = null;
                cbxGroup.Properties.DataSource = null;
                cbxSubGroup.EditValue = null;
                cbxSubGroup.Properties.DataSource = null;
                return;
            }
            cbxGroup.EditValue = null;
            cbxGroup.Properties.DataSource = null;
            cbxSubGroup.EditValue = null;
            cbxSubGroup.Properties.DataSource = null;
            cbxGroupList(_selectCompany.ID);
            CodeList();
        }

        private void cbxGroup_EditValueChanged(object sender, EventArgs e)
        {
            _selectGroup = (ComboBoxBaseClass)cbxGroup.GetSelectedDataRow();
            if (_selectGroup == null)
            {
                cbxSubGroup.EditValue = null;
                cbxSubGroup.Properties.DataSource = null;
                return;
            }
            cbxSubGroupList(_selectCompany.ID, _selectGroup.ID); CodeList();
        }

        private void cbxSubGroup_EditValueChanged(object sender, EventArgs e)
        {
            _selectSubGroup = (ComboBoxBaseClass)cbxSubGroup.GetSelectedDataRow();
            if (_selectGroup == null)
            {
                return;
            }
            cbxSubGroupList(_selectCompany.ID, _selectGroup.ID);
            ///
            CodeList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Tag.ToString() == "cansel")
            {
                btnClose.Tag = "Close";
                btnClose.Text = "بستن";
                ClearForm();

            }
            else
                Close();
        }

        private void ClearForm()
        {
            txtCodeTitle.ResetText();
            txtDescription.ResetText();
            Row = null;
            cbxCompany.ReadOnly = cbxGroup.ReadOnly = cbxSubGroup.ReadOnly = false;


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnClose.Tag.ToString() == "cansel")
            {
                var select = db.Codings.Find(Row.ID);
                select.CodeTitle = txtCodeTitle.Text.Trim();
                select.Description = txtCodeTitle.Text.Trim();
            }
            else
            {
                var obj = new Coding()
                {
                    CompanyID_FK = _selectCompany.ID,
                    GroupID_FK = _selectGroup.ID,
                    SubGroupID_FK = _selectSubGroup.ID,
                    UserID_FK = PublicClass.UserID,
                    Code = Convert.ToInt32(txtCode.Text.Trim()),
                    CodeIndex = Convert.ToInt16(txtCode.Text.Remove(0, 4)),
                    Description = txtDescription.Text.Trim(),
                    CodeTitle = txtCodeTitle.Text.Trim(),
                };
                db.Codings.Add(obj);
            }
            db.SaveChanges();
            CodeList();
            ClearForm();



        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvCodeList.GetFocusedRowCellValue("ID") != null)
            {
                var row = gvCodeList.GetFocusedRow();
                Row = (Coding)row;
                txtCodeTitle.EditValue = Row.CodeTitle;
                txtDescription.EditValue = Row.Description;
                txtCode.EditValue = Row.Code;
                cbxGroup.ReadOnly = cbxCompany.ReadOnly = cbxSubGroup.ReadOnly = true;
                btnClose.Text = "انصراف";
                btnClose.Tag = "cansel";
            }
        }
    }
}
