namespace webTRON_Management_Software.Views.Accountant
{
    partial class RenewPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewPatient));
            this.DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.registrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referredTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dragableOnRenewPatient = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.roleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.patientSerialNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.yearComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMinus1 = new System.Windows.Forms.Label();
            this.lblMinus2 = new System.Windows.Forms.Label();
            this.btnRenew = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.actveForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeight = 40;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumber,
            this.registrationDate,
            this.firstName,
            this.lastName,
            this.sex,
            this.age,
            this.contactNumber,
            this.address,
            this.status,
            this.referredTo});
            this.alertTransition.SetDecoration(this.DataGridView, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.Enabled = false;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.Location = new System.Drawing.Point(12, 192);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(960, 63);
            this.DataGridView.TabIndex = 58;
            this.DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridView.ThemeStyle.ReadOnly = true;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // registrationNumber
            // 
            this.registrationNumber.FillWeight = 140F;
            this.registrationNumber.HeaderText = "Patient ID";
            this.registrationNumber.Name = "registrationNumber";
            this.registrationNumber.ReadOnly = true;
            // 
            // registrationDate
            // 
            this.registrationDate.HeaderText = "Registration Date";
            this.registrationDate.Name = "registrationDate";
            this.registrationDate.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.FillWeight = 150F;
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.FillWeight = 140F;
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Gender";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // referredTo
            // 
            this.referredTo.HeaderText = "Referred To";
            this.referredTo.Name = "referredTo";
            this.referredTo.ReadOnly = true;
            // 
            // dragableOnRenewPatient
            // 
            this.dragableOnRenewPatient.TargetControl = this;
            // 
            // roleTextBox
            // 
            this.roleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.roleTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.roleTextBox.DefaultText = "PTN";
            this.roleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleTextBox.DisabledState.Parent = this.roleTextBox;
            this.roleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleTextBox.FocusedState.Parent = this.roleTextBox;
            this.roleTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.roleTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.roleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleTextBox.HoverState.Parent = this.roleTextBox;
            this.roleTextBox.Location = new System.Drawing.Point(327, 120);
            this.roleTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.PasswordChar = '\0';
            this.roleTextBox.PlaceholderText = "";
            this.roleTextBox.SelectedText = "";
            this.roleTextBox.SelectionStart = 3;
            this.roleTextBox.ShadowDecoration.Parent = this.roleTextBox;
            this.roleTextBox.Size = new System.Drawing.Size(106, 36);
            this.roleTextBox.TabIndex = 59;
            this.roleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patientSerialNumberTextBox
            // 
            this.patientSerialNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.patientSerialNumberTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.patientSerialNumberTextBox.DefaultText = "";
            this.patientSerialNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.patientSerialNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.patientSerialNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patientSerialNumberTextBox.DisabledState.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patientSerialNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patientSerialNumberTextBox.FocusedState.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.patientSerialNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patientSerialNumberTextBox.HoverState.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.Location = new System.Drawing.Point(617, 120);
            this.patientSerialNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientSerialNumberTextBox.Name = "patientSerialNumberTextBox";
            this.patientSerialNumberTextBox.PasswordChar = '\0';
            this.patientSerialNumberTextBox.PlaceholderText = "Serial Number";
            this.patientSerialNumberTextBox.SelectedText = "";
            this.patientSerialNumberTextBox.ShadowDecoration.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.Size = new System.Drawing.Size(106, 36);
            this.patientSerialNumberTextBox.TabIndex = 1;
            this.patientSerialNumberTextBox.TextChanged += new System.EventHandler(this.PatientSerialNumberTextBox_TextChanged);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblPatientID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(204, 124);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(114, 26);
            this.lblPatientID.TabIndex = 62;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.yearComboBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.yearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.yearComboBox.FocusedState.Parent = this.yearComboBox;
            this.yearComboBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.yearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.HoverState.Parent = this.yearComboBox;
            this.yearComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.yearComboBox.ItemHeight = 30;
            this.yearComboBox.ItemsAppearance.Parent = this.yearComboBox;
            this.yearComboBox.Location = new System.Drawing.Point(472, 120);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.ShadowDecoration.Parent = this.yearComboBox;
            this.yearComboBox.Size = new System.Drawing.Size(106, 36);
            this.yearComboBox.TabIndex = 63;
            this.yearComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMinus1
            // 
            this.lblMinus1.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblMinus1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblMinus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus1.Location = new System.Drawing.Point(442, 124);
            this.lblMinus1.Name = "lblMinus1";
            this.lblMinus1.Size = new System.Drawing.Size(19, 26);
            this.lblMinus1.TabIndex = 64;
            this.lblMinus1.Text = "-";
            // 
            // lblMinus2
            // 
            this.lblMinus2.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblMinus2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblMinus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus2.Location = new System.Drawing.Point(588, 124);
            this.lblMinus2.Name = "lblMinus2";
            this.lblMinus2.Size = new System.Drawing.Size(19, 26);
            this.lblMinus2.TabIndex = 65;
            this.lblMinus2.Text = "-";
            // 
            // btnRenew
            // 
            this.btnRenew.CheckedState.Parent = this.btnRenew;
            this.btnRenew.CustomImages.Parent = this.btnRenew;
            this.alertTransition.SetDecoration(this.btnRenew, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRenew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.HoverState.Parent = this.btnRenew;
            this.btnRenew.Location = new System.Drawing.Point(792, 509);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.ShadowDecoration.Parent = this.btnRenew;
            this.btnRenew.Size = new System.Drawing.Size(180, 45);
            this.btnRenew.TabIndex = 66;
            this.btnRenew.Text = "Renew";
            this.btnRenew.Click += new System.EventHandler(this.BtnRenew_Click);
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
            this.btnMinimize.TabIndex = 54;
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
            this.btnExit.TabIndex = 53;
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
            this.alertTransition.SetDecoration(this.activePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(-1, 0);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(165, 80);
            this.activePanel.TabIndex = 67;
            // 
            // actveForm
            // 
            this.actveForm.AutoSize = true;
            this.actveForm.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.actveForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.actveForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actveForm.ForeColor = System.Drawing.Color.White;
            this.actveForm.Location = new System.Drawing.Point(51, 38);
            this.actveForm.Name = "actveForm";
            this.actveForm.Size = new System.Drawing.Size(113, 20);
            this.actveForm.TabIndex = 21;
            this.actveForm.Text = "Renew Patient";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.avatar;
            this.activeUserPicture.Location = new System.Drawing.Point(4, 13);
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
            this.activeUserName.Location = new System.Drawing.Point(56, 9);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(52, 24);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(862, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(20, 18);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 68;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
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
            // 
            // alertTimer
            // 
            this.alertTimer.Enabled = true;
            this.alertTimer.Interval = 5000;
            this.alertTimer.Tick += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // alertPanel
            // 
            this.alertPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.alert_danger_background;
            this.alertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPanel.Controls.Add(this.alertText);
            this.alertPanel.Controls.Add(this.alertCloseBtn);
            this.alertPanel.Controls.Add(this.alertImage);
            this.alertTransition.SetDecoration(this.alertPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertPanel.Location = new System.Drawing.Point(700, 573);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(306, 55);
            this.alertPanel.TabIndex = 88;
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
            // RenewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.lblMinus2);
            this.Controls.Add(this.lblMinus1);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.patientSerialNumberTextBox);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RenewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenewPatient";
            this.Load += new System.EventHandler(this.RenewPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Guna.UI2.WinForms.Guna2DragControl dragableOnRenewPatient;
        private System.Windows.Forms.Label lblPatientID;
        private Guna.UI2.WinForms.Guna2TextBox patientSerialNumberTextBox;
        private Guna.UI2.WinForms.Guna2TextBox roleTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox yearComboBox;
        private System.Windows.Forms.Label lblMinus2;
        private System.Windows.Forms.Label lblMinus1;
        private Guna.UI2.WinForms.Guna2Button btnRenew;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label actveForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn referredTo;
        private Guna.UI2.WinForms.Guna2PictureBox btnBack;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private System.Windows.Forms.Timer alertTimer;
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
    }
}