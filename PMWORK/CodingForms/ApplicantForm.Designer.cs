
namespace PMWORK.CodingForms
{
    partial class ApplicantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtApplicantTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxCompany = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvApplicantList = new DevExpress.XtraGrid.GridControl();
            this.gvApplicantList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnSelectRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelectRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApplicantTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicantList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplicantList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.txtApplicantTitle);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cbxCompany);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(473, 145);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(19, 104);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(105, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(19, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Parmida_ActivePlusMultiKeys = false;
            this.txtDescription.Size = new System.Drawing.Size(386, 20);
            this.txtDescription.TabIndex = 12;
            // 
            // txtApplicantTitle
            // 
            this.txtApplicantTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplicantTitle.Location = new System.Drawing.Point(216, 52);
            this.txtApplicantTitle.Name = "txtApplicantTitle";
            this.txtApplicantTitle.Parmida_ActivePlusMultiKeys = false;
            this.txtApplicantTitle.Size = new System.Drawing.Size(189, 20);
            this.txtApplicantTitle.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(411, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "توضیحات";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(411, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "نام واحد";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(411, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "شرکت";
            // 
            // cbxCompany
            // 
            this.cbxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompany.Location = new System.Drawing.Point(216, 26);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Parmida_ActivePlusMultiKeys = false;
            this.cbxCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCompany.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxCompany.Size = new System.Drawing.Size(189, 20);
            this.cbxCompany.TabIndex = 4;
            this.cbxCompany.EditValueChanged += new System.EventHandler(this.cbxCompany_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dgvApplicantList
            // 
            this.dgvApplicantList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplicantList.Location = new System.Drawing.Point(0, 145);
            this.dgvApplicantList.MainView = this.gvApplicantList;
            this.dgvApplicantList.Name = "dgvApplicantList";
            this.dgvApplicantList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSelectRow,
            this.repositoryItemMemoExEdit1});
            this.dgvApplicantList.Size = new System.Drawing.Size(473, 302);
            this.dgvApplicantList.TabIndex = 1;
            this.dgvApplicantList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvApplicantList});
            // 
            // gvApplicantList
            // 
            this.gvApplicantList.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.Empty.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.OddRow.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.Preview.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.Row.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.VertLine.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvApplicantList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvApplicantList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnSelectRow,
            this.ColumnID,
            this.ColumnTitle,
            this.ColumnDescription});
            this.gvApplicantList.GridControl = this.dgvApplicantList;
            this.gvApplicantList.Name = "gvApplicantList";
            this.gvApplicantList.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnSelectRow
            // 
            this.ColumnSelectRow.ColumnEdit = this.btnSelectRow;
            this.ColumnSelectRow.Name = "ColumnSelectRow";
            this.ColumnSelectRow.Visible = true;
            this.ColumnSelectRow.VisibleIndex = 0;
            this.ColumnSelectRow.Width = 32;
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
            // ColumnID
            // 
            this.ColumnID.Caption = "شناسه";
            this.ColumnID.FieldName = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = true;
            this.ColumnID.VisibleIndex = 1;
            this.ColumnID.Width = 60;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.Caption = "عنوان";
            this.ColumnTitle.FieldName = "ApplicantTitle";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.Visible = true;
            this.ColumnTitle.VisibleIndex = 2;
            this.ColumnTitle.Width = 228;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.Caption = "توضیحات";
            this.ColumnDescription.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.ColumnDescription.FieldName = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.Visible = true;
            this.ColumnDescription.VisibleIndex = 3;
            this.ColumnDescription.Width = 135;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // ApplicantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 447);
            this.Controls.Add(this.dgvApplicantList);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicantForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "واحدهای ادواری";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApplicantTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicantList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplicantList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtApplicantTitle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl dgvApplicantList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvApplicantList;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSelectRow;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelectRow;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnTitle;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnID;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}