
namespace webTRON_Management_Software.Views.Admin
{
    partial class Settings
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIdValue = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNumberValue = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangeInfo = new Guna.UI2.WinForms.Guna2Button();
            this.userPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.activeForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChangePicture = new Guna.UI2.WinForms.Guna2Button();
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.DragableSettings = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.activeUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSignOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnUsers);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.alertTransition.SetDecoration(this.sidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(0, -1);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(68, 532);
            this.sidebarPanel.TabIndex = 30;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Animated = true;
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.alertTransition.SetDecoration(this.btnSignOut, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.alertTransition.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(228)))));
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
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.alertTransition.SetDecoration(this.btnUsers, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.alertTransition.SetDecoration(this.btnDashboard, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblUserID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblUserID.Location = new System.Drawing.Point(295, 88);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(76, 24);
            this.lblUserID.TabIndex = 34;
            this.lblUserID.Text = "User ID:";
            // 
            // lblUserIdValue
            // 
            this.lblUserIdValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblUserIdValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUserIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblUserIdValue.Location = new System.Drawing.Point(451, 88);
            this.lblUserIdValue.Name = "lblUserIdValue";
            this.lblUserIdValue.Size = new System.Drawing.Size(88, 24);
            this.lblUserIdValue.TabIndex = 35;
            this.lblUserIdValue.Text = "{{userID}}";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblFullNameValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFullNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFullNameValue.Location = new System.Drawing.Point(451, 136);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(108, 24);
            this.lblFullNameValue.TabIndex = 37;
            this.lblFullNameValue.Text = "{{fullName}}";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblFullName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFullName.Location = new System.Drawing.Point(295, 136);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(102, 24);
            this.lblFullName.TabIndex = 36;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblEmailValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmailValue.Location = new System.Drawing.Point(451, 181);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(79, 24);
            this.lblEmailValue.TabIndex = 39;
            this.lblEmailValue.Text = "{{email}}";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmail.Location = new System.Drawing.Point(295, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email:";
            // 
            // lblContactNumberValue
            // 
            this.lblContactNumberValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblContactNumberValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblContactNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblContactNumberValue.Location = new System.Drawing.Point(451, 228);
            this.lblContactNumberValue.Name = "lblContactNumberValue";
            this.lblContactNumberValue.Size = new System.Drawing.Size(163, 24);
            this.lblContactNumberValue.TabIndex = 41;
            this.lblContactNumberValue.Text = "{{contactNumber}}";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblContactNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblContactNumber.Location = new System.Drawing.Point(295, 228);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(152, 24);
            this.lblContactNumber.TabIndex = 40;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.AutoRoundedCorners = true;
            this.btnChangePassword.BorderRadius = 21;
            this.btnChangePassword.CheckedState.Parent = this.btnChangePassword;
            this.btnChangePassword.CustomImages.Parent = this.btnChangePassword;
            this.alertTransition.SetDecoration(this.btnChangePassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.Parent = this.btnChangePassword;
            this.btnChangePassword.Location = new System.Drawing.Point(760, 377);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShadowDecoration.Parent = this.btnChangePassword;
            this.btnChangePassword.Size = new System.Drawing.Size(192, 45);
            this.btnChangePassword.TabIndex = 43;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Animated = true;
            this.btnChangeInfo.AutoRoundedCorners = true;
            this.btnChangeInfo.BorderRadius = 21;
            this.btnChangeInfo.CheckedState.Parent = this.btnChangeInfo;
            this.btnChangeInfo.CustomImages.Parent = this.btnChangeInfo;
            this.alertTransition.SetDecoration(this.btnChangeInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChangeInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnChangeInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnChangeInfo.ForeColor = System.Drawing.Color.White;
            this.btnChangeInfo.HoverState.Parent = this.btnChangeInfo;
            this.btnChangeInfo.Location = new System.Drawing.Point(760, 322);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.ShadowDecoration.Parent = this.btnChangeInfo;
            this.btnChangeInfo.Size = new System.Drawing.Size(192, 45);
            this.btnChangeInfo.TabIndex = 42;
            this.btnChangeInfo.Text = "Change Info";
            this.btnChangeInfo.Click += new System.EventHandler(this.BtnChangeInfo_Click);
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.userPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userPicture.Image = global::webTRON_Management_Software.Properties.Resources.avatar;
            this.userPicture.Location = new System.Drawing.Point(760, 77);
            this.userPicture.Name = "userPicture";
            this.userPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPicture.ShadowDecoration.Parent = this.userPicture;
            this.userPicture.Size = new System.Drawing.Size(175, 175);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 31;
            this.userPicture.TabStop = false;
            // 
            // activeUserPanel
            // 
            this.activeUserPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activeUserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activeUserPanel.Controls.Add(this.activeForm);
            this.activeUserPanel.Controls.Add(this.activeUserPicture);
            this.activeUserPanel.Controls.Add(this.activeUserName);
            this.alertTransition.SetDecoration(this.activeUserPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPanel.Location = new System.Drawing.Point(61, -2);
            this.activeUserPanel.Name = "activeUserPanel";
            this.activeUserPanel.ShadowDecoration.Parent = this.activeUserPanel;
            this.activeUserPanel.Size = new System.Drawing.Size(165, 80);
            this.activeUserPanel.TabIndex = 29;
            // 
            // activeForm
            // 
            this.activeForm.AutoSize = true;
            this.activeForm.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeForm.ForeColor = System.Drawing.Color.White;
            this.activeForm.Location = new System.Drawing.Point(62, 44);
            this.activeForm.Name = "activeForm";
            this.activeForm.Size = new System.Drawing.Size(68, 20);
            this.activeForm.TabIndex = 21;
            this.activeForm.Text = "Settings";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.alertTransition.SetDecoration(this.activeUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserName.ForeColor = System.Drawing.Color.White;
            this.activeUserName.Location = new System.Drawing.Point(60, 13);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(52, 24);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(911, 27);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 28;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(960, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 27;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.Animated = true;
            this.btnChangePicture.AutoRoundedCorners = true;
            this.btnChangePicture.BorderRadius = 21;
            this.btnChangePicture.CheckedState.Parent = this.btnChangePicture;
            this.btnChangePicture.CustomImages.Parent = this.btnChangePicture;
            this.alertTransition.SetDecoration(this.btnChangePicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChangePicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnChangePicture.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnChangePicture.ForeColor = System.Drawing.Color.White;
            this.btnChangePicture.HoverState.Parent = this.btnChangePicture;
            this.btnChangePicture.Location = new System.Drawing.Point(760, 265);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.ShadowDecoration.Parent = this.btnChangePicture;
            this.btnChangePicture.Size = new System.Drawing.Size(192, 45);
            this.btnChangePicture.TabIndex = 44;
            this.btnChangePicture.Text = "Change Picture";
            this.btnChangePicture.Click += new System.EventHandler(this.BtnChangePicture_Click);
            // 
            // alertTransition
            // 
            this.alertTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.alertTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.alertTransition.DefaultAnimation = animation1;
            this.alertTransition.MaxAnimationTime = 5000;
            // 
            // alertPanel
            // 
            this.alertPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.alert_danger_background;
            this.alertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPanel.Controls.Add(this.alertText);
            this.alertPanel.Controls.Add(this.alertCloseBtn);
            this.alertPanel.Controls.Add(this.alertImage);
            this.alertTransition.SetDecoration(this.alertPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertPanel.Location = new System.Drawing.Point(691, 558);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(306, 55);
            this.alertPanel.TabIndex = 45;
            this.alertPanel.Visible = false;
            // 
            // alertText
            // 
            this.alertText.AutoSize = true;
            this.alertTransition.SetDecoration(this.alertText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.alertText.ForeColor = System.Drawing.Color.Red;
            this.alertText.Location = new System.Drawing.Point(56, 17);
            this.alertText.Name = "alertText";
            this.alertText.Size = new System.Drawing.Size(90, 20);
            this.alertText.TabIndex = 2;
            this.alertText.Text = "{{alertText}}";
            // 
            // alertCloseBtn
            // 
            this.alertCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.alertCloseBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertCloseBtn.Image = global::webTRON_Management_Software.Properties.Resources.alert_close_icon;
            this.alertCloseBtn.Location = new System.Drawing.Point(269, 17);
            this.alertCloseBtn.Name = "alertCloseBtn";
            this.alertCloseBtn.ShadowDecoration.Parent = this.alertCloseBtn;
            this.alertCloseBtn.Size = new System.Drawing.Size(20, 20);
            this.alertCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertCloseBtn.TabIndex = 1;
            this.alertCloseBtn.TabStop = false;
            this.alertCloseBtn.Click += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // alertImage
            // 
            this.alertTransition.SetDecoration(this.alertImage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertImage.Image = global::webTRON_Management_Software.Properties.Resources.alert_danger_icon;
            this.alertImage.Location = new System.Drawing.Point(22, 17);
            this.alertImage.Name = "alertImage";
            this.alertImage.ShadowDecoration.Parent = this.alertImage;
            this.alertImage.Size = new System.Drawing.Size(20, 20);
            this.alertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertImage.TabIndex = 0;
            this.alertImage.TabStop = false;
            // 
            // alertTimer
            // 
            this.alertTimer.Enabled = true;
            this.alertTimer.Interval = 5000;
            this.alertTimer.Tick += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // DragableSettings
            // 
            this.DragableSettings.TargetControl = this;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.btnChangePicture);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.lblContactNumberValue);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblEmailValue);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullNameValue);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblUserIdValue);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.activeUserPanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.activeUserPanel.ResumeLayout(false);
            this.activeUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel activeUserPanel;
        private System.Windows.Forms.Label activeForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPicture;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIdValue;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNumberValue;
        private System.Windows.Forms.Label lblContactNumber;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2Button btnChangeInfo;
        private Guna.UI2.WinForms.Guna2Button btnChangePicture;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
        private System.Windows.Forms.Timer alertTimer;
        private Guna.UI2.WinForms.Guna2DragControl DragableSettings;
    }
}