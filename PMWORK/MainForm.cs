using DevExpress.XtraEditors;
using PMWORK.CodingForms;
using PMWORK.MachineryForms;
using System;
using System.Windows.Forms;

namespace PMWORK
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
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




        private void itmRequestRepair_Click(object sender, EventArgs e)
        {
            ShowForms(new RequestRepairForm());
        }

        private void btnMachinery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new MachineryForm());
        }

        private void btnGroups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new GroupForm());
        }

        private void btnSubGroups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new SubGroupForm());
        }

        private void btnCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new CodingForm());
        }

        private void btnUnit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new UnitForm());
        }

        private void btnCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new CompaniesForm());

        }
    }
}
