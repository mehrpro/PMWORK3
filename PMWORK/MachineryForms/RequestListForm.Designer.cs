
namespace PMWORK.MachineryForms
{
    partial class RequestListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestListForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnElectricalList = new DevExpress.XtraNavBar.NavBarItem();
            this.btnMecanicalList = new DevExpress.XtraNavBar.NavBarItem();
            this.btnPipeLine = new DevExpress.XtraNavBar.NavBarItem();
            this.btnBuilding = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.dgvRequestList = new DevExpress.XtraGrid.GridControl();
            this.gvRequestList = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dgvRequestList);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(814, 456);
            this.splitContainerControl1.SplitterPosition = 210;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnElectricalList,
            this.btnMecanicalList,
            this.btnPipeLine,
            this.btnBuilding,
            this.navBarItem5,
            this.navBarItem6});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 210;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl1.Size = new System.Drawing.Size(210, 456);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "دستور کار";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.SmallImage = global::PMWORK.Properties.Resources.icons8_task_30;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnElectricalList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnMecanicalList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnPipeLine),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnBuilding)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btnElectricalList
            // 
            this.btnElectricalList.Caption = "کارگاه برق";
            this.btnElectricalList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnElectricalList.ImageOptions.LargeImage")));
            this.btnElectricalList.ImageOptions.SmallImage = global::PMWORK.Properties.Resources.icons8_electrical_16;
            this.btnElectricalList.Name = "btnElectricalList";
            // 
            // btnMecanicalList
            // 
            this.btnMecanicalList.Caption = "کارگاه مکانیک";
            this.btnMecanicalList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMecanicalList.ImageOptions.LargeImage")));
            this.btnMecanicalList.ImageOptions.SmallImage = global::PMWORK.Properties.Resources.icons8_settings_16;
            this.btnMecanicalList.Name = "btnMecanicalList";
            // 
            // btnPipeLine
            // 
            this.btnPipeLine.Caption = "کارگاه تاسیسات";
            this.btnPipeLine.ImageOptions.SmallImage = global::PMWORK.Properties.Resources.icons8_piping_16;
            this.btnPipeLine.Name = "btnPipeLine";
            // 
            // btnBuilding
            // 
            this.btnBuilding.Caption = "ساخت و تجهیز";
            this.btnBuilding.ImageOptions.SmallImage = global::PMWORK.Properties.Resources.icons8_maintenance_16;
            this.btnBuilding.Name = "btnBuilding";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "navBarItem5";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "navBarItem6";
            this.navBarItem6.Name = "navBarItem6";
            // 
            // dgvRequestList
            // 
            this.dgvRequestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequestList.Location = new System.Drawing.Point(0, 0);
            this.dgvRequestList.MainView = this.gvRequestList;
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.Size = new System.Drawing.Size(599, 456);
            this.dgvRequestList.TabIndex = 0;
            this.dgvRequestList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRequestList});
            // 
            // gvRequestList
            // 
            this.gvRequestList.GridControl = this.dgvRequestList;
            this.gvRequestList.Name = "gvRequestList";
            // 
            // RequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 456);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "RequestListForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "پیشخوان";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl dgvRequestList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRequestList;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btnElectricalList;
        private DevExpress.XtraNavBar.NavBarItem btnMecanicalList;
        private DevExpress.XtraNavBar.NavBarItem btnPipeLine;
        private DevExpress.XtraNavBar.NavBarItem btnBuilding;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
    }
}