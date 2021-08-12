using PMWORK.CodingForms;
using PMWORK.MachineryForms;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using StructureMap;
using PMWORK.Admin;
using System.Collections.Generic;
using System.Linq;
using PMWORK.Entities;
using PMWORK.Repository;
using System;

namespace PMWORK
{
    public partial class MainForm : RibbonForm
    {
        private Container _container;
        private readonly ICodingRepository _codingRepository;

        public Container Container
        {
            get { return _container; }
            set { _container = value; }
        }

        private void UpdateMainMenu()
        {
            var access = _codingRepository.GetCleams(PublicClass.UserID);
            foreach (var menuGroup in access)
            {
                var page = this.ribMain.Pages.GetPageByName(menuGroup.MenuGroup.MenuGroupTitle).Groups.GetGroupByName(menuGroup.MenuItem.ItemTitel);
                page.Visible = !menuGroup.IsDelete;
            }
            foreach (var ribbonPage in ribMain.Pages.ToList())
            {
                var groupArray = ribbonPage.Groups.Select(x => x.Visible).ToArray();
                var vis = false;
                foreach (var b in groupArray)
                    vis = vis || b;
                ribbonPage.Visible = vis;
            }
        }

        public MainForm(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
            UpdateMainMenu();
            lblFullNameTaskBar.Caption = PublicClass.FullNameTask;
            lblDatetimeTaskBar.Caption = PublicClass.TodayPersian();

            btnRepairManForm.Enabled = btnUnit.Enabled =
            btnCompany.Enabled = !PublicClass.LimitedCompany;

            // _container = Container;
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
            //ShowDialogForms(new GroupForm());
            var frm = _container.GetInstance<GroupForm>();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();
        }

        private void btnSubGroups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frm = _container.GetInstance<SubGroupForm>();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();
        }

        private void btnCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<CodingForm>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnUnit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<UnitForm>();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();
        }

        private void btnCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<CompaniesForm>();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();

        }

        private void btnElectrical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<RequestRepairForm>();
            frm.TypeOfRequest = 1;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnMecanical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<RequestRepairForm>();
            frm.TypeOfRequest = 2;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnPiping_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<RequestRepairForm>();
            frm.TypeOfRequest = 3;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnBuilding_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<RequestRepairForm>();
            frm.TypeOfRequest = 4;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnRequestListHandel()
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
        private void btnRequestList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnRequestListHandel();
        }

        private void btnApplicantForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<ApplicantForm>();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = frm.MinimizeBox = false;
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //btnRequestListHandel();
        }

        private void btnRequestListForRepair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RequestListForm3>();
            frm.Container = _container;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnRepairManForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RepairManForm>();
            //frm.Container = _container;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnClosedRequestRepair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RequestListForm33>();
            frm.Container = _container;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<UsersForm>();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

        }

        private void btnClame_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<UserAccessForm>();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnIdentityDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<IdentityDeviceForm>();
            frm.Container = _container;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnServicePeriode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ShowForms(new PMWORK.PMForms.ServicePerideForm());
        }

        private void btnRepairOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
            foreach (var x in MdiChildren) x.Close();
            var frm = _container.GetInstance<RequestListForm333>();
            frm.Container = _container;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            }
        }
}
