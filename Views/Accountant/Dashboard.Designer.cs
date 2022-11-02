
namespace webTRON_Management_Software.Views.Accountant
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.actveForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSearchPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreatePatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnRenewPatient = new Guna.UI2.WinForms.Guna2Button();
            this.dragableAccountantDashboard = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sidebarPanel.SuspendLayout();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSignOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(-1, -1);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(68, 532);
            this.sidebarPanel.TabIndex = 33;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Animated = true;
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.btnSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.HoverState.Parent = this.btnSignOut;
            this.btnSignOut.Image = global::webTRON_Management_Software.Properties.Resources.exit_icon;
            this.btnSignOut.ImageOffset = new System.Drawing.Point(10, -10);
            this.btnSignOut.Location = new System.Drawing.Point(0, 468);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(68, 48);
            this.btnSignOut.TabIndex = 24;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSignOut.Click += new System.EventHandler(this.SignOut);
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::webTRON_Management_Software.Properties.Resources.settings_icon;
            this.btnSettings.ImageOffset = new System.Drawing.Point(10, -12);
            this.btnSettings.Location = new System.Drawing.Point(0, 189);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(68, 48);
            this.btnSettings.TabIndex = 23;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(228)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::webTRON_Management_Software.Properties.Resources.dashboard_icon;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(15, -12);
            this.btnDashboard.Location = new System.Drawing.Point(0, 115);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(68, 48);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(-6, 10);
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.actveForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.activePanel.Location = new System.Drawing.Point(65, 0);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(165, 80);
            this.activePanel.TabIndex = 34;
            // 
            // actveForm
            // 
            this.actveForm.AutoSize = true;
            this.actveForm.BackColor = System.Drawing.Color.Transparent;
            this.actveForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actveForm.ForeColor = System.Drawing.Color.White;
            this.actveForm.Location = new System.Drawing.Point(64, 40);
            this.actveForm.Name = "actveForm";
            this.actveForm.Size = new System.Drawing.Size(88, 20);
            this.actveForm.TabIndex = 21;
            this.actveForm.Text = "Dashboard";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.avatar;
            this.activeUserPicture.Location = new System.Drawing.Point(7, 13);
            this.activeUserPicture.Name = "activeUserPicture";
            this.activeUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPicture.ShadowDecoration.Parent = this.activeUserPicture;
            this.activeUserPicture.Size = new System.Drawing.Size(49, 45);
            this.activeUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPicture.TabIndex = 0;
            this.activeUserPicture.TabStop = false;
            // 
            // activeUserName
            // 
            this.activeUserName.AutoSize = true;
            this.activeUserName.BackColor = System.Drawing.Color.Transparent;
            this.activeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserName.ForeColor = System.Drawing.Color.White;
            this.activeUserName.Location = new System.Drawing.Point(64, 9);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(52, 24);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(910, 28);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 32;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(959, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 31;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Animated = true;
            this.btnSearchPatient.AutoRoundedCorners = true;
            this.btnSearchPatient.BorderRadius = 21;
            this.btnSearchPatient.CheckedState.Parent = this.btnSearchPatient;
            this.btnSearchPatient.CustomImages.Parent = this.btnSearchPatient;
            this.btnSearchPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSearchPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnSearchPatient.ForeColor = System.Drawing.Color.White;
            this.btnSearchPatient.HoverState.Parent = this.btnSearchPatient;
            this.btnSearchPatient.Image = global::webTRON_Management_Software.Properties.Resources.search_icon;
            this.btnSearchPatient.Location = new System.Drawing.Point(667, 170);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.ShadowDecoration.Parent = this.btnSearchPatient;
            this.btnSearchPatient.Size = new System.Drawing.Size(192, 45);
            this.btnSearchPatient.TabIndex = 36;
            this.btnSearchPatient.Text = "Search Patient";
            this.btnSearchPatient.Click += new System.EventHandler(this.BtnSearchPatient_Click);
            // 
            // btnCreatePatient
            // 
            this.btnCreatePatient.Animated = true;
            this.btnCreatePatient.AutoRoundedCorners = true;
            this.btnCreatePatient.BorderRadius = 21;
            this.btnCreatePatient.CheckedState.Parent = this.btnCreatePatient;
            this.btnCreatePatient.CustomImages.Parent = this.btnCreatePatient;
            this.btnCreatePatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnCreatePatient.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnCreatePatient.ForeColor = System.Drawing.Color.White;
            this.btnCreatePatient.HoverState.Parent = this.btnCreatePatient;
            this.btnCreatePatient.Image = global::webTRON_Management_Software.Properties.Resources.PlusSign;
            this.btnCreatePatient.Location = new System.Drawing.Point(235, 170);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.ShadowDecoration.Parent = this.btnCreatePatient;
            this.btnCreatePatient.Size = new System.Drawing.Size(192, 45);
            this.btnCreatePatient.TabIndex = 35;
            this.btnCreatePatient.Text = "Create Patient";
            this.btnCreatePatient.Click += new System.EventHandler(this.BtnCreatePatient_Click);
            // 
            // btnRenewPatient
            // 
            this.btnRenewPatient.Animated = true;
            this.btnRenewPatient.AutoRoundedCorners = true;
            this.btnRenewPatient.BorderRadius = 21;
            this.btnRenewPatient.CheckedState.Parent = this.btnRenewPatient;
            this.btnRenewPatient.CustomImages.Parent = this.btnRenewPatient;
            this.btnRenewPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnRenewPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnRenewPatient.ForeColor = System.Drawing.Color.White;
            this.btnRenewPatient.HoverState.Parent = this.btnRenewPatient;
            this.btnRenewPatient.Image = global::webTRON_Management_Software.Properties.Resources.search_icon;
            this.btnRenewPatient.Location = new System.Drawing.Point(453, 170);
            this.btnRenewPatient.Name = "btnRenewPatient";
            this.btnRenewPatient.ShadowDecoration.Parent = this.btnRenewPatient;
            this.btnRenewPatient.Size = new System.Drawing.Size(192, 45);
            this.btnRenewPatient.TabIndex = 37;
            this.btnRenewPatient.Text = "Renew Patient";
            this.btnRenewPatient.Click += new System.EventHandler(this.BtnRenewPatient_Click);
            // 
            // dragableAccountantDashboard
            // 
            this.dragableAccountantDashboard.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.btnRenewPatient);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.btnCreatePatient);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountantDashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label actveForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Button btnSearchPatient;
        private Guna.UI2.WinForms.Guna2Button btnCreatePatient;
        private Guna.UI2.WinForms.Guna2Button btnRenewPatient;
        private Guna.UI2.WinForms.Guna2DragControl dragableAccountantDashboard;
    }
}