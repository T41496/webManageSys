
namespace webTRON_Management_Software.Views.Accountant
{
    partial class SearchAndUpdatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAndUpdatePatient));
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
            this.dragableForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.actveForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.contactNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbContactNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblReferredTo = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblReferredToValue = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblRegistrationDateValue = new System.Windows.Forms.Label();
            this.lblPatientIDValue = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
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
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.Location = new System.Drawing.Point(1, 398);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(999, 192);
            this.DataGridView.TabIndex = 57;
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
            this.DataGridView.ThemeStyle.ReadOnly = false;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // registrationNumber
            // 
            this.registrationNumber.FillWeight = 150F;
            this.registrationNumber.HeaderText = "Patient ID";
            this.registrationNumber.Name = "registrationNumber";
            // 
            // registrationDate
            // 
            this.registrationDate.HeaderText = "Registration Date";
            this.registrationDate.Name = "registrationDate";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // sex
            // 
            this.sex.HeaderText = "Gender";
            this.sex.Name = "sex";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.Name = "contactNumber";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // referredTo
            // 
            this.referredTo.HeaderText = "Referred To";
            this.referredTo.Name = "referredTo";
            // 
            // dragableForm
            // 
            this.dragableForm.TargetControl = this;
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.actveForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.alertTransition.SetDecoration(this.activePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(0, 0);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(165, 80);
            this.activePanel.TabIndex = 58;
            // 
            // actveForm
            // 
            this.actveForm.AutoSize = true;
            this.actveForm.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.actveForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.actveForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actveForm.ForeColor = System.Drawing.Color.White;
            this.actveForm.Location = new System.Drawing.Point(64, 38);
            this.actveForm.Name = "actveForm";
            this.actveForm.Size = new System.Drawing.Size(60, 20);
            this.actveForm.TabIndex = 21;
            this.actveForm.Text = "Search";
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
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(907, 18);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 52;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(949, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 51;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Animated = true;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.searchTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.Parent = this.searchTextBox;
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.FocusedState.Parent = this.searchTextBox;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.HoverState.Parent = this.searchTextBox;
            this.searchTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchTextBox.IconRight")));
            this.searchTextBox.Location = new System.Drawing.Point(7, 357);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(226, 32);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
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
            this.btnUpdate.Image = global::webTRON_Management_Software.Properties.Resources.PlusSign;
            this.btnUpdate.Location = new System.Drawing.Point(773, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.alertTransition.SetDecoration(this.btnClear, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClear.FillColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(773, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(180, 45);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
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
            this.addressTextBox.Location = new System.Drawing.Point(312, 75);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PlaceholderText = "Address";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.ShadowDecoration.Parent = this.addressTextBox;
            this.addressTextBox.Size = new System.Drawing.Size(239, 32);
            this.addressTextBox.TabIndex = 63;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.Location = new System.Drawing.Point(201, 75);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 24);
            this.lblAddress.TabIndex = 74;
            this.lblAddress.Text = "Address:";
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
            this.contactNumberTextBox.Location = new System.Drawing.Point(312, 221);
            this.contactNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.PasswordChar = '\0';
            this.contactNumberTextBox.PlaceholderText = "Contact Number";
            this.contactNumberTextBox.SelectedText = "";
            this.contactNumberTextBox.ShadowDecoration.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Size = new System.Drawing.Size(239, 32);
            this.contactNumberTextBox.TabIndex = 68;
            // 
            // lbContactNumber
            // 
            this.lbContactNumber.AutoSize = true;
            this.alertTransition.SetDecoration(this.lbContactNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbContactNumber.Location = new System.Drawing.Point(121, 221);
            this.lbContactNumber.Name = "lbContactNumber";
            this.lbContactNumber.Size = new System.Drawing.Size(152, 24);
            this.lbContactNumber.TabIndex = 73;
            this.lbContactNumber.Text = "Contact Number:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblGender, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGender.Location = new System.Drawing.Point(201, 174);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 24);
            this.lblGender.TabIndex = 72;
            this.lblGender.Text = "Gender:";
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
            this.lastNameTextBox.Location = new System.Drawing.Point(560, 26);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PlaceholderText = "Last Name";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.ShadowDecoration.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Size = new System.Drawing.Size(219, 32);
            this.lastNameTextBox.TabIndex = 61;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Animated = true;
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.firstNameTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.firstNameTextBox.DefaultText = "";
            this.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.DisabledState.Parent = this.firstNameTextBox;
            this.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.FocusedState.Parent = this.firstNameTextBox;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.HoverState.Parent = this.firstNameTextBox;
            this.firstNameTextBox.Location = new System.Drawing.Point(312, 26);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PlaceholderText = "First Name";
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.ShadowDecoration.Parent = this.firstNameTextBox;
            this.firstNameTextBox.Size = new System.Drawing.Size(239, 32);
            this.firstNameTextBox.TabIndex = 60;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.Location = new System.Drawing.Point(221, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 24);
            this.lblName.TabIndex = 69;
            this.lblName.Text = "Name:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Animated = true;
            this.ageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.ageTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ageTextBox.DefaultText = "";
            this.ageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageTextBox.DisabledState.Parent = this.ageTextBox;
            this.ageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageTextBox.FocusedState.Parent = this.ageTextBox;
            this.ageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ageTextBox.ForeColor = System.Drawing.Color.Black;
            this.ageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageTextBox.HoverState.Parent = this.ageTextBox;
            this.ageTextBox.Location = new System.Drawing.Point(312, 122);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.PasswordChar = '\0';
            this.ageTextBox.PlaceholderText = "Age";
            this.ageTextBox.SelectedText = "";
            this.ageTextBox.ShadowDecoration.Parent = this.ageTextBox;
            this.ageTextBox.Size = new System.Drawing.Size(70, 32);
            this.ageTextBox.TabIndex = 75;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAge, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAge.Location = new System.Drawing.Point(236, 122);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 24);
            this.lblAge.TabIndex = 76;
            this.lblAge.Text = "Age:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblStatus, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatus.Location = new System.Drawing.Point(208, 306);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 24);
            this.lblStatus.TabIndex = 77;
            this.lblStatus.Text = "Status:";
            // 
            // lblReferredTo
            // 
            this.lblReferredTo.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblReferredTo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReferredTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblReferredTo.Location = new System.Drawing.Point(157, 263);
            this.lblReferredTo.Name = "lblReferredTo";
            this.lblReferredTo.Size = new System.Drawing.Size(116, 24);
            this.lblReferredTo.TabIndex = 78;
            this.lblReferredTo.Text = "Referred To:";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRegistrationDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistrationDate.Location = new System.Drawing.Point(638, 141);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(156, 24);
            this.lblRegistrationDate.TabIndex = 79;
            this.lblRegistrationDate.Text = "Registration Date:";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblPatientID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPatientID.Location = new System.Drawing.Point(701, 103);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(93, 24);
            this.lblPatientID.TabIndex = 80;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblGenderValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGenderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGenderValue.Location = new System.Drawing.Point(308, 174);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(88, 24);
            this.lblGenderValue.TabIndex = 81;
            this.lblGenderValue.Text = "-------------";
            // 
            // lblReferredToValue
            // 
            this.lblReferredToValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblReferredToValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReferredToValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblReferredToValue.Location = new System.Drawing.Point(308, 263);
            this.lblReferredToValue.Name = "lblReferredToValue";
            this.lblReferredToValue.Size = new System.Drawing.Size(88, 24);
            this.lblReferredToValue.TabIndex = 82;
            this.lblReferredToValue.Text = "-------------";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblStatusValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatusValue.Location = new System.Drawing.Point(308, 306);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(88, 24);
            this.lblStatusValue.TabIndex = 83;
            this.lblStatusValue.Text = "-------------";
            // 
            // lblRegistrationDateValue
            // 
            this.lblRegistrationDateValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRegistrationDateValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegistrationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistrationDateValue.Location = new System.Drawing.Point(800, 141);
            this.lblRegistrationDateValue.Name = "lblRegistrationDateValue";
            this.lblRegistrationDateValue.Size = new System.Drawing.Size(88, 24);
            this.lblRegistrationDateValue.TabIndex = 84;
            this.lblRegistrationDateValue.Text = "-------------";
            // 
            // lblPatientIDValue
            // 
            this.lblPatientIDValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblPatientIDValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPatientIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPatientIDValue.Location = new System.Drawing.Point(800, 103);
            this.lblPatientIDValue.Name = "lblPatientIDValue";
            this.lblPatientIDValue.Size = new System.Drawing.Size(88, 24);
            this.lblPatientIDValue.TabIndex = 85;
            this.lblPatientIDValue.Text = "-------------";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(866, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(20, 18);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 86;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // alertPanel
            // 
            this.alertPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.alert_danger_background;
            this.alertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPanel.Controls.Add(this.alertText);
            this.alertPanel.Controls.Add(this.alertCloseBtn);
            this.alertPanel.Controls.Add(this.alertImage);
            this.alertTransition.SetDecoration(this.alertPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertPanel.Location = new System.Drawing.Point(694, 568);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(306, 55);
            this.alertPanel.TabIndex = 87;
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
            // SearchAndUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPatientIDValue);
            this.Controls.Add(this.lblRegistrationDateValue);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblReferredToValue);
            this.Controls.Add(this.lblGenderValue);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.lblReferredTo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.lbContactNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchAndUpdatePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchAndUpdatePatient";
            this.Load += new System.EventHandler(this.SearchAndUpdatePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Guna.UI2.WinForms.Guna2DragControl dragableForm;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label actveForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox contactNumberTextBox;
        private System.Windows.Forms.Label lbContactNumber;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox ageTextBox;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblReferredTo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblPatientIDValue;
        private System.Windows.Forms.Label lblRegistrationDateValue;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblReferredToValue;
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
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private System.Windows.Forms.Timer alertTimer;
    }
}