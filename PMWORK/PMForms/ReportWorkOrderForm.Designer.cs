
namespace PMWORK.PMForms
    {
    partial class ReportWorkOrderForm
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("توقف", new object[] {
            ((object)(12D)),
            ((object)(12D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("دسترس", new object[] {
            ((object)(88D)),
            ((object)(88D))}, 1);
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportWorkOrderForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.category = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.row2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDRequestColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestTitleColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateTimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DetailsColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RequesterColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(703, 256);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.chartControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(384, 252);
            this.panelControl4.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.chartControl1.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.chartControl1.Legend.Border.Color = System.Drawing.Color.Black;
            this.chartControl1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.TextColor = System.Drawing.Color.Black;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Location = new System.Drawing.Point(2, 2);
            this.chartControl1.Name = "chartControl1";
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            series1.Label = pieSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Series 1";
            seriesPoint1.ColorSerializable = "#C0504D";
            seriesPoint2.ColorSerializable = "#9BBB59";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2});
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(380, 248);
            this.chartControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.vGridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(386, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(315, 252);
            this.panelControl3.TabIndex = 0;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Appearance.BandBorder.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.Category.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.CategoryExpandButton.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.DisabledRecordValue.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.DisabledRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.Empty.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.ExpandButton.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.FilterPanel.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.FixedLine.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.FocusedCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.FocusedRecord.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.FocusedRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.HideSelectionRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.HorzLine.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.ModifiedRecordValue.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.ModifiedRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.PressedRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.ReadOnlyRecordValue.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.ReadOnlyRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.RecordValue.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.RowHeaderPanel.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.SelectedCategory.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.SelectedCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.SelectedRecord.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.SelectedRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Appearance.VertLine.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(2, 2);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.category,
            this.category1});
            this.vGridControl1.Size = new System.Drawing.Size(311, 248);
            this.vGridControl1.TabIndex = 0;
            // 
            // category
            // 
            this.category.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row,
            this.row1});
            this.category.Name = "category";
            this.category.Properties.Caption = "شاخص";
            // 
            // row
            // 
            this.row.Name = "row";
            this.row.Properties.Caption = "MTTR";
            // 
            // row1
            // 
            this.row1.Name = "row1";
            this.row1.Properties.Caption = "MTBF";
            // 
            // category1
            // 
            this.category1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row2,
            this.row3,
            this.row4});
            this.category1.Name = "category1";
            this.category1.Properties.Caption = "کارکرد";
            // 
            // row2
            // 
            this.row2.Name = "row2";
            this.row2.Properties.Caption = "مجموع زمان توقف";
            // 
            // row3
            // 
            this.row3.Name = "row3";
            this.row3.Properties.Caption = "مجموع زمان تعمیرات";
            // 
            // row4
            // 
            this.row4.Name = "row4";
            this.row4.Properties.Caption = "کل زمان ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 256);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(703, 256);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetails});
            this.gridControl1.Size = new System.Drawing.Size(699, 252);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDRequestColumn,
            this.RequestTitleColumn,
            this.StatusColumn,
            this.DateTimeColumn,
            this.DetailsColumn,
            this.RequesterColumn});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // IDRequestColumn
            // 
            this.IDRequestColumn.Caption = "شماره تعمیر";
            this.IDRequestColumn.MaxWidth = 90;
            this.IDRequestColumn.MinWidth = 90;
            this.IDRequestColumn.Name = "IDRequestColumn";
            this.IDRequestColumn.Visible = true;
            this.IDRequestColumn.VisibleIndex = 0;
            this.IDRequestColumn.Width = 90;
            // 
            // RequestTitleColumn
            // 
            this.RequestTitleColumn.Caption = "شرح درخواست";
            this.RequestTitleColumn.Name = "RequestTitleColumn";
            this.RequestTitleColumn.Visible = true;
            this.RequestTitleColumn.VisibleIndex = 3;
            this.RequestTitleColumn.Width = 567;
            // 
            // StatusColumn
            // 
            this.StatusColumn.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusColumn.AppearanceCell.Options.UseForeColor = true;
            this.StatusColumn.Caption = "وضعیت درخواست";
            this.StatusColumn.MaxWidth = 120;
            this.StatusColumn.MinWidth = 120;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Visible = true;
            this.StatusColumn.VisibleIndex = 4;
            this.StatusColumn.Width = 120;
            // 
            // DateTimeColumn
            // 
            this.DateTimeColumn.Caption = "تاریخ";
            this.DateTimeColumn.MaxWidth = 100;
            this.DateTimeColumn.MinWidth = 100;
            this.DateTimeColumn.Name = "DateTimeColumn";
            this.DateTimeColumn.Visible = true;
            this.DateTimeColumn.VisibleIndex = 1;
            this.DateTimeColumn.Width = 100;
            // 
            // DetailsColumn
            // 
            this.DetailsColumn.Caption = "جزئیات";
            this.DetailsColumn.ColumnEdit = this.btnDetails;
            this.DetailsColumn.MaxWidth = 75;
            this.DetailsColumn.MinWidth = 75;
            this.DetailsColumn.Name = "DetailsColumn";
            this.DetailsColumn.Visible = true;
            this.DetailsColumn.VisibleIndex = 5;
            // 
            // btnDetails
            // 
            this.btnDetails.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject2.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject3.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject4.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.btnDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // RequesterColumn
            // 
            this.RequesterColumn.Caption = "درخواست کننده";
            this.RequesterColumn.MaxWidth = 120;
            this.RequesterColumn.MinWidth = 120;
            this.RequesterColumn.Name = "RequesterColumn";
            this.RequesterColumn.Visible = true;
            this.RequesterColumn.VisibleIndex = 2;
            this.RequesterColumn.Width = 120;
            // 
            // ReportWorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 512);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ReportWorkOrderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "سوابق تعمیراتی دستگاه";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDRequestColumn;
        private DevExpress.XtraGrid.Columns.GridColumn RequestTitleColumn;
        private DevExpress.XtraGrid.Columns.GridColumn StatusColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DateTimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DetailsColumn;
        private DevExpress.XtraGrid.Columns.GridColumn RequesterColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetails;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row4;
        }
    }