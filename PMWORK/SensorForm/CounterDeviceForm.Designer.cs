
namespace PMWORK.SensorForm
{
    partial class CounterDeviceForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbxApplicant = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCounterName = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvCounterDevice = new DevExpress.XtraGrid.GridControl();
            this.gvCounterDevice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCounterTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicatinID_FK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dx = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxApplicant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCounterDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(606, 186);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(118, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(12, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Options.UseTextOptions = true;
            this.layoutControl1.Appearance.Control.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.layoutControl1.Controls.Add(this.cbxApplicant);
            this.layoutControl1.Controls.Add(this.cbxCompany);
            this.layoutControl1.Controls.Add(this.txtCounterName);
            this.layoutControl1.Controls.Add(this.txtID);
            this.layoutControl1.Controls.Add(this.chkIsActive);
            this.layoutControl1.Controls.Add(this.txtDescription);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(656, 0, 650, 400);
            this.layoutControl1.OptionsFocus.MoveFocusRightToLeft = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(602, 149);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbxApplicant
            // 
            this.cbxApplicant.Location = new System.Drawing.Point(12, 60);
            this.cbxApplicant.Name = "cbxApplicant";
            this.cbxApplicant.Parmida_ActivePlusMultiKeys = false;
            this.cbxApplicant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxApplicant.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ApplicantTitle", "واحد")});
            this.cbxApplicant.Size = new System.Drawing.Size(273, 20);
            this.cbxApplicant.StyleController = this.layoutControl1;
            this.cbxApplicant.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dx.SetValidationRule(this.cbxApplicant, conditionValidationRule3);
            this.cbxApplicant.EditValueChanged += new System.EventHandler(this.cbxApplicant_EditValueChanged);
            // 
            // cbxCompany
            // 
            this.cbxCompany.Location = new System.Drawing.Point(332, 60);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Parmida_ActivePlusMultiKeys = false;
            this.cbxCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyTitle", "شرکت")});
            this.cbxCompany.Size = new System.Drawing.Size(215, 20);
            this.cbxCompany.StyleController = this.layoutControl1;
            this.cbxCompany.TabIndex = 6;
            this.cbxCompany.EditValueChanged += new System.EventHandler(this.cbxCompany_EditValueChanged);
            // 
            // txtCounterName
            // 
            this.txtCounterName.Location = new System.Drawing.Point(12, 36);
            this.txtCounterName.Name = "txtCounterName";
            this.txtCounterName.Parmida_ActivePlusMultiKeys = false;
            this.txtCounterName.Size = new System.Drawing.Size(535, 20);
            this.txtCounterName.StyleController = this.layoutControl1;
            this.txtCounterName.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dx.SetValidationRule(this.txtCounterName, conditionValidationRule1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(332, 12);
            this.txtID.Name = "txtID";
            this.txtID.Parmida_ActivePlusMultiKeys = false;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(215, 20);
            this.txtID.StyleController = this.layoutControl1;
            this.txtID.TabIndex = 4;
            // 
            // chkIsActive
            // 
            this.chkIsActive.EditValue = true;
            this.chkIsActive.Location = new System.Drawing.Point(12, 12);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Parmida_ActivePlusMultiKeys = false;
            this.chkIsActive.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkIsActive.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkIsActive.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkIsActive.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkIsActive.Properties.Caption = "فعال";
            this.chkIsActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkIsActive.Size = new System.Drawing.Size(273, 19);
            this.chkIsActive.StyleController = this.layoutControl1;
            this.chkIsActive.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 84);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Parmida_ActivePlusMultiKeys = false;
            this.txtDescription.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Size = new System.Drawing.Size(535, 53);
            this.txtDescription.StyleController = this.layoutControl1;
            this.txtDescription.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(602, 149);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtID;
            this.layoutControlItem1.Location = new System.Drawing.Point(320, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(262, 24);
            this.layoutControlItem1.Text = "شناسه";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCounterName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(582, 24);
            this.layoutControlItem2.Text = "مرکزداده";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbxCompany;
            this.layoutControlItem3.Location = new System.Drawing.Point(320, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(262, 24);
            this.layoutControlItem3.Text = "شرکت";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDescription;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(582, 57);
            this.layoutControlItem5.Text = "توضیحات";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbxApplicant;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(320, 24);
            this.layoutControlItem4.Text = "واحد";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkIsActive;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(320, 24);
            this.layoutControlItem6.Text = "وضعیت ";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(40, 13);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvCounterDevice);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 186);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(606, 278);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvCounterDevice
            // 
            this.dgvCounterDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCounterDevice.Location = new System.Drawing.Point(2, 2);
            this.dgvCounterDevice.MainView = this.gvCounterDevice;
            this.dgvCounterDevice.Name = "dgvCounterDevice";
            this.dgvCounterDevice.Size = new System.Drawing.Size(602, 274);
            this.dgvCounterDevice.TabIndex = 0;
            this.dgvCounterDevice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCounterDevice});
            // 
            // gvCounterDevice
            // 
            this.gvCounterDevice.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.Empty.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.OddRow.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.Preview.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.Row.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.VertLine.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvCounterDevice.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCounterDevice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCounterTitle,
            this.colApplicatinID_FK,
            this.colDescription,
            this.colIsActive});
            this.gvCounterDevice.GridControl = this.dgvCounterDevice;
            this.gvCounterDevice.Name = "gvCounterDevice";
            this.gvCounterDevice.OptionsBehavior.Editable = false;
            this.gvCounterDevice.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvCounterDevice.Click += new System.EventHandler(this.gvCounterDevice_Click);
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colID.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colID.Caption = "شناسه";
            this.colID.FieldName = "ID";
            this.colID.MaxWidth = 75;
            this.colID.MinWidth = 75;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCounterTitle
            // 
            this.colCounterTitle.Caption = "مرکز داده";
            this.colCounterTitle.FieldName = "CounterTitle";
            this.colCounterTitle.MaxWidth = 120;
            this.colCounterTitle.MinWidth = 120;
            this.colCounterTitle.Name = "colCounterTitle";
            this.colCounterTitle.Visible = true;
            this.colCounterTitle.VisibleIndex = 1;
            this.colCounterTitle.Width = 120;
            // 
            // colApplicatinID_FK
            // 
            this.colApplicatinID_FK.AppearanceCell.Options.UseTextOptions = true;
            this.colApplicatinID_FK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colApplicatinID_FK.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.colApplicatinID_FK.Caption = "واحد";
            this.colApplicatinID_FK.FieldName = "Applicant.ApplicantTitle";
            this.colApplicatinID_FK.MaxWidth = 120;
            this.colApplicatinID_FK.MinWidth = 120;
            this.colApplicatinID_FK.Name = "colApplicatinID_FK";
            this.colApplicatinID_FK.Visible = true;
            this.colApplicatinID_FK.VisibleIndex = 2;
            this.colApplicatinID_FK.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "توضیحات";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "وضعیت";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.MaxWidth = 60;
            this.colIsActive.MinWidth = 60;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 4;
            this.colIsActive.Width = 60;
            // 
            // CounterDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 464);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CounterDeviceForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مرکز داده";
            this.Load += new System.EventHandler(this.CounterDeviceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxApplicant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCounterDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit cbxApplicant;
        private DevExpress.XtraEditors.LookUpEdit cbxCompany;
        private DevExpress.XtraEditors.TextEdit txtCounterName;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl dgvCounterDevice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCounterDevice;
        private DevExpress.XtraEditors.CheckEdit chkIsActive;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCounterTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicatinID_FK;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dx;
    }
}