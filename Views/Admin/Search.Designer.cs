
namespace webTRON_Management_Software.Views.Admin
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.DragableSearch = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.activeUserPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.activeForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.selectedUserDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserIdValue = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.activeUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.selectedUserDetailsPanel.SuspendLayout();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DragableSearch
            // 
            this.DragableSearch.TargetControl = this;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSignOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnUsers);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.alertTransition.SetDecoration(this.sidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(-1, -4);
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
            this.alertTransition.SetDecoration(this.btnUsers, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeight = 45;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.alertTransition.SetDecoration(this.DataGridView, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.Location = new System.Drawing.Point(69, 232);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(929, 363);
            this.DataGridView.TabIndex = 31;
            this.DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.DataGridView.ThemeStyle.ReadOnly = true;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView.ThemeStyle.RowsStyle.Height = 28;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.DataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Animated = true;
            this.searchTextBox.AutoRoundedCorners = true;
            this.searchTextBox.BorderRadius = 15;
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
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.HoverState.Parent = this.searchTextBox;
            this.searchTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchTextBox.IconRight")));
            this.searchTextBox.Location = new System.Drawing.Point(694, 191);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Search Here";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(304, 32);
            this.searchTextBox.TabIndex = 32;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // activeUserPanel
            // 
            this.activeUserPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activeUserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activeUserPanel.Controls.Add(this.activeForm);
            this.activeUserPanel.Controls.Add(this.activeUserPicture);
            this.activeUserPanel.Controls.Add(this.activeUserName);
            this.alertTransition.SetDecoration(this.activeUserPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPanel.Location = new System.Drawing.Point(60, -5);
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
            this.activeForm.Size = new System.Drawing.Size(51, 20);
            this.activeForm.TabIndex = 21;
            this.activeForm.Text = "Users";
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
            this.btnMinimize.Location = new System.Drawing.Point(921, 17);
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
            this.btnExit.Location = new System.Drawing.Point(970, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 27;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 21;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.alertTransition.SetDecoration(this.btnDelete, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(694, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(136, 45);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // selectedUserDetailsPanel
            // 
            this.selectedUserDetailsPanel.Controls.Add(this.lblRoleValue);
            this.selectedUserDetailsPanel.Controls.Add(this.lblRole);
            this.selectedUserDetailsPanel.Controls.Add(this.lblFullNameValue);
            this.selectedUserDetailsPanel.Controls.Add(this.lblFullName);
            this.selectedUserDetailsPanel.Controls.Add(this.lblUserIdValue);
            this.selectedUserDetailsPanel.Controls.Add(this.lblUserID);
            this.alertTransition.SetDecoration(this.selectedUserDetailsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.selectedUserDetailsPanel.Location = new System.Drawing.Point(231, 39);
            this.selectedUserDetailsPanel.Name = "selectedUserDetailsPanel";
            this.selectedUserDetailsPanel.ShadowDecoration.Parent = this.selectedUserDetailsPanel;
            this.selectedUserDetailsPanel.Size = new System.Drawing.Size(402, 171);
            this.selectedUserDetailsPanel.TabIndex = 57;
            this.selectedUserDetailsPanel.Visible = false;
            // 
            // lblRoleValue
            // 
            this.lblRoleValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRoleValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRoleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRoleValue.ForeColor = System.Drawing.Color.Black;
            this.lblRoleValue.Location = new System.Drawing.Point(146, 128);
            this.lblRoleValue.Name = "lblRoleValue";
            this.lblRoleValue.Size = new System.Drawing.Size(73, 24);
            this.lblRoleValue.TabIndex = 62;
            this.lblRoleValue.Text = "{{Role}}";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Location = new System.Drawing.Point(20, 128);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(54, 24);
            this.lblRole.TabIndex = 61;
            this.lblRole.Text = "Role:";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblFullNameValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFullNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFullNameValue.ForeColor = System.Drawing.Color.Black;
            this.lblFullNameValue.Location = new System.Drawing.Point(146, 82);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(108, 24);
            this.lblFullNameValue.TabIndex = 60;
            this.lblFullNameValue.Text = "{{fullName}}";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblFullName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(20, 82);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(102, 24);
            this.lblFullName.TabIndex = 59;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblUserIdValue
            // 
            this.lblUserIdValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblUserIdValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUserIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblUserIdValue.ForeColor = System.Drawing.Color.Black;
            this.lblUserIdValue.Location = new System.Drawing.Point(146, 34);
            this.lblUserIdValue.Name = "lblUserIdValue";
            this.lblUserIdValue.Size = new System.Drawing.Size(88, 24);
            this.lblUserIdValue.TabIndex = 58;
            this.lblUserIdValue.Text = "{{userID}}";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblUserID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(20, 34);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(76, 24);
            this.lblUserID.TabIndex = 57;
            this.lblUserID.Text = "User ID:";
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
            this.alertPanel.Location = new System.Drawing.Point(692, 567);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(306, 55);
            this.alertPanel.TabIndex = 58;
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
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.selectedUserDetailsPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.activeUserPanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.activeUserPanel.ResumeLayout(false);
            this.activeUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.selectedUserDetailsPanel.ResumeLayout(false);
            this.selectedUserDetailsPanel.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2DragControl DragableSearch;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel activeUserPanel;
        private System.Windows.Forms.Label activeForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Panel selectedUserDetailsPanel;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUserIdValue;
        private System.Windows.Forms.Label lblUserID;
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
        private System.Windows.Forms.Timer alertTimer;
    }
}