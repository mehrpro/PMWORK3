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
            ShowForms(new RequestListForm());

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
        private void ShowDialogForms(object obj)
        {
            Form frm = (Form)obj;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }


        private void btnMachinery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new MachineryForm());
        }

        private void btnGroups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDialogForms(new GroupForm());
        }

        private void btnSubGroups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDialogForms(new SubGroupForm());
        }

        private void btnCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new CodingForm());
        }

        private void btnUnit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDialogForms(new UnitForm());
        }

        private void btnCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDialogForms(new CompaniesForm());

        }

        private void btnElectrical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new RequestRepairForm(1);
            frm.ShowDialog();
        }

        private void btnMecanical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new RequestRepairForm(2);
            frm.ShowDialog();
        }

        private void btnPiping_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new RequestRepairForm(3);
            frm.ShowDialog();
        }

        private void btnBuilding_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new RequestRepairForm(4);
            frm.ShowDialog();
        }

        private void btnRequestList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForms(new RequestListForm());
        }

        private void btnApplicantForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDialogForms(new ApplicantForm());
        }
    }
}
