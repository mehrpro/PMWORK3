
namespace PMWORK.CodingForms
{
    partial class GroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxCompany = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtGroupTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyIndex = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.numGroup = new DevExpress.XtraEditors.SpinEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvGroupList = new DevExpress.XtraGrid.GridControl();
            this.gvGroupList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SelectRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelectRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectRow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cbxCompany);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.txtGroupTitle);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtCompanyIndex);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.numGroup);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(685, 161);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(432, 126);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(513, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(594, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "شرکت";
            // 
            // cbxCompany
            // 
            this.cbxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompany.Location = new System.Drawing.Point(399, 22);
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
            this.txtDescription.Location = new System.Drawing.Point(96, 100);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Parmida_ActivePlusMultiKeys = false;
            this.txtDescription.Size = new System.Drawing.Size(492, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // txtGroupTitle
            // 
            this.txtGroupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupTitle.Location = new System.Drawing.Point(399, 74);
            this.txtGroupTitle.Name = "txtGroupTitle";
            this.txtGroupTitle.Parmida_ActivePlusMultiKeys = false;
            this.txtGroupTitle.Size = new System.Drawing.Size(189, 20);
            this.txtGroupTitle.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(594, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "توضیحات";
            // 
            // txtCompanyIndex
            // 
            this.txtCompanyIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyIndex.Location = new System.Drawing.Point(338, 22);
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
            this.labelControl2.Location = new System.Drawing.Point(594, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "عنوان گروه";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(594, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "کد گروه اصلی";
            // 
            // numGroup
            // 
            this.numGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numGroup.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numGroup.Location = new System.Drawing.Point(530, 48);
            this.numGroup.Name = "numGroup";
            this.numGroup.Parmida_ActivePlusMultiKeys = false;
            this.numGroup.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numGroup.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numGroup.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numGroup.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numGroup.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numGroup.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.numGroup.Properties.ReadOnly = true;
            this.numGroup.Size = new System.Drawing.Size(58, 20);
            this.numGroup.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvGroupList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 161);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(685, 289);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvGroupList
            // 
            this.dgvGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroupList.Location = new System.Drawing.Point(2, 2);
            this.dgvGroupList.MainView = this.gvGroupList;
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSelectRow});
            this.dgvGroupList.Size = new System.Drawing.Size(681, 285);
            this.dgvGroupList.TabIndex = 0;
            this.dgvGroupList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGroupList});
            // 
            // gvGroupList
            // 
            this.gvGroupList.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.Empty.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.OddRow.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.Preview.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.Row.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.VertLine.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvGroupList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvGroupList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SelectRow,
            this.ID,
            this.GroupIndex,
            this.GroupTitle,
            this.Description});
            this.gvGroupList.GridControl = this.dgvGroupList;
            this.gvGroupList.Name = "gvGroupList";
            this.gvGroupList.OptionsBehavior.ReadOnly = true;
            // 
            // SelectRow
            // 
            this.SelectRow.ColumnEdit = this.btnSelectRow;
            this.SelectRow.Name = "SelectRow";
            this.SelectRow.Visible = true;
            this.SelectRow.VisibleIndex = 0;
            this.SelectRow.Width = 29;
            // 
            // btnSelectRow
            // 
            this.btnSelectRow.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject2.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject3.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject4.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.btnSelectRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSelectRow.Name = "btnSelectRow";
            this.btnSelectRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSelectRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSelectRow_ButtonClick);
            // 
            // ID
            // 
            this.ID.Caption = "شناسه";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 1;
            this.ID.Width = 97;
            // 
            // GroupIndex
            // 
            this.GroupIndex.Caption = "کد گروه اصلی";
            this.GroupIndex.FieldName = "GroupIndex";
            this.GroupIndex.Name = "GroupIndex";
            this.GroupIndex.Visible = true;
            this.GroupIndex.VisibleIndex = 2;
            this.GroupIndex.Width = 128;
            // 
            // GroupTitle
            // 
            this.GroupTitle.Caption = "عنوان گروه اصلی";
            this.GroupTitle.FieldName = "GroupTitle";
            this.GroupTitle.Name = "GroupTitle";
            this.GroupTitle.Visible = true;
            this.GroupTitle.VisibleIndex = 3;
            this.GroupTitle.Width = 177;
            // 
            // Description
            // 
            this.Description.Caption = "توضیحات";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            this.Description.Width = 232;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "GroupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گروه اصلی";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtGroupTitle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCompanyIndex;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit numGroup;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dgvGroupList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGroupList;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn GroupIndex;
        private DevExpress.XtraGrid.Columns.GridColumn GroupTitle;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn SelectRow;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelectRow;
    }
}