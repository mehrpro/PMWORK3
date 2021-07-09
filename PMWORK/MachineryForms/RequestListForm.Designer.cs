
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequsetDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReqTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Applicant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SelectView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
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
            this.splitContainerControl1.SplitterPosition = 172;
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
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 172;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl1.Size = new System.Drawing.Size(172, 456);
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
            this.btnElectricalList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnElectricalList_LinkClicked);
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
            this.dgvRequestList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditRow,
            this.repositoryItemDateEdit1});
            this.dgvRequestList.Size = new System.Drawing.Size(637, 456);
            this.dgvRequestList.TabIndex = 0;
            this.dgvRequestList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRequestList});
            // 
            // gvRequestList
            // 
            this.gvRequestList.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.Empty.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.OddRow.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.Preview.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.Row.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.VertLine.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvRequestList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequestList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.RequsetDateTime,
            this.MachineryCode,
            this.EM,
            this.ReqTitle,
            this.Applicant,
            this.SelectView});
            this.gvRequestList.GridControl = this.dgvRequestList;
            this.gvRequestList.Name = "gvRequestList";
            // 
            // ID
            // 
            this.ID.Caption = "شماره";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 61;
            // 
            // RequsetDateTime
            // 
            this.RequsetDateTime.Caption = "تاریخ";
            this.RequsetDateTime.ColumnEdit = this.repositoryItemDateEdit1;
            this.RequsetDateTime.FieldName = "RequestDataTime";
            this.RequsetDateTime.Name = "RequsetDateTime";
            this.RequsetDateTime.Visible = true;
            this.RequsetDateTime.VisibleIndex = 1;
            this.RequsetDateTime.Width = 87;
            // 
            // MachineryCode
            // 
            this.MachineryCode.Caption = "کد دستگاه";
            this.MachineryCode.Name = "MachineryCode";
            this.MachineryCode.Visible = true;
            this.MachineryCode.VisibleIndex = 2;
            this.MachineryCode.Width = 92;
            // 
            // EM
            // 
            this.EM.Caption = "اضطراری";
            this.EM.Name = "EM";
            this.EM.Visible = true;
            this.EM.VisibleIndex = 3;
            this.EM.Width = 92;
            // 
            // ReqTitle
            // 
            this.ReqTitle.Caption = "شرح درخواست";
            this.ReqTitle.Name = "ReqTitle";
            this.ReqTitle.Visible = true;
            this.ReqTitle.VisibleIndex = 4;
            this.ReqTitle.Width = 92;
            // 
            // Applicant
            // 
            this.Applicant.Caption = "درخواست کننده";
            this.Applicant.Name = "Applicant";
            this.Applicant.Visible = true;
            this.Applicant.VisibleIndex = 5;
            this.Applicant.Width = 92;
            // 
            // SelectView
            // 
            this.SelectView.Caption = "جزئیات";
            this.SelectView.ColumnEdit = this.btnEditRow;
            this.SelectView.Name = "SelectView";
            this.SelectView.Visible = true;
            this.SelectView.VisibleIndex = 6;
            this.SelectView.Width = 103;
            // 
            // btnEditRow
            // 
            this.btnEditRow.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.Parmida_CheckDateOnLeave = false;
            this.repositoryItemDateEdit1.Parmida_CheckEmptyFillDateOnEnter = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnEditRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn RequsetDateTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn MachineryCode;
        private DevExpress.XtraGrid.Columns.GridColumn EM;
        private DevExpress.XtraGrid.Columns.GridColumn ReqTitle;
        private DevExpress.XtraGrid.Columns.GridColumn Applicant;
        private DevExpress.XtraGrid.Columns.GridColumn SelectView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditRow;
    }
}