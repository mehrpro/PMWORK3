using PMWORK.Entities;
using PMWORK.Repository;
using System;

namespace PMWORK.CodingForms
{
    public partial class UnitForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICodingRepository _codingRepository;

        private UnitOfMeasurement Row { get; set; }

        public UnitForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            dgvUnit.DataSource = _codingRepository.GetAllUnits();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {
                ClearControlers();
            }
            else
                Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {

                Row.Unit = txtUnitTitle.Text.Trim();
                Row.Description = txtDescription.Text.Trim();
                var result = _codingRepository.AddEditUnit(Row);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }
            else
            {
                var obj = new UnitOfMeasurement()
                {
                    Unit = txtUnitTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };
                var result = _codingRepository.AddEditUnit(obj);
                if (result)
                    PublicClass.SuccessMessage(Text);
                else
                    PublicClass.ErrorSave(Text);
            }

            UpdateList();
            ClearControlers();

        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvUnit.GetFocusedRowCellValue("ID") == null) return;
            Row = (UnitOfMeasurement)gvUnit.GetFocusedRow();
            txtUnitTitle.EditValue = Row.Unit;
            txtDescription.EditValue = Row.Description;
            btnClose.Text = PublicClass.CancelStr;
        }
        private void ClearControlers()
        {
            txtDescription.ResetText();
            txtUnitTitle.ResetText();
            Row = null;
            btnClose.Text = PublicClass.CloseStr;
        }
    }
}
