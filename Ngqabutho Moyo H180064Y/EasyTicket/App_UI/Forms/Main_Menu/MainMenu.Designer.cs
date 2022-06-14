<<<<<<< HEAD
﻿namespace EasyTicket.Forms.Main_Menu
{
    partial class Main_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.llLogout = new System.Windows.Forms.LinkLabel();
            this.llAccountSettings = new System.Windows.Forms.LinkLabel();
            this.llTripHistory = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.llTopupAccount = new System.Windows.Forms.LinkLabel();
            this.llPay = new System.Windows.Forms.LinkLabel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.llLogout);
            this.panel1.Controls.Add(this.llAccountSettings);
            this.panel1.Controls.Add(this.llTripHistory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.llTopupAccount);
            this.panel1.Controls.Add(this.llPay);
            this.panel1.Location = new System.Drawing.Point(184, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 208);
            this.panel1.TabIndex = 13;
            // 
            // llLogout
            // 
            this.llLogout.AutoSize = true;
            this.llLogout.Location = new System.Drawing.Point(21, 169);
            this.llLogout.Name = "llLogout";
            this.llLogout.Size = new System.Drawing.Size(40, 13);
            this.llLogout.TabIndex = 22;
            this.llLogout.TabStop = true;
            this.llLogout.Text = "Logout";
            this.llLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogout_LinkClicked);
            // 
            // llAccountSettings
            // 
            this.llAccountSettings.AutoSize = true;
            this.llAccountSettings.Location = new System.Drawing.Point(21, 64);
            this.llAccountSettings.Name = "llAccountSettings";
            this.llAccountSettings.Size = new System.Drawing.Size(88, 13);
            this.llAccountSettings.TabIndex = 18;
            this.llAccountSettings.TabStop = true;
            this.llAccountSettings.Text = "Account Settings";
            this.llAccountSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAccountSettings_LinkClicked);
            // 
            // llTripHistory
            // 
            this.llTripHistory.AutoSize = true;
            this.llTripHistory.Location = new System.Drawing.Point(21, 140);
            this.llTripHistory.Name = "llTripHistory";
            this.llTripHistory.Size = new System.Drawing.Size(60, 13);
            this.llTripHistory.TabIndex = 21;
            this.llTripHistory.TabStop = true;
            this.llTripHistory.Text = "Trip History";
            this.llTripHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTripHistory_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Main Menu";
            // 
            // llTopupAccount
            // 
            this.llTopupAccount.AutoSize = true;
            this.llTopupAccount.Location = new System.Drawing.Point(21, 115);
            this.llTopupAccount.Name = "llTopupAccount";
            this.llTopupAccount.Size = new System.Drawing.Size(38, 13);
            this.llTopupAccount.TabIndex = 20;
            this.llTopupAccount.TabStop = true;
            this.llTopupAccount.Text = "Topup";
            this.llTopupAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTopupAccount_LinkClicked);
            // 
            // llPay
            // 
            this.llPay.AutoSize = true;
            this.llPay.Location = new System.Drawing.Point(21, 88);
            this.llPay.Name = "llPay";
            this.llPay.Size = new System.Drawing.Size(25, 13);
            this.llPay.TabIndex = 19;
            this.llPay.TabStop = true;
            this.llPay.Text = "Pay";
            this.llPay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPay_LinkClicked);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(485, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Username";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 333);
            this.ControlBox = false;
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llLogout;
        private System.Windows.Forms.LinkLabel llAccountSettings;
        private System.Windows.Forms.LinkLabel llTripHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llTopupAccount;
        private System.Windows.Forms.LinkLabel llPay;
        private System.Windows.Forms.Label labelUsername;
    }
=======
﻿namespace EasyTicket.Forms.Main_Menu
{
    partial class Main_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.llLogout = new System.Windows.Forms.LinkLabel();
            this.llAccountSettings = new System.Windows.Forms.LinkLabel();
            this.llTripHistory = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.llTopupAccount = new System.Windows.Forms.LinkLabel();
            this.llPay = new System.Windows.Forms.LinkLabel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.llLogout);
            this.panel1.Controls.Add(this.llAccountSettings);
            this.panel1.Controls.Add(this.llTripHistory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.llTopupAccount);
            this.panel1.Controls.Add(this.llPay);
            this.panel1.Location = new System.Drawing.Point(184, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 208);
            this.panel1.TabIndex = 13;
            // 
            // llLogout
            // 
            this.llLogout.AutoSize = true;
            this.llLogout.Location = new System.Drawing.Point(21, 169);
            this.llLogout.Name = "llLogout";
            this.llLogout.Size = new System.Drawing.Size(40, 13);
            this.llLogout.TabIndex = 22;
            this.llLogout.TabStop = true;
            this.llLogout.Text = "Logout";
            this.llLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogout_LinkClicked);
            // 
            // llAccountSettings
            // 
            this.llAccountSettings.AutoSize = true;
            this.llAccountSettings.Location = new System.Drawing.Point(21, 64);
            this.llAccountSettings.Name = "llAccountSettings";
            this.llAccountSettings.Size = new System.Drawing.Size(88, 13);
            this.llAccountSettings.TabIndex = 18;
            this.llAccountSettings.TabStop = true;
            this.llAccountSettings.Text = "Account Settings";
            this.llAccountSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAccountSettings_LinkClicked);
            // 
            // llTripHistory
            // 
            this.llTripHistory.AutoSize = true;
            this.llTripHistory.Location = new System.Drawing.Point(21, 140);
            this.llTripHistory.Name = "llTripHistory";
            this.llTripHistory.Size = new System.Drawing.Size(60, 13);
            this.llTripHistory.TabIndex = 21;
            this.llTripHistory.TabStop = true;
            this.llTripHistory.Text = "Trip History";
            this.llTripHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTripHistory_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Main Menu";
            // 
            // llTopupAccount
            // 
            this.llTopupAccount.AutoSize = true;
            this.llTopupAccount.Location = new System.Drawing.Point(21, 115);
            this.llTopupAccount.Name = "llTopupAccount";
            this.llTopupAccount.Size = new System.Drawing.Size(38, 13);
            this.llTopupAccount.TabIndex = 20;
            this.llTopupAccount.TabStop = true;
            this.llTopupAccount.Text = "Topup";
            this.llTopupAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTopupAccount_LinkClicked);
            // 
            // llPay
            // 
            this.llPay.AutoSize = true;
            this.llPay.Location = new System.Drawing.Point(21, 88);
            this.llPay.Name = "llPay";
            this.llPay.Size = new System.Drawing.Size(25, 13);
            this.llPay.TabIndex = 19;
            this.llPay.TabStop = true;
            this.llPay.Text = "Pay";
            this.llPay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPay_LinkClicked);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(485, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Username";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 333);
            this.ControlBox = false;
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llLogout;
        private System.Windows.Forms.LinkLabel llAccountSettings;
        private System.Windows.Forms.LinkLabel llTripHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llTopupAccount;
        private System.Windows.Forms.LinkLabel llPay;
        private System.Windows.Forms.Label labelUsername;
    }
>>>>>>> parent of 5a30ca7... commit message
}