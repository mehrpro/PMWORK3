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

namespace PMWORK.MachineryForms
{
    public partial class RequestRepairForm : XtraForm
    {
        private AppDbContext db;        
        public RequestRepairForm()
        {
            InitializeComponent();
            db = new AppDbContext();
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
    }
}
