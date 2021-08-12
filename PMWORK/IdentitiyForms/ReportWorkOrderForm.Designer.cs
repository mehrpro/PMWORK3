
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
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel2 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("توقف", new object[] {
            ((object)(12D)),
            ((object)(12D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("دسترس", new object[] {
            ((object)(88D)),
            ((object)(88D))}, 1);
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportWorkOrderForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dgvTotal = new DevExpress.XtraVerticalGrid.VGridControl();
            this.DetailsCategory = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.MachineryNameRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.CodeRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TotalTimeCategory = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.TotalStopTimeRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TotalRepairTimeRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TotalTimeRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TotalRequestCategory = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.TotalRequestRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TotalRepairRequestRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MandeRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.BuildRequestRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvRequestList = new DevExpress.XtraGrid.GridControl();
            this.gvRequestList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestList)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(845, 256);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.chartControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(526, 252);
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
            pieSeriesLabel2.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            series2.Label = pieSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "Series 1";
            seriesPoint3.ColorSerializable = "#C0504D";
            seriesPoint4.ColorSerializable = "#9BBB59";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint3,
            seriesPoint4});
            series2.View = pieSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(522, 248);
            this.chartControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.dgvTotal);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(528, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(315, 252);
            this.panelControl3.TabIndex = 0;
            // 
            // dgvTotal
            // 
            this.dgvTotal.Appearance.BandBorder.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.Category.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.CategoryExpandButton.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.DisabledRecordValue.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.DisabledRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.Empty.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.ExpandButton.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.FilterPanel.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.FixedLine.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.FocusedCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.FocusedRecord.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.FocusedRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.HideSelectionRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.HorzLine.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.ModifiedRecordValue.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.ModifiedRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.PressedRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.ReadOnlyRecordValue.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.ReadOnlyRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.RecordValue.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.RowHeaderPanel.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.SelectedCategory.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.SelectedCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.SelectedRecord.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.SelectedRow.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.Appearance.VertLine.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTotal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dgvTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotal.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.dgvTotal.Location = new System.Drawing.Point(2, 2);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.RecordWidth = 101;
            this.dgvTotal.RowHeaderWidth = 99;
            this.dgvTotal.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.DetailsCategory,
            this.TotalTimeCategory,
            this.TotalRequestCategory});
            this.dgvTotal.Size = new System.Drawing.Size(311, 248);
            this.dgvTotal.TabIndex = 0;
            // 
            // DetailsCategory
            // 
            this.DetailsCategory.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.MachineryNameRow,
            this.CodeRow});
            this.DetailsCategory.Height = 18;
            this.DetailsCategory.Name = "DetailsCategory";
            this.DetailsCategory.Properties.Caption = "مشخصه دستگاه";
            // 
            // MachineryNameRow
            // 
            this.MachineryNameRow.Name = "MachineryNameRow";
            this.MachineryNameRow.Properties.Caption = "نام دستگاه";
            this.MachineryNameRow.Properties.FieldName = "MachineyTitle";
            // 
            // CodeRow
            // 
            this.CodeRow.Name = "CodeRow";
            this.CodeRow.Properties.Caption = "کد دستگاه";
            this.CodeRow.Properties.FieldName = "Code";
            // 
            // TotalTimeCategory
            // 
            this.TotalTimeCategory.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.TotalStopTimeRow,
            this.TotalRepairTimeRow,
            this.TotalTimeRow});
            this.TotalTimeCategory.Name = "TotalTimeCategory";
            this.TotalTimeCategory.Properties.Caption = "کارکرد";
            // 
            // TotalStopTimeRow
            // 
            this.TotalStopTimeRow.Name = "TotalStopTimeRow";
            this.TotalStopTimeRow.Properties.Caption = "مجموع زمان توقف";
            // 
            // TotalRepairTimeRow
            // 
            this.TotalRepairTimeRow.Name = "TotalRepairTimeRow";
            this.TotalRepairTimeRow.Properties.Caption = "مجموع زمان تعمیرات";
            // 
            // TotalTimeRow
            // 
            this.TotalTimeRow.Name = "TotalTimeRow";
            this.TotalTimeRow.Properties.Caption = "کل زمان ";
            // 
            // TotalRequestCategory
            // 
            this.TotalRequestCategory.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.TotalRequestRow,
            this.TotalRepairRequestRow,
            this.MandeRow,
            this.BuildRequestRow});
            this.TotalRequestCategory.Name = "TotalRequestCategory";
            this.TotalRequestCategory.Properties.Caption = "درخواست ها";
            // 
            // TotalRequestRow
            // 
            this.TotalRequestRow.Name = "TotalRequestRow";
            this.TotalRequestRow.Properties.Caption = "کل درخواست ها";
            // 
            // TotalRepairRequestRow
            // 
            this.TotalRepairRequestRow.Name = "TotalRepairRequestRow";
            this.TotalRepairRequestRow.Properties.Caption = "درخواست تعمیر";
            // 
            // MandeRow
            // 
            this.MandeRow.Name = "MandeRow";
            this.MandeRow.Properties.Caption = "درخواست های مانده";
            // 
            // BuildRequestRow
            // 
            this.BuildRequestRow.Name = "BuildRequestRow";
            this.BuildRequestRow.Properties.Caption = "درخواست ساخت وتجهیز";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvRequestList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 256);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(845, 312);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvRequestList
            // 
            this.dgvRequestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequestList.Location = new System.Drawing.Point(2, 2);
            this.dgvRequestList.MainView = this.gvRequestList;
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetails});
            this.dgvRequestList.Size = new System.Drawing.Size(841, 308);
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
            this.gridColumn1,
            this.IDRequestColumn,
            this.RequestTitleColumn,
            this.StatusColumn,
            this.DateTimeColumn,
            this.DetailsColumn,
            this.RequesterColumn});
            this.gvRequestList.GridControl = this.dgvRequestList;
            this.gvRequestList.Name = "gvRequestList";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "#";
            this.gridColumn1.MaxWidth = 30;
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 30;
            // 
            // IDRequestColumn
            // 
            this.IDRequestColumn.Caption = "شناسه";
            this.IDRequestColumn.MaxWidth = 75;
            this.IDRequestColumn.MinWidth = 75;
            this.IDRequestColumn.Name = "IDRequestColumn";
            this.IDRequestColumn.Visible = true;
            this.IDRequestColumn.VisibleIndex = 1;
            // 
            // RequestTitleColumn
            // 
            this.RequestTitleColumn.Caption = "شرح درخواست";
            this.RequestTitleColumn.Name = "RequestTitleColumn";
            this.RequestTitleColumn.Visible = true;
            this.RequestTitleColumn.VisibleIndex = 4;
            this.RequestTitleColumn.Width = 161;
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
            this.StatusColumn.VisibleIndex = 5;
            this.StatusColumn.Width = 120;
            // 
            // DateTimeColumn
            // 
            this.DateTimeColumn.Caption = "تاریخ";
            this.DateTimeColumn.MaxWidth = 100;
            this.DateTimeColumn.MinWidth = 100;
            this.DateTimeColumn.Name = "DateTimeColumn";
            this.DateTimeColumn.Visible = true;
            this.DateTimeColumn.VisibleIndex = 2;
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
            this.DetailsColumn.VisibleIndex = 6;
            // 
            // btnDetails
            // 
            this.btnDetails.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            serializableAppearanceObject5.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject6.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject7.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject8.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.btnDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.RequesterColumn.VisibleIndex = 3;
            this.RequesterColumn.Width = 120;
            // 
            // ReportWorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 568);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ReportWorkOrderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "کارنامه تعمیراتی دستگاه";
            this.Load += new System.EventHandler(this.ReportWorkOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dgvRequestList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRequestList;
        private DevExpress.XtraGrid.Columns.GridColumn IDRequestColumn;
        private DevExpress.XtraGrid.Columns.GridColumn RequestTitleColumn;
        private DevExpress.XtraGrid.Columns.GridColumn StatusColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DateTimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DetailsColumn;
        private DevExpress.XtraGrid.Columns.GridColumn RequesterColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetails;
        private DevExpress.XtraVerticalGrid.VGridControl dgvTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow DetailsCategory;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MachineryNameRow;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow CodeRow;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow TotalTimeCategory;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TotalStopTimeRow;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TotalRepairTimeRow;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TotalTimeRow;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow TotalRequestCategory;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TotalRequestRow;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TotalRepairRequestRow;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MandeRow;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow BuildRequestRow;
    }
    }