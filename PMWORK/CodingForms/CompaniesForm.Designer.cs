
namespace PMWORK.CodingForms
{
    partial class CompaniesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanyTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.numCompanyIndex = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvCompany = new DevExpress.XtraGrid.GridControl();
            this.gvCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SelectedRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelectRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompnayIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyTiltle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompanyIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectRow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.txtCompanyTitle);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.numCompanyIndex);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(647, 137);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(390, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(471, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(565, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "شماره شرکت";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(218, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Parmida_ActivePlusMultiKeys = false;
            this.txtDescription.Size = new System.Drawing.Size(328, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCompanyTitle
            // 
            this.txtCompanyTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyTitle.Location = new System.Drawing.Point(218, 44);
            this.txtCompanyTitle.Name = "txtCompanyTitle";
            this.txtCompanyTitle.Parmida_ActivePlusMultiKeys = false;
            this.txtCompanyTitle.Size = new System.Drawing.Size(328, 20);
            this.txtCompanyTitle.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(565, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "توضیحات";
            // 
            // numCompanyIndex
            // 
            this.numCompanyIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCompanyIndex.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCompanyIndex.Location = new System.Drawing.Point(495, 18);
            this.numCompanyIndex.Name = "numCompanyIndex";
            this.numCompanyIndex.Parmida_ActivePlusMultiKeys = false;
            this.numCompanyIndex.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numCompanyIndex.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numCompanyIndex.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numCompanyIndex.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numCompanyIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numCompanyIndex.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numCompanyIndex.Properties.IsFloatValue = false;
            this.numCompanyIndex.Properties.Mask.EditMask = "N00";
            this.numCompanyIndex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.numCompanyIndex.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCompanyIndex.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCompanyIndex.Properties.ReadOnly = true;
            this.numCompanyIndex.Size = new System.Drawing.Size(51, 20);
            this.numCompanyIndex.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(565, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "نام شرکت";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvCompany);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 137);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(647, 313);
            this.panelControl2.TabIndex = 5;
            // 
            // dgvCompany
            // 
            this.dgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompany.Location = new System.Drawing.Point(2, 2);
            this.dgvCompany.MainView = this.gvCompany;
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSelectRow});
            this.dgvCompany.Size = new System.Drawing.Size(643, 309);
            this.dgvCompany.TabIndex = 0;
            this.dgvCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompany});
            // 
            // gvCompany
            // 
            this.gvCompany.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gvCompany.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gvCompany.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gvCompany.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gvCompany.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.Empty.Options.UseTextOptions = true;
            this.gvCompany.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gvCompany.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gvCompany.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gvCompany.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gvCompany.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvCompany.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvCompany.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvCompany.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gvCompany.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvCompany.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvCompany.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvCompany.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvCompany.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gvCompany.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gvCompany.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.OddRow.Options.UseTextOptions = true;
            this.gvCompany.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.Preview.Options.UseTextOptions = true;
            this.gvCompany.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.Row.Options.UseTextOptions = true;
            this.gvCompany.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gvCompany.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gvCompany.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gvCompany.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.VertLine.Options.UseTextOptions = true;
            this.gvCompany.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvCompany.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SelectedRow,
            this.ID,
            this.CompnayIndex,
            this.CompanyTiltle,
            this.Description});
            this.gvCompany.GridControl = this.dgvCompany;
            this.gvCompany.Name = "gvCompany";
            this.gvCompany.OptionsBehavior.ReadOnly = true;
            this.gvCompany.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // SelectedRow
            // 
            this.SelectedRow.ColumnEdit = this.btnSelectRow;
            this.SelectedRow.Name = "SelectedRow";
            this.SelectedRow.Visible = true;
            this.SelectedRow.VisibleIndex = 0;
            this.SelectedRow.Width = 28;
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
            this.ID.Width = 103;
            // 
            // CompnayIndex
            // 
            this.CompnayIndex.Caption = "کد شرکت";
            this.CompnayIndex.FieldName = "CompnayIndex";
            this.CompnayIndex.Name = "CompnayIndex";
            this.CompnayIndex.Visible = true;
            this.CompnayIndex.VisibleIndex = 2;
            this.CompnayIndex.Width = 87;
            // 
            // CompanyTiltle
            // 
            this.CompanyTiltle.Caption = "نام شرکت یا گروه";
            this.CompanyTiltle.FieldName = "CompanyTiltle";
            this.CompanyTiltle.Name = "CompanyTiltle";
            this.CompanyTiltle.Visible = true;
            this.CompanyTiltle.VisibleIndex = 3;
            this.CompanyTiltle.Width = 198;
            // 
            // Description
            // 
            this.Description.Caption = "توضیحات";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            this.Description.Width = 209;
            // 
            // CompaniesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "CompaniesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "CompaniesForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompanyIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtCompanyTitle;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit numCompanyIndex;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dgvCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCompany;
        private DevExpress.XtraGrid.Columns.GridColumn SelectedRow;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelectRow;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CompnayIndex;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyTiltle;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
    }
}