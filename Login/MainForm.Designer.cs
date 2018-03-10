﻿namespace Login
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
            this.cbbAccounts = new System.Windows.Forms.ComboBox();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbAccounts
            // 
            this.cbbAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAccounts.FormattingEnabled = true;
            this.cbbAccounts.Location = new System.Drawing.Point(94, 2);
            this.cbbAccounts.Name = "cbbAccounts";
            this.cbbAccounts.Size = new System.Drawing.Size(187, 41);
            this.cbbAccounts.TabIndex = 1;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyPassword.BackgroundImage = global::Login.Properties.Resources.paste;
            this.btnCopyPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPassword.Location = new System.Drawing.Point(47, 2);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(41, 41);
            this.btnCopyPassword.TabIndex = 3;
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackgroundImage = global::Login.Properties.Resources.arrow_r;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(287, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(41, 41);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TabStop = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.BackgroundImage = global::Login.Properties.Resources.setting1;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(0, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(41, 41);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 45);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbbAccounts);
            this.Controls.Add(this.btnSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 72);
            this.MinimumSize = new System.Drawing.Size(333, 72);
            this.Name = "MainForm";
            this.Text = "MU Legend";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.ComboBox cbbAccounts;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCopyPassword;
    }
}

