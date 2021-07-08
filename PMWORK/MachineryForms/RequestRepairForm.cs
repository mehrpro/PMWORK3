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
        public RequestRepairForm()
        {
            InitializeComponent();
            db = PublicClass.db;
            dateRegistered.DateTime = DateTime.Now;
            cbxMachinery.Properties.DisplayMember = "MachineryTitle";
            cbxMachinery.Properties.ValueMember = "ID";

            UpdateMachinery();
            ClearForm();

        }

        private void ClearForm()
        {
            dateRegistered.DateTime = DateTime.Now;
            radioGroupEMPM.SelectedIndex = 0;
            radioGroupType.SelectedIndex = 0;
            txtRequest.Text = "";

        }
        private void UpdateMachinery()
        {
            cbxMachinery.Properties.DataSource = db.Machineries.Include(c=> c.Coding).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            else
            {
                var obj = new RequestRepair()
                {
                    IsActive = true,
                    IsDelete = false,
                    MachineryID_FK =Convert.ToInt32(cbxMachinery.EditValue),
                    UserID_FK = PublicClass.UserID,
                    Registered = DateTime.Now,
                    PublicTypeID_FK =Convert.ToInt32(radioGroupType.EditValue),
                    

                };

            }
        }
    }
}
