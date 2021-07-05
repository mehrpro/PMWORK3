using DevExpress.XtraEditors;
using PMWORK.CodingForms;
using PMWORK.MachineryForms;
using System;
using System.Windows.Forms;

namespace PMWORK
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowForms(object obj)
        {
            foreach (Form x in this.MdiChildren)
            {
                x.Close();
            }

            Form frm = (Form)obj;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }


        private void itmCompany_Click(object sender, EventArgs e)
        {
            ShowForms(new CompaniesForm());

        }

        private void itmGroups_Click(object sender, EventArgs e)
        {
            ShowForms(new GroupForm());
        }

        private void itmSubGroups_Click(object sender, EventArgs e)
        {
            ShowForms(new SubGroupForm());
        }

        private void itmCodings_Click(object sender, EventArgs e)
        {
            ShowForms(new CodingForm());
        }

        private void itmUnits_Click(object sender, EventArgs e)
        {
            ShowForms(new UnitForm());
        }

        private void itmMachinery_Click(object sender, EventArgs e)
        {
            ShowForms(new MachineryForm());
        }

        private void itmRequestRepair_Click(object sender, EventArgs e)
        {
            ShowForms(new RequestRepairForm());
        }
    }
}
