
namespace PMWORK.SensorForm
{
    partial class MachineryCounterDeviceForm
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbxMachineryList = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxTerminal = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxCounterDevice = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.dgvMachineryCounter = new DevExpress.XtraGrid.GridControl();
            this.gvMachineryCounter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.machineryCounterDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineryCodeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineryTitleColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CounterDeviceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ApplicantColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachinery1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachinery = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMachineryList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTerminal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCounterDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineryCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachineryCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineryCounterDevicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(760, 133);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvMachineryCounter);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 133);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(760, 398);
            this.panelControl2.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.layoutControl1.Controls.Add(this.chkActive);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.cbxMachineryList);
            this.layoutControl1.Controls.Add(this.cbxTerminal);
            this.layoutControl1.Controls.Add(this.cbxCounterDevice);
            this.layoutControl1.Controls.Add(this.cbxCompany);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(358, 300, 650, 400);
            this.layoutControl1.OptionsFocus.MoveFocusRightToLeft = true;
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(756, 103);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(756, 103);
            this.Root.TextVisible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(380, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Parmida_ActivePlusMultiKeys = false;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(321, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(368, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem1.Text = "شناسه";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(39, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(736, 11);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbxCompany;
            this.layoutControlItem2.Location = new System.Drawing.Point(368, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem2.Text = "شرکت";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbxCounterDevice;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem3.Text = "مرکزداده";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbxTerminal;
            this.layoutControlItem4.Location = new System.Drawing.Point(368, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem4.Text = "ترمینال";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbxMachineryList;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem5.Text = "دستگاه";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(39, 13);
            // 
            // chkActive
            // 
            this.chkActive.EditValue = true;
            this.chkActive.Location = new System.Drawing.Point(12, 12);
            this.chkActive.Name = "chkActive";
            this.chkActive.Parmida_ActivePlusMultiKeys = false;
            this.chkActive.Properties.Caption = "فعال";
            this.chkActive.Size = new System.Drawing.Size(321, 19);
            this.chkActive.StyleController = this.layoutControl1;
            this.chkActive.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkActive;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem6.Text = "وضعیت";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(39, 13);
            // 
            // cbxMachineryList
            // 
            this.cbxMachineryList.Location = new System.Drawing.Point(12, 60);
            this.cbxMachineryList.Name = "cbxMachineryList";
            this.cbxMachineryList.Parmida_ActivePlusMultiKeys = false;
            this.cbxMachineryList.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxMachineryList.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxMachineryList.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxMachineryList.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxMachineryList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMachineryList.Properties.NullText = "";
            this.cbxMachineryList.Size = new System.Drawing.Size(321, 20);
            this.cbxMachineryList.StyleController = this.layoutControl1;
            this.cbxMachineryList.TabIndex = 8;
            // 
            // cbxTerminal
            // 
            this.cbxTerminal.Location = new System.Drawing.Point(380, 60);
            this.cbxTerminal.Name = "cbxTerminal";
            this.cbxTerminal.Parmida_ActivePlusMultiKeys = false;
            this.cbxTerminal.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxTerminal.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxTerminal.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxTerminal.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxTerminal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTerminal.Properties.NullText = "";
            this.cbxTerminal.Size = new System.Drawing.Size(321, 20);
            this.cbxTerminal.StyleController = this.layoutControl1;
            this.cbxTerminal.TabIndex = 7;
            // 
            // cbxCounterDevice
            // 
            this.cbxCounterDevice.Location = new System.Drawing.Point(12, 36);
            this.cbxCounterDevice.Name = "cbxCounterDevice";
            this.cbxCounterDevice.Parmida_ActivePlusMultiKeys = false;
            this.cbxCounterDevice.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCounterDevice.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCounterDevice.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCounterDevice.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCounterDevice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCounterDevice.Properties.NullText = "";
            this.cbxCounterDevice.Size = new System.Drawing.Size(321, 20);
            this.cbxCounterDevice.StyleController = this.layoutControl1;
            this.cbxCounterDevice.TabIndex = 6;
            // 
            // cbxCompany
            // 
            this.cbxCompany.Location = new System.Drawing.Point(380, 36);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Parmida_ActivePlusMultiKeys = false;
            this.cbxCompany.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCompany.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCompany.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCompany.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCompany.Properties.NullText = "";
            this.cbxCompany.Size = new System.Drawing.Size(321, 20);
            this.cbxCompany.StyleController = this.layoutControl1;
            this.cbxCompany.TabIndex = 5;
            // 
            // dgvMachineryCounter
            // 
            this.dgvMachineryCounter.DataSource = this.machineryCounterDevicesBindingSource;
            this.dgvMachineryCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMachineryCounter.Location = new System.Drawing.Point(2, 2);
            this.dgvMachineryCounter.MainView = this.gvMachineryCounter;
            this.dgvMachineryCounter.Name = "dgvMachineryCounter";
            this.dgvMachineryCounter.Size = new System.Drawing.Size(756, 394);
            this.dgvMachineryCounter.TabIndex = 0;
            this.dgvMachineryCounter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMachineryCounter});
            // 
            // gvMachineryCounter
            // 
            this.gvMachineryCounter.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.Empty.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.OddRow.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.Preview.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.Row.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.VertLine.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvMachineryCounter.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvMachineryCounter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.MachineryCodeColumn,
            this.MachineryTitleColumn,
            this.CounterDeviceColumn,
            this.ApplicantColumn,
            this.colIsActive,
            this.colMachinery1,
            this.colMachinery});
            this.gvMachineryCounter.GridControl = this.dgvMachineryCounter;
            this.gvMachineryCounter.Name = "gvMachineryCounter";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(120, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "ذخیره";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(14, 97);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "بستن";
            // 
            // machineryCounterDevicesBindingSource
            // 
            this.machineryCounterDevicesBindingSource.DataSource = typeof(PMWORK.Entities.MachineryCounterDevice);
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colID.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colID.Caption = "شناسه";
            this.colID.FieldName = "ID";
            this.colID.MaxWidth = 60;
            this.colID.MinWidth = 60;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 60;
            // 
            // MachineryCodeColumn
            // 
            this.MachineryCodeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.MachineryCodeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MachineryCodeColumn.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MachineryCodeColumn.Caption = "کد دستگاه";
            this.MachineryCodeColumn.FieldName = "MachineryID_FK";
            this.MachineryCodeColumn.MaxWidth = 75;
            this.MachineryCodeColumn.MinWidth = 75;
            this.MachineryCodeColumn.Name = "MachineryCodeColumn";
            this.MachineryCodeColumn.Visible = true;
            this.MachineryCodeColumn.VisibleIndex = 2;
            // 
            // MachineryTitleColumn
            // 
            this.MachineryTitleColumn.Caption = "دستگاه";
            this.MachineryTitleColumn.FieldName = "Machinery.MachineryTitle";
            this.MachineryTitleColumn.Name = "MachineryTitleColumn";
            this.MachineryTitleColumn.Visible = true;
            this.MachineryTitleColumn.VisibleIndex = 3;
            this.MachineryTitleColumn.Width = 120;
            // 
            // CounterDeviceColumn
            // 
            this.CounterDeviceColumn.AppearanceCell.Options.UseTextOptions = true;
            this.CounterDeviceColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.CounterDeviceColumn.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.CounterDeviceColumn.Caption = "مرکز داده";
            this.CounterDeviceColumn.FieldName = "SubCounterDevice.CounterDevice.CounterTitle";
            this.CounterDeviceColumn.MaxWidth = 100;
            this.CounterDeviceColumn.MinWidth = 100;
            this.CounterDeviceColumn.Name = "CounterDeviceColumn";
            this.CounterDeviceColumn.Visible = true;
            this.CounterDeviceColumn.VisibleIndex = 4;
            this.CounterDeviceColumn.Width = 100;
            // 
            // ApplicantColumn
            // 
            this.ApplicantColumn.Caption = "واحد";
            this.ApplicantColumn.FieldName = "Machinery.Applicant.ApplicantTitle";
            this.ApplicantColumn.MaxWidth = 100;
            this.ApplicantColumn.MinWidth = 100;
            this.ApplicantColumn.Name = "ApplicantColumn";
            this.ApplicantColumn.Visible = true;
            this.ApplicantColumn.VisibleIndex = 1;
            this.ApplicantColumn.Width = 100;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "وضعیت";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.MaxWidth = 60;
            this.colIsActive.MinWidth = 60;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 7;
            this.colIsActive.Width = 60;
            // 
            // colMachinery1
            // 
            this.colMachinery1.Caption = "ترمینال";
            this.colMachinery1.FieldName = "SubCounterDevice.TerminalNumber";
            this.colMachinery1.MaxWidth = 100;
            this.colMachinery1.MinWidth = 100;
            this.colMachinery1.Name = "colMachinery1";
            this.colMachinery1.Visible = true;
            this.colMachinery1.VisibleIndex = 5;
            this.colMachinery1.Width = 100;
            // 
            // colMachinery
            // 
            this.colMachinery.Caption = "واحد سنجش";
            this.colMachinery.FieldName = "SubCounterDevice.UnitOfMeasurement.Unit";
            this.colMachinery.MaxWidth = 100;
            this.colMachinery.MinWidth = 100;
            this.colMachinery.Name = "colMachinery";
            this.colMachinery.Visible = true;
            this.colMachinery.VisibleIndex = 6;
            this.colMachinery.Width = 100;
            // 
            // MachineryCounterDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 531);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MachineryCounterDeviceForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "حسگر دستگاه";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMachineryList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTerminal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCounterDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineryCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachineryCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineryCounterDevicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.LookUpEdit cbxMachineryList;
        private DevExpress.XtraEditors.LookUpEdit cbxTerminal;
        private DevExpress.XtraEditors.LookUpEdit cbxCounterDevice;
        private DevExpress.XtraEditors.LookUpEdit cbxCompany;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl dgvMachineryCounter;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMachineryCounter;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.BindingSource machineryCounterDevicesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn MachineryCodeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn MachineryTitleColumn;
        private DevExpress.XtraGrid.Columns.GridColumn CounterDeviceColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ApplicantColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colMachinery1;
        private DevExpress.XtraGrid.Columns.GridColumn colMachinery;
    }
}