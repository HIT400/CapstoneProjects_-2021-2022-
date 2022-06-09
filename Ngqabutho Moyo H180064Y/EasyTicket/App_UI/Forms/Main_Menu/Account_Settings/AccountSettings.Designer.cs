namespace EasyTicket.Forms.Main_Menu
{
    partial class AccountSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llUnsubscribe = new System.Windows.Forms.LinkLabel();
            this.llEditPersonalInfo = new System.Windows.Forms.LinkLabel();
            this.llChangePassword = new System.Windows.Forms.LinkLabel();
            this.llMainMenu = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settings";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(454, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.llUnsubscribe);
            this.panel1.Controls.Add(this.llEditPersonalInfo);
            this.panel1.Controls.Add(this.llChangePassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(180, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 194);
            this.panel1.TabIndex = 17;
            // 
            // llUnsubscribe
            // 
            this.llUnsubscribe.AutoSize = true;
            this.llUnsubscribe.Location = new System.Drawing.Point(67, 137);
            this.llUnsubscribe.Name = "llUnsubscribe";
            this.llUnsubscribe.Size = new System.Drawing.Size(66, 13);
            this.llUnsubscribe.TabIndex = 21;
            this.llUnsubscribe.TabStop = true;
            this.llUnsubscribe.Text = "Unsubscribe";
            this.llUnsubscribe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUnsubscribe_LinkClicked);
            // 
            // llEditPersonalInfo
            // 
            this.llEditPersonalInfo.AutoSize = true;
            this.llEditPersonalInfo.Location = new System.Drawing.Point(56, 67);
            this.llEditPersonalInfo.Name = "llEditPersonalInfo";
            this.llEditPersonalInfo.Size = new System.Drawing.Size(90, 13);
            this.llEditPersonalInfo.TabIndex = 18;
            this.llEditPersonalInfo.TabStop = true;
            this.llEditPersonalInfo.Text = "Edit Personal Info";
            this.llEditPersonalInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEditPersonalInfo_LinkClicked);
            // 
            // llChangePassword
            // 
            this.llChangePassword.AutoSize = true;
            this.llChangePassword.Location = new System.Drawing.Point(56, 102);
            this.llChangePassword.Name = "llChangePassword";
            this.llChangePassword.Size = new System.Drawing.Size(93, 13);
            this.llChangePassword.TabIndex = 20;
            this.llChangePassword.TabStop = true;
            this.llChangePassword.Text = "Change Password";
            this.llChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llChangePassword_LinkClicked);
            // 
            // llMainMenu
            // 
            this.llMainMenu.AutoSize = true;
            this.llMainMenu.Location = new System.Drawing.Point(12, 9);
            this.llMainMenu.Name = "llMainMenu";
            this.llMainMenu.Size = new System.Drawing.Size(60, 13);
            this.llMainMenu.TabIndex = 19;
            this.llMainMenu.TabStop = true;
            this.llMainMenu.Text = "Main Menu";
            this.llMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMainMenu_LinkClicked);
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 312);
            this.ControlBox = false;
            this.Controls.Add(this.llMainMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelUsername);
            this.Name = "AccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountSettings_FormClosed);
            this.Load += new System.EventHandler(this.AccountSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llUnsubscribe;
        private System.Windows.Forms.LinkLabel llEditPersonalInfo;
        private System.Windows.Forms.LinkLabel llChangePassword;
        private System.Windows.Forms.LinkLabel llMainMenu;
    }
}