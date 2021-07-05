
namespace PMWORK
{
    partial class LoginForm
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
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetting = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Location = new System.Drawing.Point(435, 146);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(46, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "نام کاربری";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.Location = new System.Drawing.Point(435, 175);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(32, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "گذرواژه";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(396, 332);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ورود";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(288, 332);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(100, 35);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "تنظیمات";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 332);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "بستن";
            // 
            // frmLogin
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 440);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnSetting;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
    }
}

