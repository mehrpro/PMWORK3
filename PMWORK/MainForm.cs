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
            ShowDialogForms(new ApplicantForm());
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
    }
}
