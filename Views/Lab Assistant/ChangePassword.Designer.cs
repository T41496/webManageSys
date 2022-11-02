
namespace webTRON_Management_Software.Views.Lab_Assistant
{
    partial class ChangePassword
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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.verificationCodeTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.lblEnterVerificationCode = new System.Windows.Forms.Label();
            this.verificationCodeTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.currentPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.actveForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DragableChangePassword = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblPasswordMustInclude = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            this.verificationCodePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            this.activePanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // alertTimer
            // 
            this.alertTimer.Enabled = true;
            this.alertTimer.Interval = 5000;
            this.alertTimer.Tick += new System.EventHandler(this.AlertTimer_Tick);
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
            // alertPanel
            // 
            this.alertPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.alert_danger_background;
            this.alertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPanel.Controls.Add(this.alertText);
            this.alertPanel.Controls.Add(this.alertCloseBtn);
            this.alertPanel.Controls.Add(this.alertImage);
            this.alertTransition.SetDecoration(this.alertPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertPanel.Location = new System.Drawing.Point(688, 558);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(306, 55);
            this.alertPanel.TabIndex = 63;
            this.alertPanel.Visible = false;
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
            // alertTransition
            // 
            this.alertTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.alertTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.alertTransition.DefaultAnimation = animation3;
            this.alertTransition.MaxAnimationTime = 5000;
            // 
            // verificationCodeTextBox2
            // 
            this.verificationCodeTextBox2.Animated = true;
            this.verificationCodeTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.verificationCodeTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox2.DefaultText = "";
            this.verificationCodeTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox2.DisabledState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox2.FocusedState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox2.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox2.HoverState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Location = new System.Drawing.Point(268, 133);
            this.verificationCodeTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox2.Name = "verificationCodeTextBox2";
            this.verificationCodeTextBox2.PasswordChar = '\0';
            this.verificationCodeTextBox2.PlaceholderText = "";
            this.verificationCodeTextBox2.SelectedText = "";
            this.verificationCodeTextBox2.ShadowDecoration.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox2.TabIndex = 1;
            this.verificationCodeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox2.TextChanged += new System.EventHandler(this.VerificationCodeTextBox2_TextChanged);
            // 
            // verificationCodeTextBox3
            // 
            this.verificationCodeTextBox3.Animated = true;
            this.verificationCodeTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.verificationCodeTextBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox3.DefaultText = "";
            this.verificationCodeTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox3.DisabledState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox3.FocusedState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox3.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox3.HoverState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Location = new System.Drawing.Point(326, 133);
            this.verificationCodeTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox3.Name = "verificationCodeTextBox3";
            this.verificationCodeTextBox3.PasswordChar = '\0';
            this.verificationCodeTextBox3.PlaceholderText = "";
            this.verificationCodeTextBox3.SelectedText = "";
            this.verificationCodeTextBox3.ShadowDecoration.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox3.TabIndex = 2;
            this.verificationCodeTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox3.TextChanged += new System.EventHandler(this.VerificationCodeTextBox3_TextChanged);
            // 
            // verificationCodeTextBox4
            // 
            this.verificationCodeTextBox4.Animated = true;
            this.verificationCodeTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.verificationCodeTextBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox4.DefaultText = "";
            this.verificationCodeTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox4.DisabledState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox4.FocusedState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox4.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox4.HoverState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Location = new System.Drawing.Point(377, 133);
            this.verificationCodeTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox4.Name = "verificationCodeTextBox4";
            this.verificationCodeTextBox4.PasswordChar = '\0';
            this.verificationCodeTextBox4.PlaceholderText = "";
            this.verificationCodeTextBox4.SelectedText = "";
            this.verificationCodeTextBox4.ShadowDecoration.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox4.TabIndex = 3;
            this.verificationCodeTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox4.TextChanged += new System.EventHandler(this.VerificationCodeTextBox4_TextChanged);
            // 
            // btnVerify
            // 
            this.btnVerify.Animated = true;
            this.btnVerify.CheckedState.Parent = this.btnVerify;
            this.btnVerify.CustomImages.Parent = this.btnVerify;
            this.alertTransition.SetDecoration(this.btnVerify, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(213, 232);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.ShadowDecoration.Parent = this.btnVerify;
            this.btnVerify.Size = new System.Drawing.Size(203, 53);
            this.btnVerify.TabIndex = 14;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // lblEnterVerificationCode
            // 
            this.lblEnterVerificationCode.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblEnterVerificationCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEnterVerificationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEnterVerificationCode.Location = new System.Drawing.Point(208, 89);
            this.lblEnterVerificationCode.Name = "lblEnterVerificationCode";
            this.lblEnterVerificationCode.Size = new System.Drawing.Size(208, 24);
            this.lblEnterVerificationCode.TabIndex = 13;
            this.lblEnterVerificationCode.Text = "Enter Verification Code:";
            // 
            // verificationCodeTextBox1
            // 
            this.verificationCodeTextBox1.Animated = true;
            this.verificationCodeTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.verificationCodeTextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox1.DefaultText = "";
            this.verificationCodeTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox1.DisabledState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox1.FocusedState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox1.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox1.HoverState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Location = new System.Drawing.Point(213, 133);
            this.verificationCodeTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox1.Name = "verificationCodeTextBox1";
            this.verificationCodeTextBox1.PasswordChar = '\0';
            this.verificationCodeTextBox1.PlaceholderText = "";
            this.verificationCodeTextBox1.SelectedText = "";
            this.verificationCodeTextBox1.ShadowDecoration.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox1.TabIndex = 0;
            this.verificationCodeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox1.TextChanged += new System.EventHandler(this.VerificationCodeTextBox1_TextChanged);
            // 
            // verificationCodePanel
            // 
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox2);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox3);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox4);
            this.verificationCodePanel.Controls.Add(this.btnVerify);
            this.verificationCodePanel.Controls.Add(this.lblEnterVerificationCode);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox1);
            this.alertTransition.SetDecoration(this.verificationCodePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodePanel.Location = new System.Drawing.Point(261, 22);
            this.verificationCodePanel.Name = "verificationCodePanel";
            this.verificationCodePanel.ShadowDecoration.Parent = this.verificationCodePanel;
            this.verificationCodePanel.Size = new System.Drawing.Size(625, 480);
            this.verificationCodePanel.TabIndex = 62;
            this.verificationCodePanel.Visible = false;
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Animated = true;
            this.currentPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.currentPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.currentPasswordTextBox.DefaultText = "";
            this.currentPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPasswordTextBox.DisabledState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPasswordTextBox.FocusedState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.currentPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPasswordTextBox.HoverState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Location = new System.Drawing.Point(344, 130);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '\0';
            this.currentPasswordTextBox.PlaceholderText = "Current Password";
            this.currentPasswordTextBox.SelectedText = "";
            this.currentPasswordTextBox.ShadowDecoration.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.currentPasswordTextBox.TabIndex = 55;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblCurrentPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(341, 89);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(164, 24);
            this.lblCurrentPassword.TabIndex = 61;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblConfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(341, 266);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(167, 24);
            this.lblConfirmPassword.TabIndex = 60;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Animated = true;
            this.confirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.confirmPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.confirmPasswordTextBox.DefaultText = "";
            this.confirmPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.DisabledState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.FocusedState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.confirmPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.HoverState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(346, 304);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '\0';
            this.confirmPasswordTextBox.PlaceholderText = "Confirm Password";
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.ShadowDecoration.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.confirmPasswordTextBox.TabIndex = 57;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Animated = true;
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.newPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.newPasswordTextBox.DefaultText = "";
            this.newPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.DisabledState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.FocusedState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.newPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.HoverState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Location = new System.Drawing.Point(345, 221);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '\0';
            this.newPasswordTextBox.PlaceholderText = "New Password";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.ShadowDecoration.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.newPasswordTextBox.TabIndex = 56;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.CheckedState.Parent = this.btnChangePassword;
            this.btnChangePassword.CustomImages.Parent = this.btnChangePassword;
            this.alertTransition.SetDecoration(this.btnChangePassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.Parent = this.btnChangePassword;
            this.btnChangePassword.Location = new System.Drawing.Point(346, 379);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShadowDecoration.Parent = this.btnChangePassword;
            this.btnChangePassword.Size = new System.Drawing.Size(258, 53);
            this.btnChangePassword.TabIndex = 58;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // actveForm
            // 
            this.actveForm.AutoSize = true;
            this.actveForm.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.actveForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.actveForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actveForm.ForeColor = System.Drawing.Color.White;
            this.actveForm.Location = new System.Drawing.Point(64, 40);
            this.actveForm.Name = "actveForm";
            this.actveForm.Size = new System.Drawing.Size(68, 20);
            this.actveForm.TabIndex = 21;
            this.actveForm.Text = "Settings";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.alertTransition.SetDecoration(this.activeUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserName.ForeColor = System.Drawing.Color.White;
            this.activeUserName.Location = new System.Drawing.Point(64, 9);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(52, 24);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.actveForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.alertTransition.SetDecoration(this.activePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(66, -1);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(165, 80);
            this.activePanel.TabIndex = 54;
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
            this.btnSettings.Location = new System.Drawing.Point(0, 185);
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
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblNewPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNewPassword.Location = new System.Drawing.Point(342, 180);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(141, 24);
            this.lblNewPassword.TabIndex = 59;
            this.lblNewPassword.Text = "New Password:";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSignOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.alertTransition.SetDecoration(this.sidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(0, -2);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(68, 532);
            this.sidebarPanel.TabIndex = 53;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(966, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 51;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(917, 22);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 52;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // DragableChangePassword
            // 
            this.DragableChangePassword.TargetControl = null;
            // 
            // lblPasswordMustInclude
            // 
            this.lblPasswordMustInclude.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblPasswordMustInclude, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPasswordMustInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblPasswordMustInclude.Location = new System.Drawing.Point(657, 92);
            this.lblPasswordMustInclude.Name = "lblPasswordMustInclude";
            this.lblPasswordMustInclude.Size = new System.Drawing.Size(178, 17);
            this.lblPasswordMustInclude.TabIndex = 64;
            this.lblPasswordMustInclude.Text = "Password Must Include:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.alertTransition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(660, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "At least one special character";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.alertTransition.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(659, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "At least one lowercase character";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.alertTransition.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(659, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "At least one uppercase character";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.alertTransition.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(659, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "At least 8 characters";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.verificationCodePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPasswordMustInclude);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).EndInit();
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).EndInit();
            this.verificationCodePanel.ResumeLayout(false);
            this.verificationCodePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer alertTimer;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox3;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox4;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private System.Windows.Forms.Label lblEnterVerificationCode;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox1;
        private Guna.UI2.WinForms.Guna2Panel verificationCodePanel;
        private Guna.UI2.WinForms.Guna2TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordTextBox;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private System.Windows.Forms.Label actveForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label lblNewPassword;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2DragControl DragableChangePassword;
        private System.Windows.Forms.Label lblPasswordMustInclude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}