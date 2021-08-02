using DevExpress.XtraEditors;
using PMWORK.Repository;
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

namespace PMWORK.PMForms
{
    public partial class SparePartsForm : XtraForm
    {

        private readonly ICodingRepository _codingRepository;
        private int machineryID;
        private string machineryName;
        private string code;
        private SparePart SelectedRow;

        public int MachineryID { get => machineryID; set => machineryID = value; }
        public string MachineryName { get => machineryName; set => machineryName = value; }
        public string Code { get => code; set => code = value; }

        public SparePartsForm(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
            cbxUnit.Properties.DisplayMember = "Unit";
            cbxUnit.Properties.ValueMember = "ID";
            cbxUnit.Properties.DataSource = _codingRepository.GetAllUnits();
        }

        private void ClearForm()
        {
            txtDescription.ResetText();
            txtSpareTitle.ResetText();
            txtSpartNumber.ResetText();
            numMinimal.EditValue = 0;
            cbxUnit.EditValue = null;
            SelectedRow = null;
            chkStatus.Checked = true;
            btnClose.Text = PublicClass.CloseStr;
            UpdateSparePartList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {
                ClearForm();
            }
            else
            {
                Close();
            }
        }

        private void UpdateSparePartList()
        {
            dgvSparePartList.DataSource = _codingRepository.GetSparePartByMachineriId(machineryID);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                if (btnClose.Text == PublicClass.CancelStr)
                {
                    
                    SelectedRow.Description = txtDescription.Text.Trim();
                    SelectedRow.IsActive = chkStatus.Checked;
                    SelectedRow.MachineryID_FK = machineryID;
                    SelectedRow.Minimal = Convert.ToInt32(numMinimal.EditValue);
                    SelectedRow.SparePartNumber = txtSpartNumber.Text.Trim();
                    SelectedRow.SparePartTitle = txtSpareTitle.Text.Trim();
                    SelectedRow.UnitID_FK = Convert.ToInt32(cbxUnit.EditValue);

                    var result = _codingRepository.AddSparePart(SelectedRow);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);
                        ClearForm();
                    }
                    else
                    {
                        PublicClass.ErrorSave(Text);
                    }
                }
                else
                {
                    var obj = new SparePart();
                    obj.Description = txtDescription.Text.Trim();
                    obj.IsActive = chkStatus.Checked;
                    obj.MachineryID_FK = machineryID;
                    obj.Minimal = Convert.ToInt32(numMinimal.EditValue);
                    obj.SparePartNumber = txtSpartNumber.Text.Trim();
                    obj.SparePartTitle = txtSpareTitle.Text.Trim();
                    obj.UnitID_FK = Convert.ToInt32(cbxUnit.EditValue);

                    var result = _codingRepository.AddSparePart(obj);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);
                        ClearForm();
                    }
                    else
                    {
                        PublicClass.ErrorSave(Text);
                    }
                }
                //UpdateSparePartList();
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }
        }

        private void btnSelectRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvSparePartList.GetFocusedRowCellValue("ID") == null) return;
            SelectedRow = (SparePart)gvSparePartList.GetFocusedRow();
             txtDescription.Text = SelectedRow.Description;
             chkStatus.Checked = SelectedRow.IsActive ;            
            numMinimal.EditValue = SelectedRow.Minimal;
            txtSpartNumber.Text = SelectedRow.SparePartNumber;
           txtSpareTitle.Text = SelectedRow.SparePartTitle;
           cbxUnit.EditValue = SelectedRow.UnitID_FK ;
        }
    }
}
