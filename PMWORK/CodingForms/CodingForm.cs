using DevExpress.XtraEditors;
using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using PMWORK.Repository;

namespace PMWORK.CodingForms
{
    public partial class CodingForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private ComboBoxBaseClass _selectCompany;
        private ComboBoxBaseClass _selectGroup;
        private ComboBoxBaseClass _selectSubGroup;
        private List<Coding> _masterList;
        private Coding SelectRow { get; set; }


        public CodingForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();

            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxGroup.Properties.DisplayMember = "Title";
            cbxGroup.Properties.ValueMember = "ID";
            cbxSubGroup.Properties.DisplayMember = "Title";
            cbxSubGroup.Properties.ValueMember = "ID";
            cbxCompany.Properties.DataSource = _codingRepository.GetAllCompanies()
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.CompanyTitle, Tag = s.CompnayIndex.ToString() }).ToList();
            if (PublicClass.LimitedCompany)
            {
                cbxCompany.EditValue = PublicClass.CompanyID;
                cbxCompany.ReadOnly = true;
            }
        }

        private void cbxGroupList(int id)
        {
            cbxGroup.Properties.DataSource = _codingRepository.GetGroupsByCompanyId(id)
                .Select(s => new ComboBoxBaseClass()
                {
                    ID = s.ID,
                    Title = s.GroupTitle,
                    Tag = s.GroupIndex.ToString()
                }).ToList();
        }

        private void cbxSubGroupList(int gid)
        {
            cbxSubGroup.Properties.DataSource = _codingRepository.GetSubGroupsByGroupId(gid)
                .Select(s => new ComboBoxBaseClass()
                {
                    ID = s.ID,
                    Title = s.SubGroupTitle,
                    Tag = s.SubGroupIndex.ToString()
                }).ToList();
        }

        private void CodeList()
        {
            _masterList = new List<Coding>();

            if (_selectCompany != null && _selectGroup != null && _selectSubGroup != null)
                _masterList = _codingRepository.GetCodingsBy(_selectCompany.ID, _selectGroup.ID, _selectSubGroup.ID);
            else if (_selectCompany != null && _selectGroup != null)
                _masterList = _codingRepository.GetCodingsBy(_selectCompany.ID, _selectGroup.ID);
            else if (_selectCompany != null)
                _masterList = _codingRepository.GetCodingsBy(_selectCompany.ID);
            else
                _masterList = _codingRepository.GetCodingsBy();

            dgvCodeList.DataSource = _masterList;
            CodeBox();

        }

        private string LastNumber()
        {
            if (_masterList.Any())
            {
                var lastNumber = _masterList.Max(x => x.CodeIndex);
                lastNumber++;
                return lastNumber.ToString("000");
            }
            int firstNumber = 1;
            return firstNumber.ToString("000");

        }

        private void CodeBox()
        {
            var lastNumber = "";
            string groupStr, subgroupStr;
            var companyStr = groupStr = subgroupStr = "";
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
            cbxSubGroupList(_selectGroup.ID);
            CodeList();
        }

        private void cbxSubGroup_EditValueChanged(object sender, EventArgs e)
        {
            _selectSubGroup = (ComboBoxBaseClass)cbxSubGroup.GetSelectedDataRow();
            if (_selectGroup == null)
            {
                return;
            }

            CodeList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {
                btnClose.Text = PublicClass.CloseStr;
                ClearForm();

            }
            else
                Close();
        }

        private void ClearForm()
        {
            txtCodeTitle.ResetText();
            txtDescription.ResetText();
            SelectRow = null;
            if (!PublicClass.LimitedCompany) cbxCompany.ReadOnly = false;
            cbxGroup.ReadOnly = cbxSubGroup.ReadOnly = false;


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {

                SelectRow.CodeTitle = txtCodeTitle.Text.Trim();
                SelectRow.Description = txtCodeTitle.Text.Trim();
                var result = _codingRepository.AddEditCoding(SelectRow);
                if (result)
                {
                    PublicClass.SuccessMessage(Text);
                }
                else
                {
                    PublicClass.ErrorSave(Text);
                }
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
                var result = _codingRepository.AddEditCoding(obj);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }

            CodeList();
            ClearForm();



        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvCodeList.GetFocusedRowCellValue("ID") != null)
            {

                SelectRow = (Coding)gvCodeList.GetFocusedRow();
                txtCodeTitle.EditValue = SelectRow.CodeTitle;
                txtDescription.EditValue = SelectRow.Description;
                txtCode.EditValue = SelectRow.Code;
                cbxGroup.ReadOnly = cbxCompany.ReadOnly = cbxSubGroup.ReadOnly = true;
                btnClose.Text = PublicClass.CancelStr;
            }
        }
    }
}
