using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using PMWORK.Entities;

namespace PMWORK.MachineryForms
{
    public partial class RequestRepairForm : XtraForm
    {
        private AppDbContext db;
        private int _TypeofRequest;
        public RequestRepairForm(int TypeofRequest)
        {
            InitializeComponent();
            db = PublicClass.db;
            _TypeofRequest = TypeofRequest;
            dateRegistered.DateTime = DateTime.Now;
            cbxMachinery.Properties.DisplayMember = "Coding.Code";
            cbxMachinery.Properties.ValueMember = "ID";
            var str = db.PublicTypes.Find(TypeofRequest).Title.ToString();
            txtRequestTitle.Text += " " + str;
            UpdateMachinery();
            ClearForm();

        }

        private void ClearForm()
        {
            dateRegistered.DateTime = DateTime.Now;
            radioGroupEMPM.SelectedIndex = 0;
            txtRequest.Text = "";

        }
        private void UpdateMachinery()
        {
            cbxMachinery.Properties.DataSource = db.Machineries
                .Include(c=> c.Coding)
                .Where(x=>x.CompanyID == PublicClass.CompanyID)
                .ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {


            }
            else
            {
                Close();
            }

        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (false)
            {

            }
            else
            {
                var obj = new RequestRepair()
                {
                    IsActive = true,
                    IsDelete = false,
                    MachineryID_FK = Convert.ToInt32(cbxMachinery.EditValue),
                    UserID_FK = PublicClass.UserID,
                    Registered = DateTime.Now,
                    PublicTypeID_FK = _TypeofRequest,
                    EM = Convert.ToBoolean(radioGroupEMPM.EditValue),
                    RequestDataTime = DateTime.Now,
                    RequestTitle = txtRequest.Text.Trim(),
                    
                    

                };

            }
        }

        private void cbxMachinery_EditValueChanged(object sender, EventArgs e)
        {
            var SelectedMachinery = (Machinery)cbxMachinery.GetSelectedDataRow();
            if (SelectedMachinery == null)
            {
                txtMachinery.Text = "";
                return;
            }
            txtMachinery.Text = SelectedMachinery.MachineryTitle;

        }

        private void dateRegistered_EditValueChanged(object sender, EventArgs e)
        {

        }

 
    }
}
