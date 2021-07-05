
namespace PMWORK
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.grpAdministrator = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmApplicationUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.grpInfrastructure = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmMachinery = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.grpCoding = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmCompany = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmGroups = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmSubGroups = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmCodings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmUnits = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.grpRepair = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itmRequestRepair = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.grpMaintanace = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.grpAdministrator,
            this.grpInfrastructure,
            this.grpCoding,
            this.grpRepair,
            this.grpMaintanace});
            this.accordionControl1.Location = new System.Drawing.Point(357, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(226, 498);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // grpAdministrator
            // 
            this.grpAdministrator.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itmApplicationUser});
            this.grpAdministrator.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpAdministrator.ImageOptions.Image")));
            this.grpAdministrator.Name = "grpAdministrator";
            this.grpAdministrator.Text = "مدیریت نرم افزار";
            // 
            // itmApplicationUser
            // 
            this.itmApplicationUser.Name = "itmApplicationUser";
            this.itmApplicationUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmApplicationUser.Text = "مدیریت کاربران";
            // 
            // grpInfrastructure
            // 
            this.grpInfrastructure.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itmMachinery});
            this.grpInfrastructure.Expanded = true;
            this.grpInfrastructure.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpInfrastructure.ImageOptions.Image")));
            this.grpInfrastructure.Name = "grpInfrastructure";
            this.grpInfrastructure.Text = "زیرساخت";
            // 
            // itmMachinery
            // 
            this.itmMachinery.Name = "itmMachinery";
            this.itmMachinery.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmMachinery.Text = "ماشین آلات";
            this.itmMachinery.Click += new System.EventHandler(this.itmMachinery_Click);
            // 
            // grpCoding
            // 
            this.grpCoding.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itmCompany,
            this.itmGroups,
            this.itmSubGroups,
            this.itmCodings,
            this.itmUnits});
            this.grpCoding.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpCoding.ImageOptions.Image")));
            this.grpCoding.Name = "grpCoding";
            this.grpCoding.Text = "کدینگ";
            // 
            // itmCompany
            // 
            this.itmCompany.Name = "itmCompany";
            this.itmCompany.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmCompany.Text = "شرکت ها";
            this.itmCompany.Click += new System.EventHandler(this.itmCompany_Click);
            // 
            // itmGroups
            // 
            this.itmGroups.Name = "itmGroups";
            this.itmGroups.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmGroups.Text = "گروه اصلی";
            this.itmGroups.Click += new System.EventHandler(this.itmGroups_Click);
            // 
            // itmSubGroups
            // 
            this.itmSubGroups.Name = "itmSubGroups";
            this.itmSubGroups.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmSubGroups.Text = "گروه فرعی";
            this.itmSubGroups.Click += new System.EventHandler(this.itmSubGroups_Click);
            // 
            // itmCodings
            // 
            this.itmCodings.Name = "itmCodings";
            this.itmCodings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmCodings.Text = "کدگذاری";
            this.itmCodings.Click += new System.EventHandler(this.itmCodings_Click);
            // 
            // itmUnits
            // 
            this.itmUnits.Name = "itmUnits";
            this.itmUnits.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmUnits.Text = "واحد سنجش";
            this.itmUnits.Click += new System.EventHandler(this.itmUnits_Click);
            // 
            // grpRepair
            // 
            this.grpRepair.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itmRequestRepair});
            this.grpRepair.Expanded = true;
            this.grpRepair.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpRepair.ImageOptions.Image")));
            this.grpRepair.Name = "grpRepair";
            this.grpRepair.Text = "تعمیرگاه";
            // 
            // itmRequestRepair
            // 
            this.itmRequestRepair.Name = "itmRequestRepair";
            this.itmRequestRepair.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itmRequestRepair.Text = "درخواست تعمیر";
            this.itmRequestRepair.Click += new System.EventHandler(this.itmRequestRepair_Click);
            // 
            // grpMaintanace
            // 
            this.grpMaintanace.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpMaintanace.ImageOptions.Image")));
            this.grpMaintanace.Name = "grpMaintanace";
            this.grpMaintanace.Text = "نگهداری تعمیرات";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 498);
            this.Controls.Add(this.accordionControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اتوماسیون نت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement grpAdministrator;
        private DevExpress.XtraBars.Navigation.AccordionControlElement grpInfrastructure;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmApplicationUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmMachinery;
        private DevExpress.XtraBars.Navigation.AccordionControlElement grpCoding;
        private DevExpress.XtraBars.Navigation.AccordionControlElement grpRepair;
        private DevExpress.XtraBars.Navigation.AccordionControlElement grpMaintanace;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmCompany;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmGroups;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmSubGroups;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmCodings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmUnits;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itmRequestRepair;
    }
}