
namespace webTRON_Management_Software.Views.Utilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.activePanelStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.passwordIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.verificationCodePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.verificationCodeTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.lblEnterVerificationCode = new System.Windows.Forms.Label();
            this.verificationCodeTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.DragableChangePassword = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPasswordMustInclude = new System.Windows.Forms.Label();
            this.activePanelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.verificationCodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // activePanelStatus
            // 
            this.activePanelStatus.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanelStatus.Controls.Add(this.passwordIcon);
            this.activePanelStatus.Controls.Add(this.lblChangePassword);
            this.activePanelStatus.Location = new System.Drawing.Point(-2, 24);
            this.activePanelStatus.Name = "activePanelStatus";
            this.activePanelStatus.ShadowDecoration.Parent = this.activePanelStatus;
            this.activePanelStatus.Size = new System.Drawing.Size(362, 202);
            this.activePanelStatus.TabIndex = 18;
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.Transparent;
            this.passwordIcon.Image = global::webTRON_Management_Software.Properties.Resources.lock_password;
            this.passwordIcon.Location = new System.Drawing.Point(111, 31);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.ShadowDecoration.Parent = this.passwordIcon;
            this.passwordIcon.Size = new System.Drawing.Size(76, 69);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordIcon.TabIndex = 5;
            this.passwordIcon.TabStop = false;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.Color.White;
            this.lblChangePassword.Location = new System.Drawing.Point(45, 108);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(236, 31);
            this.lblChangePassword.TabIndex = 3;
            this.lblChangePassword.Text = "Change Password";
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Animated = true;
            this.currentPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.currentPasswordTextBox.Location = new System.Drawing.Point(458, 127);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '\0';
            this.currentPasswordTextBox.PlaceholderText = "Current Password";
            this.currentPasswordTextBox.SelectedText = "";
            this.currentPasswordTextBox.ShadowDecoration.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.currentPasswordTextBox.TabIndex = 42;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            this.currentPasswordTextBox.Leave += new System.EventHandler(this.currentPasswordTextBox_Leave);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(455, 86);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(164, 24);
            this.lblCurrentPassword.TabIndex = 48;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(455, 263);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(167, 24);
            this.lblConfirmPassword.TabIndex = 47;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Animated = true;
            this.confirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(460, 301);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '\0';
            this.confirmPasswordTextBox.PlaceholderText = "Confirm Password";
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.ShadowDecoration.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.confirmPasswordTextBox.TabIndex = 44;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            this.confirmPasswordTextBox.Leave += new System.EventHandler(this.confirmPasswordTextBox_Leave);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Animated = true;
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.newPasswordTextBox.Location = new System.Drawing.Point(459, 218);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '\0';
            this.newPasswordTextBox.PlaceholderText = "New Password";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.ShadowDecoration.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.newPasswordTextBox.TabIndex = 43;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            this.newPasswordTextBox.Leave += new System.EventHandler(this.newPasswordTextBox_Leave);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNewPassword.Location = new System.Drawing.Point(456, 177);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(141, 24);
            this.lblNewPassword.TabIndex = 46;
            this.lblNewPassword.Text = "New Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.CheckedState.Parent = this.btnChangePassword;
            this.btnChangePassword.CustomImages.Parent = this.btnChangePassword;
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.Parent = this.btnChangePassword;
            this.btnChangePassword.Location = new System.Drawing.Point(460, 376);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShadowDecoration.Parent = this.btnChangePassword;
            this.btnChangePassword.Size = new System.Drawing.Size(258, 53);
            this.btnChangePassword.TabIndex = 45;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(918, 20);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 50;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(967, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 49;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // verificationCodePanel
            // 
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox2);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox3);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox4);
            this.verificationCodePanel.Controls.Add(this.btnVerify);
            this.verificationCodePanel.Controls.Add(this.lblEnterVerificationCode);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox1);
            this.verificationCodePanel.Location = new System.Drawing.Point(399, 44);
            this.verificationCodePanel.Name = "verificationCodePanel";
            this.verificationCodePanel.ShadowDecoration.Parent = this.verificationCodePanel;
            this.verificationCodePanel.Size = new System.Drawing.Size(561, 480);
            this.verificationCodePanel.TabIndex = 51;
            this.verificationCodePanel.Visible = false;
            // 
            // verificationCodeTextBox2
            // 
            this.verificationCodeTextBox2.Animated = true;
            this.verificationCodeTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.verificationCodeTextBox2.Location = new System.Drawing.Point(230, 172);
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
            this.verificationCodeTextBox3.Location = new System.Drawing.Point(288, 172);
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
            this.verificationCodeTextBox4.Location = new System.Drawing.Point(339, 172);
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
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(175, 271);
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
            this.lblEnterVerificationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEnterVerificationCode.Location = new System.Drawing.Point(170, 128);
            this.lblEnterVerificationCode.Name = "lblEnterVerificationCode";
            this.lblEnterVerificationCode.Size = new System.Drawing.Size(208, 24);
            this.lblEnterVerificationCode.TabIndex = 13;
            this.lblEnterVerificationCode.Text = "Enter Verification Code:";
            // 
            // verificationCodeTextBox1
            // 
            this.verificationCodeTextBox1.Animated = true;
            this.verificationCodeTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.verificationCodeTextBox1.Location = new System.Drawing.Point(175, 172);
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
            // DragableChangePassword
            // 
            this.DragableChangePassword.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(746, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "At least 8 characters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(746, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "At least one uppercase character";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(746, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "At least one lowercase character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(747, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "At least one special character";
            // 
            // lblPasswordMustInclude
            // 
            this.lblPasswordMustInclude.AutoSize = true;
            this.lblPasswordMustInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblPasswordMustInclude.Location = new System.Drawing.Point(744, 95);
            this.lblPasswordMustInclude.Name = "lblPasswordMustInclude";
            this.lblPasswordMustInclude.Size = new System.Drawing.Size(178, 17);
            this.lblPasswordMustInclude.TabIndex = 52;
            this.lblPasswordMustInclude.Text = "Password Must Include:";
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
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.activePanelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.activePanelStatus.ResumeLayout(false);
            this.activePanelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.verificationCodePanel.ResumeLayout(false);
            this.verificationCodePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel activePanelStatus;
        private Guna.UI2.WinForms.Guna2PictureBox passwordIcon;
        private System.Windows.Forms.Label lblChangePassword;
        private Guna.UI2.WinForms.Guna2TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordTextBox;
        private System.Windows.Forms.Label lblNewPassword;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Panel verificationCodePanel;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox3;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox4;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private System.Windows.Forms.Label lblEnterVerificationCode;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox1;
        private Guna.UI2.WinForms.Guna2DragControl DragableChangePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPasswordMustInclude;
    }
}