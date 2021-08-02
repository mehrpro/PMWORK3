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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == PublicClass.CancelStr)
            {
                btnClose.Text = PublicClass.CloseStr;
                ClearForm();
            }
            else
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {
                if (btnClose.Text == PublicClass.CancelStr)
                {

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
                    
                    var result = _codingRepository.add
                }
            }
        }
    }
}
