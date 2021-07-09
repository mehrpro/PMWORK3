
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
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
            this.InfrasturctureRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MaintanaceRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ReportsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SettingRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
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
            this.btnRequestList});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.InfrasturctureRibbonPage,
            this.MaintanaceRibbonPage,
            this.ReportsRibbonPage,
            this.SettingRibbonPage});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(750, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnCompany
            // 
            this.btnCompany.Caption = "شرکت ها";
            this.btnCompany.Id = 1;
            this.btnCompany.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_factory_30;
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompany_ItemClick);
            // 
            // btnGroups
            // 
            this.btnGroups.Caption = "گروه اصلی";
            this.btnGroups.Id = 2;
            this.btnGroups.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_list_30;
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnGroups.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGroups_ItemClick);
            // 
            // btnSubGroups
            // 
            this.btnSubGroups.Caption = "گروه فرعی";
            this.btnSubGroups.Id = 3;
            this.btnSubGroups.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_separated_lists_30;
            this.btnSubGroups.Name = "btnSubGroups";
            this.btnSubGroups.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
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
            this.btnUnit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
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
            this.btnRequestList.Caption = "پیشخوان";
            this.btnRequestList.Id = 8;
            this.btnRequestList.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_task_30;
            this.btnRequestList.Name = "btnRequestList";
            this.btnRequestList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnRequestList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRequestList_ItemClick);
            // 
            // InfrasturctureRibbonPage
            // 
            this.InfrasturctureRibbonPage.Appearance.Options.UseTextOptions = true;
            this.InfrasturctureRibbonPage.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.InfrasturctureRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.InfrasturctureRibbonPage.Name = "InfrasturctureRibbonPage";
            this.InfrasturctureRibbonPage.Text = "دارایی فیزیکی";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMachinery);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "دارایی فیزیکی";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCompany);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnGroups);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSubGroups);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCode);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUnit);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "کدگزاری";
            // 
            // MaintanaceRibbonPage
            // 
            this.MaintanaceRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.MaintanaceRibbonPage.Name = "MaintanaceRibbonPage";
            this.MaintanaceRibbonPage.Text = "نگهداری تعمیرات";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnElectrical);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMecanical);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPiping);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBuilding);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "تعمیرگاه";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRequestList);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "مدیریت درخواست ها";
            // 
            // ReportsRibbonPage
            // 
            this.ReportsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ReportsRibbonPage.Name = "ReportsRibbonPage";
            this.ReportsRibbonPage.Text = "گزارشات";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // SettingRibbonPage
            // 
            this.SettingRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.SettingRibbonPage.Name = "SettingRibbonPage";
            this.SettingRibbonPage.Text = "تنظیمات";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup5.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 500);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(750, 31);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 531);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "اتوماسیون نت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage InfrasturctureRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnCompany;
        private DevExpress.XtraBars.BarButtonItem btnGroups;
        private DevExpress.XtraBars.BarButtonItem btnSubGroups;
        private DevExpress.XtraBars.BarButtonItem btnCode;
        private DevExpress.XtraBars.BarButtonItem btnUnit;
        private DevExpress.XtraBars.BarButtonItem btnMachinery;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage MaintanaceRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ReportsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnElectrical;
        private DevExpress.XtraBars.BarButtonItem btnMecanical;
        private DevExpress.XtraBars.BarButtonItem btnPiping;
        private DevExpress.XtraBars.BarButtonItem btnBuilding;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage SettingRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnRequestList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}