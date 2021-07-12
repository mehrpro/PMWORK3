using PMWORK.CodingForms;
using PMWORK.MachineryForms;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using StructureMap;

namespace PMWORK
{
    public partial class MainForm : RibbonForm
    {
        private Container _container;
        public Container Container { get; set; }
        public MainForm()
        {

            InitializeComponent();
            _container = Container;
            //ShowForms(new RequestListForm());

        }
        private void ShowForms(object obj)
        {
            foreach (Form x in this.MdiChildren) x.Close();
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
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RequestRepairForm>();
            frm.TypeOfRequest = 1;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnMecanical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RequestRepairForm>();
            frm.TypeOfRequest = 2;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnPiping_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RequestRepairForm>();
            frm.TypeOfRequest = 3;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnBuilding_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RequestRepairForm>();
            frm.TypeOfRequest = 4;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnRequestList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RequestListForm>();
            frm.Container = _container;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnApplicantForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDialogForms(new ApplicantForm());
        }
    }
}
