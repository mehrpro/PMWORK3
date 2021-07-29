﻿
namespace PMWORK
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCompany = new DevExpress.XtraBars.BarButtonItem();
            this.btnGroups = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubGroups = new DevExpress.XtraBars.BarButtonItem();
            this.btnCode = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnit = new DevExpress.XtraBars.BarButtonItem();
            this.btnMachinery = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnElectrical = new DevExpress.XtraBars.BarButtonItem();
            this.btnMecanical = new DevExpress.XtraBars.BarButtonItem();
            this.btnPiping = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuilding = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnRequestList = new DevExpress.XtraBars.BarButtonItem();
            this.btnApplicantForm = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepairManForm = new DevExpress.XtraBars.BarButtonItem();
            this.btnRequestListForRepair = new DevExpress.XtraBars.BarButtonItem();
            this.btnClosedRequestRepair = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnClame = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribPageInfrasturcture = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PGMachinery = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PGCoding = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPageMaintanace = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PGRequestReapir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPageReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PGReportRepair = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPageManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PGUsers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribMain
            // 
            this.ribMain.ExpandCollapseItem.Id = 0;
            this.ribMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribMain.ExpandCollapseItem,
            this.btnCompany,
            this.btnGroups,
            this.btnSubGroups,
            this.btnCode,
            this.btnUnit,
            this.btnMachinery,
            this.barButtonItem6,
            this.btnElectrical,
            this.btnMecanical,
            this.btnPiping,
            this.btnBuilding,
            this.skinPaletteRibbonGalleryBarItem1,
            this.skinRibbonGalleryBarItem1,
            this.barStaticItem1,
            this.btnRequestList,
            this.btnApplicantForm,
            this.btnRepairManForm,
            this.btnRequestListForRepair,
            this.btnClosedRequestRepair,
            this.btnUsers,
            this.btnClame,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribMain.Location = new System.Drawing.Point(0, 0);
            this.ribMain.MaxItemId = 17;
            this.ribMain.Name = "ribMain";
            this.ribMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribPageInfrasturcture,
            this.ribPageMaintanace,
            this.ribPageReports,
            this.ribPageManage});
            this.ribMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribMain.Size = new System.Drawing.Size(750, 143);
            this.ribMain.StatusBar = this.ribbonStatusBar1;
            // 
            // btnCompany
            // 
            this.btnCompany.Caption = "شرکت ها";
            this.btnCompany.Id = 1;
            this.btnCompany.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_factory_30;
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompany_ItemClick);
            // 
            // btnGroups
            // 
            this.btnGroups.Caption = "گروه اصلی";
            this.btnGroups.Id = 2;
            this.btnGroups.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_list_30;
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnGroups.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGroups_ItemClick);
            // 
            // btnSubGroups
            // 
            this.btnSubGroups.Caption = "گروه فرعی";
            this.btnSubGroups.Id = 3;
            this.btnSubGroups.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_separated_lists_30;
            this.btnSubGroups.Name = "btnSubGroups";
            this.btnSubGroups.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubGroups_ItemClick);
            // 
            // btnCode
            // 
            this.btnCode.Caption = "کد جدید";
            this.btnCode.Id = 4;
            this.btnCode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCode.ImageOptions.Image")));
            this.btnCode.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCode.ImageOptions.LargeImage")));
            this.btnCode.Name = "btnCode";
            this.btnCode.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCode_ItemClick);
            // 
            // btnUnit
            // 
            this.btnUnit.Caption = "واحد سنجش";
            this.btnUnit.Id = 5;
            this.btnUnit.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_unit_30;
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnit_ItemClick);
            // 
            // btnMachinery
            // 
            this.btnMachinery.Caption = "ماشین آلات";
            this.btnMachinery.Id = 6;
            this.btnMachinery.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_robot_30;
            this.btnMachinery.Name = "btnMachinery";
            this.btnMachinery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnMachinery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMachinery_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "شناسنامه دستگاه";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_document_30;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnElectrical
            // 
            this.btnElectrical.Caption = "کارگاه برق";
            this.btnElectrical.Id = 1;
            this.btnElectrical.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_electrical_30;
            this.btnElectrical.Name = "btnElectrical";
            this.btnElectrical.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnElectrical.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnElectrical_ItemClick);
            // 
            // btnMecanical
            // 
            this.btnMecanical.Caption = "کارگاه مکانیک";
            this.btnMecanical.Id = 2;
            this.btnMecanical.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_settings_30;
            this.btnMecanical.Name = "btnMecanical";
            this.btnMecanical.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnMecanical.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMecanical_ItemClick);
            // 
            // btnPiping
            // 
            this.btnPiping.Caption = "کارگاه تاسیسات";
            this.btnPiping.Id = 3;
            this.btnPiping.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_piping_30;
            this.btnPiping.Name = "btnPiping";
            this.btnPiping.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnPiping.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPiping_ItemClick);
            // 
            // btnBuilding
            // 
            this.btnBuilding.Caption = "کارگاه ساخت";
            this.btnBuilding.Id = 4;
            this.btnBuilding.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_maintenance_30;
            this.btnBuilding.Name = "btnBuilding";
            this.btnBuilding.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnBuilding.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuilding_ItemClick);
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            // 
            // 
            // 
            this.skinPaletteRibbonGalleryBarItem1.Gallery.ShowItemText = true;
            this.skinPaletteRibbonGalleryBarItem1.Id = 5;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 6;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "کاربر:";
            this.barStaticItem1.Id = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // btnRequestList
            // 
            this.btnRequestList.Caption = "کارتابل";
            this.btnRequestList.Id = 8;
            this.btnRequestList.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_task_30;
            this.btnRequestList.Name = "btnRequestList";
            this.btnRequestList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnRequestList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRequestList_ItemClick);
            // 
            // btnApplicantForm
            // 
            this.btnApplicantForm.Caption = "واحدهای ادواری";
            this.btnApplicantForm.Id = 9;
            this.btnApplicantForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicantForm.ImageOptions.Image")));
            this.btnApplicantForm.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnApplicantForm.ImageOptions.LargeImage")));
            this.btnApplicantForm.Name = "btnApplicantForm";
            this.btnApplicantForm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnApplicantForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnApplicantForm_ItemClick);
            // 
            // btnRepairManForm
            // 
            this.btnRepairManForm.Caption = "تعمیرکاران";
            this.btnRepairManForm.Id = 10;
            this.btnRepairManForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRepairManForm.ImageOptions.Image")));
            this.btnRepairManForm.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRepairManForm.ImageOptions.LargeImage")));
            this.btnRepairManForm.Name = "btnRepairManForm";
            this.btnRepairManForm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnRepairManForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRepairManForm_ItemClick);
            // 
            // btnRequestListForRepair
            // 
            this.btnRequestListForRepair.Caption = "درخواست های فعال";
            this.btnRequestListForRepair.Id = 11;
            this.btnRequestListForRepair.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRequestListForRepair.ImageOptions.Image")));
            this.btnRequestListForRepair.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRequestListForRepair.ImageOptions.LargeImage")));
            this.btnRequestListForRepair.Name = "btnRequestListForRepair";
            this.btnRequestListForRepair.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRequestListForRepair_ItemClick);
            // 
            // btnClosedRequestRepair
            // 
            this.btnClosedRequestRepair.Caption = "درخواست های بسته شده";
            this.btnClosedRequestRepair.Id = 12;
            this.btnClosedRequestRepair.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_list_30;
            this.btnClosedRequestRepair.Name = "btnClosedRequestRepair";
            this.btnClosedRequestRepair.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnClosedRequestRepair.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClosedRequestRepair_ItemClick);
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "کاربران سیستم";
            this.btnUsers.Id = 13;
            this.btnUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageOptions.Image")));
            this.btnUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageOptions.LargeImage")));
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsers_ItemClick);
            // 
            // btnClame
            // 
            this.btnClame.Caption = "مجوز دسترسی";
            this.btnClame.Id = 14;
            this.btnClame.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClame.ImageOptions.Image")));
            this.btnClame.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClame.ImageOptions.LargeImage")));
            this.btnClame.Name = "btnClame";
            this.btnClame.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClame_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = 16;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribPageInfrasturcture
            // 
            this.ribPageInfrasturcture.Appearance.Options.UseTextOptions = true;
            this.ribPageInfrasturcture.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.ribPageInfrasturcture.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PGMachinery,
            this.PGCoding});
            this.ribPageInfrasturcture.Name = "ribPageInfrasturcture";
            this.ribPageInfrasturcture.Text = "دارایی فیزیکی";
            // 
            // PGMachinery
            // 
            this.PGMachinery.ItemLinks.Add(this.btnMachinery);
            this.PGMachinery.ItemLinks.Add(this.barButtonItem6);
            this.PGMachinery.Name = "PGMachinery";
            this.PGMachinery.ShowCaptionButton = false;
            this.PGMachinery.Text = "دارایی فیزیکی";
            // 
            // PGCoding
            // 
            this.PGCoding.ItemLinks.Add(this.btnCompany);
            this.PGCoding.ItemLinks.Add(this.btnGroups);
            this.PGCoding.ItemLinks.Add(this.btnSubGroups);
            this.PGCoding.ItemLinks.Add(this.btnUnit);
            this.PGCoding.ItemLinks.Add(this.btnApplicantForm);
            this.PGCoding.ItemLinks.Add(this.btnRepairManForm);
            this.PGCoding.ItemLinks.Add(this.btnCode);
            this.PGCoding.Name = "PGCoding";
            this.PGCoding.ShowCaptionButton = false;
            this.PGCoding.Text = "کدینگ موجودیت";
            // 
            // ribPageMaintanace
            // 
            this.ribPageMaintanace.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PGRequestReapir});
            this.ribPageMaintanace.Name = "ribPageMaintanace";
            this.ribPageMaintanace.Text = "نگهداری تعمیرات";
            // 
            // PGRequestReapir
            // 
            this.PGRequestReapir.ItemLinks.Add(this.btnRequestList);
            this.PGRequestReapir.ItemLinks.Add(this.btnElectrical);
            this.PGRequestReapir.ItemLinks.Add(this.btnMecanical);
            this.PGRequestReapir.ItemLinks.Add(this.btnPiping);
            this.PGRequestReapir.ItemLinks.Add(this.btnBuilding);
            this.PGRequestReapir.Name = "PGRequestReapir";
            this.PGRequestReapir.ShowCaptionButton = false;
            this.PGRequestReapir.Text = "تعمیرگاه";
            // 
            // ribPageReports
            // 
            this.ribPageReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PGReportRepair});
            this.ribPageReports.Name = "ribPageReports";
            this.ribPageReports.Text = "گزارشات";
            // 
            // PGReportRepair
            // 
            this.PGReportRepair.ItemLinks.Add(this.btnRequestListForRepair);
            this.PGReportRepair.ItemLinks.Add(this.btnClosedRequestRepair);
            this.PGReportRepair.Name = "PGReportRepair";
            this.PGReportRepair.ShowCaptionButton = false;
            this.PGReportRepair.Text = "گزارش تعمیر";
            // 
            // ribPageManage
            // 
            this.ribPageManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PGUsers});
            this.ribPageManage.Name = "ribPageManage";
            this.ribPageManage.Text = "مدیر نرم افزار";
            // 
            // PGUsers
            // 
            this.PGUsers.ItemLinks.Add(this.btnUsers);
            this.PGUsers.ItemLinks.Add(this.btnClame);
            this.PGUsers.Name = "PGUsers";
            this.PGUsers.ShowCaptionButton = false;
            this.PGUsers.Text = "مدیریت کاربران";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 500);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribMain;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(750, 31);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 531);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribMain);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribMain;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "اتوماسیون نت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPageInfrasturcture;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGMachinery;
        private DevExpress.XtraBars.BarButtonItem btnCompany;
        private DevExpress.XtraBars.BarButtonItem btnGroups;
        private DevExpress.XtraBars.BarButtonItem btnSubGroups;
        private DevExpress.XtraBars.BarButtonItem btnCode;
        private DevExpress.XtraBars.BarButtonItem btnUnit;
        private DevExpress.XtraBars.BarButtonItem btnMachinery;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGCoding;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPageMaintanace;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGRequestReapir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPageReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGReportRepair;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnElectrical;
        private DevExpress.XtraBars.BarButtonItem btnMecanical;
        private DevExpress.XtraBars.BarButtonItem btnPiping;
        private DevExpress.XtraBars.BarButtonItem btnBuilding;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnRequestList;
        private DevExpress.XtraBars.BarButtonItem btnApplicantForm;
        private DevExpress.XtraBars.BarButtonItem btnRepairManForm;
        private DevExpress.XtraBars.BarButtonItem btnRequestListForRepair;
        private DevExpress.XtraBars.BarButtonItem btnClosedRequestRepair;
        private DevExpress.XtraBars.BarButtonItem btnUsers;
        private DevExpress.XtraBars.BarButtonItem btnClame;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPageManage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGUsers;
    }
}