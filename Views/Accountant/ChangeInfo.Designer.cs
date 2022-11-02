
namespace webTRON_Management_Software.Views.Accountant
{
    partial class ChangeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInfo));
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.userIdValue = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.roleValue = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.contactNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbContactNumber = new System.Windows.Forms.Label();
            this.isOthers = new Guna.UI2.WinForms.Guna2RadioButton();
            this.isFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.isMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.DragableChangeInfo = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.actveForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sidebarPanel.SuspendLayout();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
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
            this.alertTransition.SetDecoration(this.sidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(0, -1);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(91, 655);
            this.sidebarPanel.TabIndex = 44;
            // 
            // userIdValue
            // 
            this.userIdValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.userIdValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.userIdValue.Location = new System.Drawing.Point(524, 140);
            this.userIdValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdValue.Name = "userIdValue";
            this.userIdValue.Size = new System.Drawing.Size(123, 29);
            this.userIdValue.TabIndex = 80;
            this.userIdValue.Text = "{{UserID}}";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblUserId, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblUserId.Location = new System.Drawing.Point(303, 140);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(93, 29);
            this.lblUserId.TabIndex = 79;
            this.lblUserId.Text = "UserID:";
            // 
            // roleValue
            // 
            this.roleValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.roleValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.roleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.roleValue.Location = new System.Drawing.Point(524, 197);
            this.roleValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleValue.Name = "roleValue";
            this.roleValue.Size = new System.Drawing.Size(100, 29);
            this.roleValue.TabIndex = 78;
            this.roleValue.Text = "{{Role}}";
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.alertTransition.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(856, 631);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(240, 55);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRole.Location = new System.Drawing.Point(303, 197);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(70, 29);
            this.lblRole.TabIndex = 77;
            this.lblRole.Text = "Role:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Animated = true;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.addressTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addressTextBox.DefaultText = "";
            this.addressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.DisabledState.Parent = this.addressTextBox;
            this.addressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.FocusedState.Parent = this.addressTextBox;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.HoverState.Parent = this.addressTextBox;
            this.addressTextBox.Location = new System.Drawing.Point(529, 378);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PlaceholderText = "Address";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.ShadowDecoration.Parent = this.addressTextBox;
            this.addressTextBox.Size = new System.Drawing.Size(319, 39);
            this.addressTextBox.TabIndex = 64;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.Location = new System.Drawing.Point(303, 378);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(118, 29);
            this.lblAddress.TabIndex = 76;
            this.lblAddress.Text = "Address*:";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Animated = true;
            this.contactNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.contactNumberTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.contactNumberTextBox.DefaultText = "";
            this.contactNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNumberTextBox.DisabledState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactNumberTextBox.FocusedState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contactNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.contactNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactNumberTextBox.HoverState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Location = new System.Drawing.Point(529, 551);
            this.contactNumberTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.PasswordChar = '\0';
            this.contactNumberTextBox.PlaceholderText = "Contact Number";
            this.contactNumberTextBox.SelectedText = "";
            this.contactNumberTextBox.ShadowDecoration.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Size = new System.Drawing.Size(319, 39);
            this.contactNumberTextBox.TabIndex = 69;
            // 
            // lbContactNumber
            // 
            this.lbContactNumber.AutoSize = true;
            this.alertTransition.SetDecoration(this.lbContactNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbContactNumber.Location = new System.Drawing.Point(303, 555);
            this.lbContactNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContactNumber.Name = "lbContactNumber";
            this.lbContactNumber.Size = new System.Drawing.Size(203, 29);
            this.lbContactNumber.TabIndex = 75;
            this.lbContactNumber.Text = "Contact Number*:";
            // 
            // isOthers
            // 
            this.isOthers.Animated = true;
            this.isOthers.AutoSize = true;
            this.isOthers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isOthers.CheckedState.BorderThickness = 0;
            this.isOthers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isOthers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isOthers.CheckedState.InnerOffset = -4;
            this.alertTransition.SetDecoration(this.isOthers, Guna.UI2.AnimatorNS.DecorationType.None);
            this.isOthers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isOthers.Location = new System.Drawing.Point(731, 503);
            this.isOthers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isOthers.Name = "isOthers";
            this.isOthers.Size = new System.Drawing.Size(91, 32);
            this.isOthers.TabIndex = 68;
            this.isOthers.TabStop = true;
            this.isOthers.Text = "Others";
            this.isOthers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isOthers.UncheckedState.BorderThickness = 2;
            this.isOthers.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isOthers.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isOthers.UseVisualStyleBackColor = true;
            // 
            // isFemale
            // 
            this.isFemale.Animated = true;
            this.isFemale.AutoSize = true;
            this.isFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isFemale.CheckedState.BorderThickness = 0;
            this.isFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isFemale.CheckedState.InnerOffset = -4;
            this.alertTransition.SetDecoration(this.isFemale, Guna.UI2.AnimatorNS.DecorationType.None);
            this.isFemale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isFemale.Location = new System.Drawing.Point(620, 503);
            this.isFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isFemale.Name = "isFemale";
            this.isFemale.Size = new System.Drawing.Size(95, 32);
            this.isFemale.TabIndex = 67;
            this.isFemale.TabStop = true;
            this.isFemale.Text = "Female";
            this.isFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isFemale.UncheckedState.BorderThickness = 2;
            this.isFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isFemale.UseVisualStyleBackColor = true;
            // 
            // isMale
            // 
            this.isMale.Animated = true;
            this.isMale.AutoSize = true;
            this.isMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isMale.CheckedState.BorderThickness = 0;
            this.isMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isMale.CheckedState.InnerOffset = -4;
            this.alertTransition.SetDecoration(this.isMale, Guna.UI2.AnimatorNS.DecorationType.None);
            this.isMale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isMale.Location = new System.Drawing.Point(529, 503);
            this.isMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isMale.Name = "isMale";
            this.isMale.Size = new System.Drawing.Size(76, 32);
            this.isMale.TabIndex = 66;
            this.isMale.TabStop = true;
            this.isMale.Text = "Male";
            this.isMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isMale.UncheckedState.BorderThickness = 2;
            this.isMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblGender, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGender.Location = new System.Drawing.Point(303, 502);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(110, 29);
            this.lblGender.TabIndex = 74;
            this.lblGender.Text = "Gender*:";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthPicker.CheckedState.Parent = this.dateOfBirthPicker;
            this.alertTransition.SetDecoration(this.dateOfBirthPicker, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dateOfBirthPicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateOfBirthPicker.ForeColor = System.Drawing.Color.White;
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthPicker.HoverState.Parent = this.dateOfBirthPicker;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(529, 437);
            this.dateOfBirthPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOfBirthPicker.MaxDate = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            this.dateOfBirthPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.ShadowDecoration.Parent = this.dateOfBirthPicker;
            this.dateOfBirthPicker.Size = new System.Drawing.Size(267, 44);
            this.dateOfBirthPicker.TabIndex = 65;
            this.dateOfBirthPicker.Value = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblDateOfBirth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(303, 442);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(160, 29);
            this.lblDateOfBirth.TabIndex = 73;
            this.lblDateOfBirth.Text = "Date of Birth*:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.emailTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.Parent = this.emailTextBox;
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.FocusedState.Parent = this.emailTextBox;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(529, 314);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Email Address";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(543, 39);
            this.emailTextBox.TabIndex = 63;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblEmailAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmailAddress.Location = new System.Drawing.Point(303, 318);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(185, 29);
            this.lblEmailAddress.TabIndex = 72;
            this.lblEmailAddress.Text = "Email Address*:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Animated = true;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.lastNameTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lastNameTextBox.DefaultText = "";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.FocusedState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.HoverState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Location = new System.Drawing.Point(861, 252);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PlaceholderText = "Last Name";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.ShadowDecoration.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Size = new System.Drawing.Size(292, 39);
            this.lastNameTextBox.TabIndex = 62;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Animated = true;
            this.firstNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.firstNameTxtBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.firstNameTxtBox.DefaultText = "";
            this.firstNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxtBox.DisabledState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTxtBox.FocusedState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTxtBox.HoverState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Location = new System.Drawing.Point(529, 252);
            this.firstNameTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.PasswordChar = '\0';
            this.firstNameTxtBox.PlaceholderText = "First Name";
            this.firstNameTxtBox.SelectedText = "";
            this.firstNameTxtBox.ShadowDecoration.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Size = new System.Drawing.Size(301, 39);
            this.firstNameTxtBox.TabIndex = 61;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.Location = new System.Drawing.Point(303, 257);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 29);
            this.lblName.TabIndex = 71;
            this.lblName.Text = "Name*:";
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
            // alertTimer
            // 
            this.alertTimer.Enabled = true;
            this.alertTimer.Interval = 5000;
            this.alertTimer.Tick += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // DragableChangeInfo
            // 
            this.DragableChangeInfo.TargetControl = null;
            // 
            // alertPanel
            // 
            this.alertPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.alert_danger_background;
            this.alertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPanel.Controls.Add(this.alertText);
            this.alertPanel.Controls.Add(this.alertCloseBtn);
            this.alertPanel.Controls.Add(this.alertImage);
            this.alertTransition.SetDecoration(this.alertPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertPanel.Location = new System.Drawing.Point(924, 698);
            this.alertPanel.Margin = new System.Windows.Forms.Padding(4);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(408, 68);
            this.alertPanel.TabIndex = 81;
            this.alertPanel.Visible = false;
            // 
            // alertText
            // 
            this.alertText.AutoSize = true;
            this.alertTransition.SetDecoration(this.alertText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.alertText.ForeColor = System.Drawing.Color.Red;
            this.alertText.Location = new System.Drawing.Point(75, 21);
            this.alertText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alertText.Name = "alertText";
            this.alertText.Size = new System.Drawing.Size(116, 25);
            this.alertText.TabIndex = 2;
            this.alertText.Text = "{{alertText}}";
            // 
            // alertCloseBtn
            // 
            this.alertCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.alertCloseBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertCloseBtn.Image = global::webTRON_Management_Software.Properties.Resources.alert_close_icon;
            this.alertCloseBtn.Location = new System.Drawing.Point(359, 21);
            this.alertCloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.alertCloseBtn.Name = "alertCloseBtn";
            this.alertCloseBtn.ShadowDecoration.Parent = this.alertCloseBtn;
            this.alertCloseBtn.Size = new System.Drawing.Size(27, 25);
            this.alertCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertCloseBtn.TabIndex = 1;
            this.alertCloseBtn.TabStop = false;
            // 
            // alertImage
            // 
            this.alertTransition.SetDecoration(this.alertImage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertImage.Image = global::webTRON_Management_Software.Properties.Resources.alert_danger_icon;
            this.alertImage.Location = new System.Drawing.Point(29, 21);
            this.alertImage.Margin = new System.Windows.Forms.Padding(4);
            this.alertImage.Name = "alertImage";
            this.alertImage.ShadowDecoration.Parent = this.alertImage;
            this.alertImage.Size = new System.Drawing.Size(27, 25);
            this.alertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertImage.TabIndex = 0;
            this.alertImage.TabStop = false;
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
            this.btnSignOut.Location = new System.Drawing.Point(0, 576);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(91, 59);
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
            this.btnSettings.Location = new System.Drawing.Point(0, 233);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(91, 59);
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
            this.btnDashboard.Location = new System.Drawing.Point(0, 142);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(91, 59);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(-6, 10);
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.actveForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.alertTransition.SetDecoration(this.activePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(88, 0);
            this.activePanel.Margin = new System.Windows.Forms.Padding(4);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(220, 98);
            this.activePanel.TabIndex = 45;
            // 
            // actveForm
            // 
            this.actveForm.AutoSize = true;
            this.actveForm.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.actveForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.actveForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actveForm.ForeColor = System.Drawing.Color.White;
            this.actveForm.Location = new System.Drawing.Point(85, 49);
            this.actveForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actveForm.Name = "actveForm";
            this.actveForm.Size = new System.Drawing.Size(108, 25);
            this.actveForm.TabIndex = 21;
            this.actveForm.Text = "Dashboard";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.avatar;
            this.activeUserPicture.Location = new System.Drawing.Point(9, 16);
            this.activeUserPicture.Margin = new System.Windows.Forms.Padding(4);
            this.activeUserPicture.Name = "activeUserPicture";
            this.activeUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPicture.ShadowDecoration.Parent = this.activeUserPicture;
            this.activeUserPicture.Size = new System.Drawing.Size(65, 55);
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
            this.activeUserName.Location = new System.Drawing.Point(85, 11);
            this.activeUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(65, 29);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMinimize.Image = global::webTRON_Management_Software.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(1215, 34);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(20, 5);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 43;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Image = global::webTRON_Management_Software.Properties.Resources.close_window;
            this.btnExit.Location = new System.Drawing.Point(1280, 16);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 42;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // ChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 769);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.userIdValue);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.roleValue);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.lbContactNumber);
            this.Controls.Add(this.isOthers);
            this.Controls.Add(this.isFemale);
            this.Controls.Add(this.isMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeInfp";
            this.Load += new System.EventHandler(this.ChangeInfo_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label actveForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
        private System.Windows.Forms.Label userIdValue;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label roleValue;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox contactNumberTextBox;
        private System.Windows.Forms.Label lbContactNumber;
        private Guna.UI2.WinForms.Guna2RadioButton isOthers;
        private Guna.UI2.WinForms.Guna2RadioButton isFemale;
        private Guna.UI2.WinForms.Guna2RadioButton isMale;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label lblDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label lblEmailAddress;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTxtBox;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private System.Windows.Forms.Timer alertTimer;
        private Guna.UI2.WinForms.Guna2DragControl DragableChangeInfo;
    }
}