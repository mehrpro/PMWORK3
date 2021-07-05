
namespace PMWORK.CodingForms
{
    partial class SubGroupForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubGroupForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxGroup = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gvGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxCompany = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtSubGroupTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtGroupIndex = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyIndex = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.numSubGroup = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvSubGroupList = new DevExpress.XtraGrid.GridControl();
            this.gvSubGroupList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SelectButton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubGroupIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubGroupTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubGroupTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGroupList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubGroupList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cbxGroup);
            this.panelControl1.Controls.Add(this.cbxCompany);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.txtSubGroupTitle);
            this.panelControl1.Controls.Add(this.txtGroupIndex);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtCompanyIndex);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.numSubGroup);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(719, 189);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(465, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(546, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(627, 50);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "گروه اصلی";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(627, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "شرکت";
            // 
            // cbxGroup
            // 
            this.cbxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGroup.Location = new System.Drawing.Point(432, 47);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Parmida_ActivePlusMultiKeys = false;
            this.cbxGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGroup.Properties.PopupView = this.gvGroup;
            this.cbxGroup.Size = new System.Drawing.Size(189, 20);
            this.cbxGroup.TabIndex = 4;
            this.cbxGroup.EditValueChanged += new System.EventHandler(this.cbxGroup_EditValueChanged);
            // 
            // gvGroup
            // 
            this.gvGroup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvGroup.Name = "gvGroup";
            this.gvGroup.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvGroup.OptionsView.ShowGroupPanel = false;
            // 
            // cbxCompany
            // 
            this.cbxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompany.Location = new System.Drawing.Point(432, 21);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Parmida_ActivePlusMultiKeys = false;
            this.cbxCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCompany.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxCompany.Size = new System.Drawing.Size(189, 20);
            this.cbxCompany.TabIndex = 1;
            this.cbxCompany.EditValueChanged += new System.EventHandler(this.cbxCompany_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(129, 125);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Parmida_ActivePlusMultiKeys = false;
            this.txtDescription.Size = new System.Drawing.Size(492, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // txtSubGroupTitle
            // 
            this.txtSubGroupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubGroupTitle.Location = new System.Drawing.Point(432, 99);
            this.txtSubGroupTitle.Name = "txtSubGroupTitle";
            this.txtSubGroupTitle.Parmida_ActivePlusMultiKeys = false;
            this.txtSubGroupTitle.Size = new System.Drawing.Size(189, 20);
            this.txtSubGroupTitle.TabIndex = 9;
            // 
            // txtGroupIndex
            // 
            this.txtGroupIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupIndex.Location = new System.Drawing.Point(371, 47);
            this.txtGroupIndex.Name = "txtGroupIndex";
            this.txtGroupIndex.Parmida_ActivePlusMultiKeys = false;
            this.txtGroupIndex.Properties.DisplayFormat.FormatString = "00";
            this.txtGroupIndex.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtGroupIndex.Properties.ReadOnly = true;
            this.txtGroupIndex.Size = new System.Drawing.Size(55, 20);
            this.txtGroupIndex.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(627, 128);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "توضیحات";
            // 
            // txtCompanyIndex
            // 
            this.txtCompanyIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyIndex.Location = new System.Drawing.Point(371, 21);
            this.txtCompanyIndex.Name = "txtCompanyIndex";
            this.txtCompanyIndex.Parmida_ActivePlusMultiKeys = false;
            this.txtCompanyIndex.Properties.DisplayFormat.FormatString = "00";
            this.txtCompanyIndex.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtCompanyIndex.Properties.ReadOnly = true;
            this.txtCompanyIndex.Size = new System.Drawing.Size(55, 20);
            this.txtCompanyIndex.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(627, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "عنوان گروه فرعی";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(627, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "کد گروه فرعی";
            // 
            // numSubGroup
            // 
            this.numSubGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSubGroup.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numSubGroup.Location = new System.Drawing.Point(546, 73);
            this.numSubGroup.Name = "numSubGroup";
            this.numSubGroup.Parmida_ActivePlusMultiKeys = false;
            this.numSubGroup.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numSubGroup.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numSubGroup.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numSubGroup.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numSubGroup.Properties.DisplayFormat.FormatString = "00";
            this.numSubGroup.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.numSubGroup.Properties.Mask.EditMask = "N00";
            this.numSubGroup.Properties.ReadOnly = true;
            this.numSubGroup.Size = new System.Drawing.Size(75, 20);
            this.numSubGroup.TabIndex = 7;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvSubGroupList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 189);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(719, 261);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvSubGroupList
            // 
            this.dgvSubGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubGroupList.Location = new System.Drawing.Point(2, 2);
            this.dgvSubGroupList.MainView = this.gvSubGroupList;
            this.dgvSubGroupList.Name = "dgvSubGroupList";
            this.dgvSubGroupList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSelect});
            this.dgvSubGroupList.Size = new System.Drawing.Size(715, 257);
            this.dgvSubGroupList.TabIndex = 0;
            this.dgvSubGroupList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSubGroupList});
            // 
            // gvSubGroupList
            // 
            this.gvSubGroupList.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.Empty.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.OddRow.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.Preview.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.Row.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.VertLine.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvSubGroupList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSubGroupList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SelectButton,
            this.ID,
            this.SubGroupIndex,
            this.SubGroupTitle,
            this.Description});
            this.gvSubGroupList.GridControl = this.dgvSubGroupList;
            this.gvSubGroupList.Name = "gvSubGroupList";
            this.gvSubGroupList.OptionsBehavior.ReadOnly = true;
            // 
            // SelectButton
            // 
            this.SelectButton.ColumnEdit = this.btnSelect;
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Visible = true;
            this.SelectButton.VisibleIndex = 0;
            this.SelectButton.Width = 31;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject2.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject3.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject4.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.btnSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSelect.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSelect_ButtonClick);
            // 
            // ID
            // 
            this.ID.Caption = "شناسه";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 1;
            this.ID.Width = 60;
            // 
            // SubGroupIndex
            // 
            this.SubGroupIndex.Caption = "کد گروه فرعی";
            this.SubGroupIndex.DisplayFormat.FormatString = "00";
            this.SubGroupIndex.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SubGroupIndex.FieldName = "SubGroupIndex";
            this.SubGroupIndex.Name = "SubGroupIndex";
            this.SubGroupIndex.Visible = true;
            this.SubGroupIndex.VisibleIndex = 2;
            this.SubGroupIndex.Width = 169;
            // 
            // SubGroupTitle
            // 
            this.SubGroupTitle.Caption = "عنوان گروه فرعی";
            this.SubGroupTitle.FieldName = "SubGroupTitle";
            this.SubGroupTitle.Name = "SubGroupTitle";
            this.SubGroupTitle.Visible = true;
            this.SubGroupTitle.VisibleIndex = 3;
            this.SubGroupTitle.Width = 211;
            // 
            // Description
            // 
            this.Description.Caption = "توضیحات";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            this.Description.Width = 226;
            // 
            // SubGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "SubGroupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گروه فرعی";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubGroupTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGroupList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubGroupList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGroup;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtSubGroupTitle;
        private DevExpress.XtraEditors.TextEdit txtGroupIndex;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCompanyIndex;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgvSubGroupList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSubGroupList;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn SubGroupIndex;
        private DevExpress.XtraGrid.Columns.GridColumn SubGroupTitle;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn SelectButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelect;
        private DevExpress.XtraEditors.TextEdit numSubGroup;
    }
}