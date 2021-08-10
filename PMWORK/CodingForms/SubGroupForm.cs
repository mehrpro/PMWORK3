using PMWORK.Entities;
using PMWORK.Repository;
using System;
using System.Linq;

namespace PMWORK.CodingForms
{
    public partial class SubGroupForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private ComboBoxBaseClass _selectCompany;
        private ComboBoxBaseClass _selectGroup;
        private SubGroup Row { get; set; }


        public SubGroupForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();

            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxGroup.Properties.DisplayMember = "Title";
            cbxGroup.Properties.ValueMember = "ID";

            cbxCompany.Properties.DataSource = _codingRepository.GetAllCompanies()
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.CompanyTitle, Tag = s.CompnayIndex.ToString() }).ToList();

            if (!PublicClass.LimitedCompany) return;
            cbxCompany.EditValue = PublicClass.CompanyID;
            cbxCompany.ReadOnly = true;

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

        private void UpdateList(int groupid)
        {
            dgvSubGroupList.DataSource = _codingRepository.GetSubGroupsByGroupId(groupid);
            gvGroup.RefreshData();
            LastGroupIndex();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
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
            UpdateList(_selectGroup.ID);
            txtGroupIndex.Text = _selectGroup.Tag;

        }

        private void ClearControlers()
        {
            txtDescription.ResetText();
            txtSubGroupTitle.ResetText();
            LastGroupIndex();
            Row = null;
            if (!PublicClass.LimitedCompany)
            {
                cbxCompany.ReadOnly = false;
            }
            cbxGroup.ReadOnly = false;
            btnClose.Text = PublicClass.CloseStr;


        }

        private void LastGroupIndex()
        {
            int last = 0;
            var qry = _codingRepository.GetSubGroupsByGroupId(_selectGroup.ID);
            if (qry.Any()) last = qry.Select(x => x.SubGroupIndex).ToArray().Max();
            numSubGroup.EditValue = last + 1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnClose.Text == PublicClass.CancelStr)
            {

                Row.SubGroupTitle = txtSubGroupTitle.Text.Trim();
                Row.Description = txtDescription.Text.Trim();
                var result = _codingRepository.AddEditSubGroup(Row);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
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
                var result = _codingRepository.AddEditSubGroup(obj);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);



            }

            UpdateList(_selectGroup.ID);
            ClearControlers();


        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvSubGroupList.GetFocusedRowCellValue("ID") == null) return;
            Row = (SubGroup)gvSubGroupList.GetFocusedRow();
            txtSubGroupTitle.EditValue = Row.SubGroupTitle;
            txtDescription.EditValue = Row.Description;
            numSubGroup.EditValue = Row.SubGroupIndex;
            cbxGroup.ReadOnly = cbxCompany.ReadOnly = true;
            btnClose.Text = PublicClass.CancelStr;
        }





    }
}
