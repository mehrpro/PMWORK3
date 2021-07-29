
namespace PMWORK.Admin
{
    partial class UserAccessForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbxUserList = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chkListPageGroup = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.radioGroupRibbonPage = new DevExpress.XtraEditors.RadioGroup();
            this.UsernameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUserList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkListPageGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRibbonPage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbxUserList);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 70);
            this.panelControl1.TabIndex = 0;
            // 
            // cbxUserList
            // 
            this.cbxUserList.Location = new System.Drawing.Point(504, 27);
            this.cbxUserList.Name = "cbxUserList";
            this.cbxUserList.Parmida_ActivePlusMultiKeys = false;
            this.cbxUserList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxUserList.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxUserList.Size = new System.Drawing.Size(239, 20);
            this.cbxUserList.TabIndex = 1;
            this.cbxUserList.EditValueChanged += new System.EventHandler(this.cbxUserList_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UsernameColumn,
            this.FullNameColumn,
            this.CompanyColumn});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(749, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "کاربر";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chkListPageGroup);
            this.panelControl2.Controls.Add(this.radioGroupRibbonPage);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 70);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 380);
            this.panelControl2.TabIndex = 1;
            // 
            // chkListPageGroup
            // 
            this.chkListPageGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkListPageGroup.Location = new System.Drawing.Point(223, 2);
            this.chkListPageGroup.Name = "chkListPageGroup";
            this.chkListPageGroup.Size = new System.Drawing.Size(347, 376);
            this.chkListPageGroup.TabIndex = 1;
            // 
            // radioGroupRibbonPage
            // 
            this.radioGroupRibbonPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioGroupRibbonPage.Location = new System.Drawing.Point(570, 2);
            this.radioGroupRibbonPage.Name = "radioGroupRibbonPage";
            this.radioGroupRibbonPage.Parmida_ActivePlusMultiKeys = false;
            this.radioGroupRibbonPage.Size = new System.Drawing.Size(228, 376);
            this.radioGroupRibbonPage.TabIndex = 0;
            this.radioGroupRibbonPage.SelectedIndexChanged += new System.EventHandler(this.radioGroupRibbonPage_SelectedIndexChanged);
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.Caption = "نام کاربری";
            this.UsernameColumn.FieldName = "UserName";
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.Visible = true;
            this.UsernameColumn.VisibleIndex = 0;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.Caption = "نام";
            this.FullNameColumn.FieldName = "FullName";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.Visible = true;
            this.FullNameColumn.VisibleIndex = 1;
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.Caption = "شرکت";
            this.CompanyColumn.FieldName = "Company.CompanyTitle";
            this.CompanyColumn.Name = "CompanyColumn";
            this.CompanyColumn.Visible = true;
            this.CompanyColumn.VisibleIndex = 2;
            // 
            // UserAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "UserAccessForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "دسترسی کاربران";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUserList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkListPageGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRibbonPage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl chkListPageGroup;
        private DevExpress.XtraEditors.RadioGroup radioGroupRibbonPage;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn UsernameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn FullNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyColumn;
    }
}