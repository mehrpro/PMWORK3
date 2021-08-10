using PMWORK.Entities;
using System;
using System.Linq;
using PMWORK.Repository;

namespace PMWORK.CodingForms
{
    public partial class CompaniesForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private Company SelectRow { get; set; }

        public CompaniesForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();

            UpdateList();
        }

        private void UpdateList()
        {
            dgvCompany.DataSource = _codingRepository.GetAllCompanies();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {

                SelectRow.CompanyTitle = txtCompanyTitle.Text.Trim();
                SelectRow.Description = txtDescription.Text.Trim();
                var result = _codingRepository.AddEditCompnay(SelectRow);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }
            else
            {
                var obj = new Company();
                obj.CompnayIndex = Convert.ToByte(numCompanyIndex.EditValue);
                obj.CompanyTitle = txtCompanyTitle.EditValue.ToString().Trim();
                obj.Description = txtDescription.Text.Trim();
                var result = _codingRepository.AddEditCompnay(obj);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }
            UpdateList();
            ClearControlers();

        }

        private void ClearControlers()
        {
            txtDescription.ResetText();
            txtCompanyTitle.ResetText();
            LastGroupIndex();
            SelectRow = null;
            btnClose.Text = PublicClass.CloseStr;
        }


        private void LastGroupIndex()
        {
            int last = 0;
            var qry = _codingRepository.GetAllCompanies();
            if (qry.Any()) last = _codingRepository.GetAllCompanies().Select(x => x.CompnayIndex).ToArray().Max();
            numCompanyIndex.EditValue = last + 1;
        }

        private void btnSelectRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvCompany.GetFocusedRowCellValue("ID") == null) return;
            SelectRow = (Company)gvCompany.GetFocusedRow();
            numCompanyIndex.EditValue = SelectRow.CompnayIndex;
            txtCompanyTitle.EditValue = SelectRow.CompanyTitle;
            txtDescription.EditValue = SelectRow.Description;
            btnClose.Text = PublicClass.CancelStr;
        }
    }
}
