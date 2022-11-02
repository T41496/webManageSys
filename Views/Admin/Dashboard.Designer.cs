
namespace webTRON_Management_Software.Views.Admin
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
            this.lblOnline = new System.Windows.Forms.Label();
            this.onlineUser = new System.Windows.Forms.Label();
            this.offlineUser = new System.Windows.Forms.Label();
            this.lblOffline = new System.Windows.Forms.Label();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.dragableAdminDashboard = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.onlineStatusPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.offlineStatusPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.actveForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.sidebarPanel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStatusPicture)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offlineStatusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblOnline.ForeColor = System.Drawing.Color.Green;
            this.lblOnline.Location = new System.Drawing.Point(104, 42);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(84, 29);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "Online";
            // 
            // onlineUser
            // 
            this.onlineUser.AutoSize = true;
            this.onlineUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineUser.ForeColor = System.Drawing.Color.Green;
            this.onlineUser.Location = new System.Drawing.Point(123, 79);
            this.onlineUser.Name = "onlineUser";
            this.onlineUser.Size = new System.Drawing.Size(27, 29);
            this.onlineUser.TabIndex = 5;
            this.onlineUser.Text = "0";
            // 
            // offlineUser
            // 
            this.offlineUser.AutoSize = true;
            this.offlineUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offlineUser.ForeColor = System.Drawing.Color.Red;
            this.offlineUser.Location = new System.Drawing.Point(142, 80);
            this.offlineUser.Name = "offlineUser";
            this.offlineUser.Size = new System.Drawing.Size(27, 29);
            this.offlineUser.TabIndex = 7;
            this.offlineUser.Text = "0";
            // 
            // lblOffline
            // 
            this.lblOffline.AutoSize = true;
            this.lblOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblOffline.ForeColor = System.Drawing.Color.Red;
            this.lblOffline.Location = new System.Drawing.Point(116, 42);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(83, 29);
            this.lblOffline.TabIndex = 6;
            this.lblOffline.Text = "Offline";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSignOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnUsers);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(0, -1);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(68, 532);
            this.sidebarPanel.TabIndex = 19;
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
            this.btnSettings.Location = new System.Drawing.Point(0, 272);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(68, 48);
            this.btnSettings.TabIndex = 23;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::webTRON_Management_Software.Properties.Resources.user_icon;
            this.btnUsers.ImageOffset = new System.Drawing.Point(6, -12);
            this.btnUsers.Location = new System.Drawing.Point(0, 195);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(68, 48);
            this.btnUsers.TabIndex = 22;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
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
            // dragableAdminDashboard
            // 
            this.dragableAdminDashboard.TargetControl = this;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.onlineStatusPicture);
            this.guna2ShadowPanel1.Controls.Add(this.lblOnline);
            this.guna2ShadowPanel1.Controls.Add(this.onlineUser);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(240, 114);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(238, 151);
            this.guna2ShadowPanel1.TabIndex = 23;
            // 
            // onlineStatusPicture
            // 
            this.onlineStatusPicture.Image = global::webTRON_Management_Software.Properties.Resources.circle_green;
            this.onlineStatusPicture.Location = new System.Drawing.Point(57, 56);
            this.onlineStatusPicture.Name = "onlineStatusPicture";
            this.onlineStatusPicture.ShadowDecoration.Parent = this.onlineStatusPicture;
            this.onlineStatusPicture.Size = new System.Drawing.Size(30, 30);
            this.onlineStatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onlineStatusPicture.TabIndex = 1;
            this.onlineStatusPicture.TabStop = false;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.offlineUser);
            this.guna2ShadowPanel2.Controls.Add(this.lblOffline);
            this.guna2ShadowPanel2.Controls.Add(this.offlineStatusPicture);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(545, 114);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(260, 151);
            this.guna2ShadowPanel2.TabIndex = 24;
            // 
            // offlineStatusPicture
            // 
            this.offlineStatusPicture.Image = global::webTRON_Management_Software.Properties.Resources.circle_red;
            this.offlineStatusPicture.Location = new System.Drawing.Point(64, 56);
            this.offlineStatusPicture.Name = "offlineStatusPicture";
            this.offlineStatusPicture.ShadowDecoration.Parent = this.offlineStatusPicture;
            this.offlineStatusPicture.Size = new System.Drawing.Size(30, 30);
            this.offlineStatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offlineStatusPicture.TabIndex = 2;
            this.offlineStatusPicture.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(911, 20);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(960, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 21;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.actveForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.activePanel.Location = new System.Drawing.Point(63, -3);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(165, 80);
            this.activePanel.TabIndex = 20;
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
            this.activeUserPicture.Location = new System.Drawing.Point(6, 14);
            this.activeUserPicture.Name = "activeUserPicture";
            this.activeUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPicture.ShadowDecoration.Parent = this.activeUserPicture;
            this.activeUserPicture.Size = new System.Drawing.Size(49, 45);
            this.activeUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPicture.TabIndex = 0;
            this.activeUserPicture.TabStop = false;
            this.activeUserPicture.Click += new System.EventHandler(this.activeUserPicture_Click);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.activePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStatusPicture)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offlineStatusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox onlineStatusPicture;
        private Guna.UI2.WinForms.Guna2PictureBox offlineStatusPicture;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label onlineUser;
        private System.Windows.Forms.Label offlineUser;
        private System.Windows.Forms.Label lblOffline;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label actveForm;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2DragControl dragableAdminDashboard;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}