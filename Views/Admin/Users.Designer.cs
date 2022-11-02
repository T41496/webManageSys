
namespace webTRON_Management_Software.Views.Admin
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.DragableAdmin_Users = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSearchUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewAccount = new Guna.UI2.WinForms.Guna2Button();
            this.activeUserPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.activeForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.activeUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            this.SuspendLayout();
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
            this.sidebarPanel.TabIndex = 24;
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
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(228)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::webTRON_Management_Software.Properties.Resources.user_icon;
            this.btnUsers.ImageOffset = new System.Drawing.Point(6, -12);
            this.btnUsers.Location = new System.Drawing.Point(0, 195);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(228)))));
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(68, 48);
            this.btnUsers.TabIndex = 22;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextOffset = new System.Drawing.Point(-8, 10);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
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
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // DragableAdmin_Users
            // 
            this.DragableAdmin_Users.TargetControl = this;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(921, 22);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 26;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(970, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 25;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Animated = true;
            this.btnSearchUser.AutoRoundedCorners = true;
            this.btnSearchUser.BorderRadius = 21;
            this.btnSearchUser.CheckedState.Parent = this.btnSearchUser;
            this.btnSearchUser.CustomImages.Parent = this.btnSearchUser;
            this.btnSearchUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.HoverState.Parent = this.btnSearchUser;
            this.btnSearchUser.Image = global::webTRON_Management_Software.Properties.Resources.search_icon;
            this.btnSearchUser.Location = new System.Drawing.Point(545, 166);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.ShadowDecoration.Parent = this.btnSearchUser;
            this.btnSearchUser.Size = new System.Drawing.Size(192, 45);
            this.btnSearchUser.TabIndex = 23;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.Click += new System.EventHandler(this.BtnSearchUser_Click);
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Animated = true;
            this.btnAddNewAccount.AutoRoundedCorners = true;
            this.btnAddNewAccount.BorderRadius = 21;
            this.btnAddNewAccount.CheckedState.Parent = this.btnAddNewAccount;
            this.btnAddNewAccount.CustomImages.Parent = this.btnAddNewAccount;
            this.btnAddNewAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnAddNewAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnAddNewAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddNewAccount.HoverState.Parent = this.btnAddNewAccount;
            this.btnAddNewAccount.Image = global::webTRON_Management_Software.Properties.Resources.PlusSign;
            this.btnAddNewAccount.Location = new System.Drawing.Point(315, 166);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.ShadowDecoration.Parent = this.btnAddNewAccount;
            this.btnAddNewAccount.Size = new System.Drawing.Size(192, 45);
            this.btnAddNewAccount.TabIndex = 22;
            this.btnAddNewAccount.Text = "New Account";
            this.btnAddNewAccount.Click += new System.EventHandler(this.BtnAddNewAccount_Click);
            // 
            // activeUserPanel
            // 
            this.activeUserPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activeUserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activeUserPanel.Controls.Add(this.activeForm);
            this.activeUserPanel.Controls.Add(this.activeUserPicture);
            this.activeUserPanel.Controls.Add(this.activeUserName);
            this.activeUserPanel.Location = new System.Drawing.Point(61, -2);
            this.activeUserPanel.Name = "activeUserPanel";
            this.activeUserPanel.ShadowDecoration.Parent = this.activeUserPanel;
            this.activeUserPanel.Size = new System.Drawing.Size(165, 80);
            this.activeUserPanel.TabIndex = 21;
            // 
            // activeForm
            // 
            this.activeForm.AutoSize = true;
            this.activeForm.BackColor = System.Drawing.Color.Transparent;
            this.activeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeForm.ForeColor = System.Drawing.Color.White;
            this.activeForm.Location = new System.Drawing.Point(62, 44);
            this.activeForm.Name = "activeForm";
            this.activeForm.Size = new System.Drawing.Size(51, 20);
            this.activeForm.TabIndex = 21;
            this.activeForm.Text = "Users";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.avatar;
            this.activeUserPicture.Location = new System.Drawing.Point(9, 17);
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
            this.activeUserName.Location = new System.Drawing.Point(60, 13);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(52, 24);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnAddNewAccount);
            this.Controls.Add(this.activeUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.activeUserPanel.ResumeLayout(false);
            this.activeUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearchUser;
        private Guna.UI2.WinForms.Guna2Button btnAddNewAccount;
        private Guna.UI2.WinForms.Guna2Panel activeUserPanel;
        private System.Windows.Forms.Label activeForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2DragControl DragableAdmin_Users;
    }
}