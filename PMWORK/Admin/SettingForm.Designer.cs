
namespace PMWORK.Admin
{
    partial class SettingForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cbxServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxAuthentication = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAuthentication.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(96, 89);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Parmida_ActivePlusMultiKeys = false;
            this.txtDatabase.Size = new System.Drawing.Size(271, 20);
            this.txtDatabase.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(68, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "User";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(44, 170);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(96, 141);
            this.txtUser.Name = "txtUser";
            this.txtUser.Parmida_ActivePlusMultiKeys = false;
            this.txtUser.Size = new System.Drawing.Size(271, 20);
            this.txtUser.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Parmida_ActivePlusMultiKeys = false;
            this.txtPassword.Size = new System.Drawing.Size(271, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(211, 193);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(292, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            // 
            // cbxServer
            // 
            this.cbxServer.Location = new System.Drawing.Point(96, 63);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Parmida_ActivePlusMultiKeys = false;
            this.cbxServer.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxServer.Size = new System.Drawing.Size(271, 20);
            this.cbxServer.TabIndex = 1;
            // 
            // cbxAuthentication
            // 
            this.cbxAuthentication.EditValue = "Windows Authentication";
            this.cbxAuthentication.Location = new System.Drawing.Point(96, 115);
            this.cbxAuthentication.Name = "cbxAuthentication";
            this.cbxAuthentication.Parmida_ActivePlusMultiKeys = false;
            this.cbxAuthentication.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxAuthentication.Properties.DropDownRows = 3;
            this.cbxAuthentication.Properties.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbxAuthentication.Size = new System.Drawing.Size(271, 20);
            this.cbxAuthentication.TabIndex = 1;
            this.cbxAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbxAuthentication_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Authentication";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(105, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(177, 23);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Database Connection";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 233);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbxAuthentication);
            this.Controls.Add(this.cbxServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingForm";
            this.Text = "Connection ";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAuthentication.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.ComboBoxEdit cbxServer;
        private DevExpress.XtraEditors.ComboBoxEdit cbxAuthentication;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}