using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;
using System;
using System.Linq;

namespace PMWORK.CodingForms
{
    public partial class GroupForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;

        private ComboBoxBaseClass _selectCompany;
        private Group SelectedRow { get; set; }
        public GroupForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxCompany.Properties.DataSource = _codingRepository.GetAllCompanies()
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.CompanyTitle, Tag = s.CompnayIndex.ToString() }).ToList();

            if (!PublicClass.LimitedCompany) return;
            cbxCompany.EditValue = PublicClass.CompanyID;
            cbxCompany.ReadOnly = true;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
                ClearControlers();
            else
                Close();
        }

        public void UpdateList(int id)
        {
            dgvGroupList.DataSource = _codingRepository.GetGroupsByCompanyId(id);
            LastGroupIndex();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnClose.Text == PublicClass.CancelStr)
            {
                //var select = db.Groups.Find(SelectedRow.ID);
                SelectedRow.GroupTitle = txtGroupTitle.Text.Trim();
                SelectedRow.Description = txtDescription.Text.Trim();
                var result = _codingRepository.AddEditGroup(SelectedRow);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }
            else
            {
                var obj = new Group()
                {
                    CompanyID_FK = _selectCompany.ID,
                    GroupIndex = Convert.ToByte(numGroup.EditValue),
                    GroupTitle = txtGroupTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };
                var result = _codingRepository.AddEditGroup(obj);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }

            UpdateList(_selectCompany.ID);
            ClearControlers();
        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null) return;
            txtCompanyIndex.Text = _selectCompany.Tag;
            UpdateList(_selectCompany.ID);

        }

        private void ClearControlers()
        {
            txtDescription.ResetText();
            txtGroupTitle.ResetText();
            LastGroupIndex();
            SelectedRow = null;
            if (!PublicClass.LimitedCompany)
            {
                cbxCompany.ReadOnly = false;

            }
            btnClose.Text = PublicClass.CloseStr;
        }

        private void LastGroupIndex()
        {
            int last = 0;
            var qry = _codingRepository.GetGroupsByCompanyId(_selectCompany.ID);
            if (qry.Any()) last = qry.Select(x => x.GroupIndex).ToArray().Max();
            numGroup.EditValue = last + 1;
        }

        private void btnSelectRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvGroupList.GetFocusedRowCellValue("ID") == null) return;
            SelectedRow = (Group)gvGroupList.GetFocusedRow();
            numGroup.EditValue = SelectedRow.GroupIndex;
            txtGroupTitle.EditValue = SelectedRow.GroupTitle;
            txtDescription.EditValue = SelectedRow.Description;
            cbxCompany.ReadOnly = true;
            btnClose.Text = PublicClass.CancelStr;
        }
    }
}
