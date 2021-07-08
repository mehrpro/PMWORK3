
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
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(1021, 143);
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
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "کارگاه مکانیک";
            this.barButtonItem8.Id = 2;
            this.barButtonItem8.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_settings_30;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "کارگاه تاسیسات";
            this.barButtonItem9.Id = 3;
            this.barButtonItem9.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_piping_30;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "کارگاه ساخت";
            this.barButtonItem10.Id = 4;
            this.barButtonItem10.ImageOptions.Image = global::PMWORK.Properties.Resources.icons8_maintenance_30;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Options.UseTextOptions = true;
            this.ribbonPage1.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "دارایی فیزیکی";
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
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "نگهداری تعمیرات";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnElectrical);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "تعمیرات";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "گزارشات";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 620);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اتوماسیون نت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnCompany;
        private DevExpress.XtraBars.BarButtonItem btnGroups;
        private DevExpress.XtraBars.BarButtonItem btnSubGroups;
        private DevExpress.XtraBars.BarButtonItem btnCode;
        private DevExpress.XtraBars.BarButtonItem btnUnit;
        private DevExpress.XtraBars.BarButtonItem btnMachinery;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnElectrical;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
    }
}