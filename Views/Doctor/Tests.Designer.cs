
namespace webTRON_Management_Software.Views.Doctor
{
    partial class Tests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tests));
            this.usgCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ctScanCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ecgTestCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.stoolTestCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.urineTestCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.sugarTestCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.bloodTestCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblPrescribedTest = new System.Windows.Forms.Label();
            this.prescribedTestPanel = new System.Windows.Forms.Panel();
            this.xrayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblReferredToValue = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblAgeValue = new System.Windows.Forms.Label();
            this.lblContactValue = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblRegisteredDateValue = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblReferredTo = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPatientIDValue = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegisteredDate = new System.Windows.Forms.Label();
            this.lblRegistrationId = new System.Windows.Forms.Label();
            this.lblTestResults = new System.Windows.Forms.Label();
            this.testResultsPanel = new System.Windows.Forms.Panel();
            this.testsResultDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.activeForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.dragableTestForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.prescribedTestPanel.SuspendLayout();
            this.testResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsResultDataGridView)).BeginInit();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // usgCheckBox
            // 
            this.usgCheckBox.Animated = true;
            this.usgCheckBox.AutoSize = true;
            this.usgCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usgCheckBox.CheckedState.BorderRadius = 2;
            this.usgCheckBox.CheckedState.BorderThickness = 0;
            this.usgCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alertTransition.SetDecoration(this.usgCheckBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.usgCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usgCheckBox.Location = new System.Drawing.Point(865, 15);
            this.usgCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.usgCheckBox.Name = "usgCheckBox";
            this.usgCheckBox.Size = new System.Drawing.Size(77, 29);
            this.usgCheckBox.TabIndex = 7;
            this.usgCheckBox.Text = "USG";
            this.usgCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.usgCheckBox.UncheckedState.BorderRadius = 2;
            this.usgCheckBox.UncheckedState.BorderThickness = 0;
            this.usgCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.usgCheckBox.UseVisualStyleBackColor = true;
            // 
            // ctScanCheckBox
            // 
            this.ctScanCheckBox.Animated = true;
            this.ctScanCheckBox.AutoSize = true;
            this.ctScanCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ctScanCheckBox.CheckedState.BorderRadius = 2;
            this.ctScanCheckBox.CheckedState.BorderThickness = 0;
            this.ctScanCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alertTransition.SetDecoration(this.ctScanCheckBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ctScanCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctScanCheckBox.Location = new System.Drawing.Point(603, 15);
            this.ctScanCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ctScanCheckBox.Name = "ctScanCheckBox";
            this.ctScanCheckBox.Size = new System.Drawing.Size(113, 29);
            this.ctScanCheckBox.TabIndex = 5;
            this.ctScanCheckBox.Text = "CT Scan";
            this.ctScanCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ctScanCheckBox.UncheckedState.BorderRadius = 2;
            this.ctScanCheckBox.UncheckedState.BorderThickness = 0;
            this.ctScanCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ctScanCheckBox.UseVisualStyleBackColor = true;
            // 
            // ecgTestCheckBox
            // 
            this.ecgTestCheckBox.Animated = true;
            this.ecgTestCheckBox.AutoSize = true;
            this.ecgTestCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ecgTestCheckBox.CheckedState.BorderRadius = 2;
            this.ecgTestCheckBox.CheckedState.BorderThickness = 0;
            this.ecgTestCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alertTransition.SetDecoration(this.ecgTestCheckBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ecgTestCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecgTestCheckBox.Location = new System.Drawing.Point(488, 15);
            this.ecgTestCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ecgTestCheckBox.Name = "ecgTestCheckBox";
            this.ecgTestCheckBox.Size = new System.Drawing.Size(77, 29);
            this.ecgTestCheckBox.TabIndex = 4;
            this.ecgTestCheckBox.Text = "ECG";
            this.ecgTestCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ecgTestCheckBox.UncheckedState.BorderRadius = 2;
            this.ecgTestCheckBox.UncheckedState.BorderThickness = 0;
            this.ecgTestCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ecgTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // stoolTestCheckBox
            // 
            this.stoolTestCheckBox.Animated = true;
            this.stoolTestCheckBox.AutoSize = true;
            this.stoolTestCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stoolTestCheckBox.CheckedState.BorderRadius = 2;
            this.stoolTestCheckBox.CheckedState.BorderThickness = 0;
            this.stoolTestCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alertTransition.SetDecoration(this.stoolTestCheckBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.stoolTestCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stoolTestCheckBox.Location = new System.Drawing.Point(361, 15);
            this.stoolTestCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.stoolTestCheckBox.Name = "stoolTestCheckBox";
            this.stoolTestCheckBox.Size = new System.Drawing.Size(79, 29);
            this.stoolTestCheckBox.TabIndex = 3;
            this.stoolTestCheckBox.Text = "Stool";
            this.stoolTestCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.stoolTestCheckBox.UncheckedState.BorderRadius = 2;
            this.stoolTestCheckBox.UncheckedState.BorderThickness = 0;
            this.stoolTestCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.stoolTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // urineTestCheckBox
            // 
            this.urineTestCheckBox.Animated = true;
            this.urineTestCheckBox.AutoSize = true;
            this.urineTestCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.urineTestCheckBox.CheckedState.BorderRadius = 2;
            this.urineTestCheckBox.CheckedState.BorderThickness = 0;
            this.urineTestCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alertTransition.SetDecoration(this.urineTestCheckBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.urineTestCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urineTestCheckBox.Location = new System.Drawing.Point(243, 15);
            this.urineTestCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.urineTestCheckBox.Name = "urineTestCheckBox";
            this.urineTestCheckBox.Size = new System.Drawing.Size(80, 29);
            this.urineTestCheckBox.TabIndex = 2;
            this.urineTestCheckBox.Text = "Urine";
            this.urineTestCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.urineTestCheckBox.UncheckedState.BorderRadius = 2;
            this.urineTestCheckBox.UncheckedState.BorderThickness = 0;
            this.urineTestCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.urineTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // sugarTestCheckBox
            // 
            this.sugarTestCheckBox.Animated = true;
            this.sugarTestCheckBox.AutoSize = true;
            this.sugarTestCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sugarTestCheckBox.CheckedState.BorderRadius = 2;
            this.sugarTestCheckBox.CheckedState.BorderThickness = 0;
            this.sugarTestCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alertTransition.SetDecoration(this.sugarTestCheckBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sugarTestCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sugarTestCheckBox.Location = new System.Drawing.Point(123, 12);
            this.sugarTestCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.sugarTestCheckBox.Name = "sugarTestCheckBox";
            this.sugarTestCheckBox.Size = new System.Drawing.Size(87, 29);
            this.sugarTestCheckBox.TabIndex = 1;
            this.sugarTestCheckBox.Text = "Sugar";
            this.sugarTestCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sugarTestCheckBox.UncheckedState.BorderRadius = 2;
            this.sugarTestCheckBox.UncheckedState.BorderThickness = 0;
            this.sugarTestCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sugarTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // bloodTestCheckBox
            // 
            this.bloodTestCheckBox.Animated = true;
            this.bloodTestCheckBox.AutoSize = true;
            this.bloodTestCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bloodTestCheckBox.CheckedState.BorderRadius = 2;
            this.bloodTestCheckBox.CheckedState.BorderThickness = 0;
            this.bloodTestCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alertTransition.SetDecoration(this.bloodTestCheckBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bloodTestCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bloodTestCheckBox.Location = new System.Drawing.Point(12, 11);
            this.bloodTestCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.bloodTestCheckBox.Name = "bloodTestCheckBox";
            this.bloodTestCheckBox.Size = new System.Drawing.Size(84, 29);
            this.bloodTestCheckBox.TabIndex = 0;
            this.bloodTestCheckBox.Text = "Blood";
            this.bloodTestCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bloodTestCheckBox.UncheckedState.BorderRadius = 2;
            this.bloodTestCheckBox.UncheckedState.BorderThickness = 0;
            this.bloodTestCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bloodTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblPrescribedTest
            // 
            this.lblPrescribedTest.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblPrescribedTest, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPrescribedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrescribedTest.Location = new System.Drawing.Point(20, 185);
            this.lblPrescribedTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrescribedTest.Name = "lblPrescribedTest";
            this.lblPrescribedTest.Size = new System.Drawing.Size(155, 25);
            this.lblPrescribedTest.TabIndex = 146;
            this.lblPrescribedTest.Text = "Prescribed Test:";
            // 
            // prescribedTestPanel
            // 
            this.prescribedTestPanel.Controls.Add(this.usgCheckBox);
            this.prescribedTestPanel.Controls.Add(this.xrayCheckBox);
            this.prescribedTestPanel.Controls.Add(this.ctScanCheckBox);
            this.prescribedTestPanel.Controls.Add(this.ecgTestCheckBox);
            this.prescribedTestPanel.Controls.Add(this.stoolTestCheckBox);
            this.prescribedTestPanel.Controls.Add(this.urineTestCheckBox);
            this.prescribedTestPanel.Controls.Add(this.sugarTestCheckBox);
            this.prescribedTestPanel.Controls.Add(this.bloodTestCheckBox);
            this.alertTransition.SetDecoration(this.prescribedTestPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.prescribedTestPanel.Location = new System.Drawing.Point(16, 219);
            this.prescribedTestPanel.Margin = new System.Windows.Forms.Padding(4);
            this.prescribedTestPanel.Name = "prescribedTestPanel";
            this.prescribedTestPanel.Size = new System.Drawing.Size(1285, 169);
            this.prescribedTestPanel.TabIndex = 145;
            // 
            // xrayCheckBox
            // 
            this.xrayCheckBox.Animated = true;
            this.xrayCheckBox.AutoSize = true;
            this.xrayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.xrayCheckBox.CheckedState.BorderRadius = 2;
            this.xrayCheckBox.CheckedState.BorderThickness = 0;
            this.xrayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alertTransition.SetDecoration(this.xrayCheckBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.xrayCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.xrayCheckBox.Location = new System.Drawing.Point(739, 15);
            this.xrayCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.xrayCheckBox.Name = "xrayCheckBox";
            this.xrayCheckBox.Size = new System.Drawing.Size(95, 29);
            this.xrayCheckBox.TabIndex = 6;
            this.xrayCheckBox.Text = "X-RAY";
            this.xrayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.xrayCheckBox.UncheckedState.BorderRadius = 2;
            this.xrayCheckBox.UncheckedState.BorderThickness = 0;
            this.xrayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.xrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblReferredToValue
            // 
            this.lblReferredToValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblReferredToValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReferredToValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReferredToValue.Location = new System.Drawing.Point(1135, 90);
            this.lblReferredToValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferredToValue.Name = "lblReferredToValue";
            this.lblReferredToValue.Size = new System.Drawing.Size(131, 25);
            this.lblReferredToValue.TabIndex = 140;
            this.lblReferredToValue.Text = "{{referredTo}}";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblGenderValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGenderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderValue.Location = new System.Drawing.Point(884, 113);
            this.lblGenderValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(84, 20);
            this.lblGenderValue.TabIndex = 139;
            this.lblGenderValue.Text = "{{gender}}";
            // 
            // lblAgeValue
            // 
            this.lblAgeValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAgeValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAgeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeValue.Location = new System.Drawing.Point(887, 74);
            this.lblAgeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgeValue.Name = "lblAgeValue";
            this.lblAgeValue.Size = new System.Drawing.Size(60, 20);
            this.lblAgeValue.TabIndex = 138;
            this.lblAgeValue.Text = "{{age}}";
            // 
            // lblContactValue
            // 
            this.lblContactValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblContactValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblContactValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactValue.Location = new System.Drawing.Point(660, 113);
            this.lblContactValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactValue.Name = "lblContactValue";
            this.lblContactValue.Size = new System.Drawing.Size(88, 20);
            this.lblContactValue.TabIndex = 137;
            this.lblContactValue.Text = "{{contact}}";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAddressValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressValue.Location = new System.Drawing.Point(657, 79);
            this.lblAddressValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(93, 20);
            this.lblAddressValue.TabIndex = 136;
            this.lblAddressValue.Text = "{{address}}";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblNameValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValue.Location = new System.Drawing.Point(380, 110);
            this.lblNameValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(74, 20);
            this.lblNameValue.TabIndex = 135;
            this.lblNameValue.Text = "{{name}}";
            // 
            // lblRegisteredDateValue
            // 
            this.lblRegisteredDateValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRegisteredDateValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegisteredDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDateValue.Location = new System.Drawing.Point(380, 76);
            this.lblRegisteredDateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisteredDateValue.Name = "lblRegisteredDateValue";
            this.lblRegisteredDateValue.Size = new System.Drawing.Size(144, 20);
            this.lblRegisteredDateValue.TabIndex = 134;
            this.lblRegisteredDateValue.Text = "{{registeredDate}}";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblGender, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(803, 116);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 133;
            this.lblGender.Text = "Gender:";
            // 
            // lblReferredTo
            // 
            this.lblReferredTo.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblReferredTo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReferredTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReferredTo.Location = new System.Drawing.Point(1012, 90);
            this.lblReferredTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferredTo.Name = "lblReferredTo";
            this.lblReferredTo.Size = new System.Drawing.Size(121, 25);
            this.lblReferredTo.TabIndex = 132;
            this.lblReferredTo.Text = "Referred To:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAge, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(829, 76);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 20);
            this.lblAge.TabIndex = 131;
            this.lblAge.Text = "Age:";
            // 
            // lblPatientIDValue
            // 
            this.lblPatientIDValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblPatientIDValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPatientIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPatientIDValue.Location = new System.Drawing.Point(723, 25);
            this.lblPatientIDValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientIDValue.Name = "lblPatientIDValue";
            this.lblPatientIDValue.Size = new System.Drawing.Size(117, 25);
            this.lblPatientIDValue.TabIndex = 130;
            this.lblPatientIDValue.Text = "{{patientID}}";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblContact, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(569, 113);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(72, 20);
            this.lblContact.TabIndex = 129;
            this.lblContact.Text = "Contact:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(564, 79);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 128;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(317, 111);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 127;
            this.lblName.Text = "Name:";
            // 
            // lblRegisteredDate
            // 
            this.lblRegisteredDate.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRegisteredDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegisteredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDate.Location = new System.Drawing.Point(229, 76);
            this.lblRegisteredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisteredDate.Name = "lblRegisteredDate";
            this.lblRegisteredDate.Size = new System.Drawing.Size(136, 20);
            this.lblRegisteredDate.TabIndex = 126;
            this.lblRegisteredDate.Text = "Registered Date:";
            // 
            // lblRegistrationId
            // 
            this.lblRegistrationId.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRegistrationId, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegistrationId.Location = new System.Drawing.Point(603, 26);
            this.lblRegistrationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationId.Name = "lblRegistrationId";
            this.lblRegistrationId.Size = new System.Drawing.Size(102, 25);
            this.lblRegistrationId.TabIndex = 125;
            this.lblRegistrationId.Text = "Patient ID:";
            // 
            // lblTestResults
            // 
            this.lblTestResults.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblTestResults, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblTestResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTestResults.Location = new System.Drawing.Point(20, 401);
            this.lblTestResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestResults.Name = "lblTestResults";
            this.lblTestResults.Size = new System.Drawing.Size(126, 25);
            this.lblTestResults.TabIndex = 147;
            this.lblTestResults.Text = "Test Results:";
            // 
            // testResultsPanel
            // 
            this.testResultsPanel.Controls.Add(this.testsResultDataGridView);
            this.alertTransition.SetDecoration(this.testResultsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.testResultsPanel.Location = new System.Drawing.Point(25, 436);
            this.testResultsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.testResultsPanel.Name = "testResultsPanel";
            this.testResultsPanel.Size = new System.Drawing.Size(1276, 262);
            this.testResultsPanel.TabIndex = 149;
            // 
            // testsResultDataGridView
            // 
            this.testsResultDataGridView.AllowUserToAddRows = false;
            this.testsResultDataGridView.AllowUserToDeleteRows = false;
            this.testsResultDataGridView.AllowUserToResizeColumns = false;
            this.testsResultDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.testsResultDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.testsResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testsResultDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.testsResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testsResultDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.testsResultDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testsResultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.testsResultDataGridView.ColumnHeadersHeight = 30;
            this.testsResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.alertTransition.SetDecoration(this.testsResultDataGridView, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.testsResultDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.testsResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testsResultDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.testsResultDataGridView.EnableHeadersVisualStyles = false;
            this.testsResultDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.testsResultDataGridView.Location = new System.Drawing.Point(0, 0);
            this.testsResultDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.testsResultDataGridView.MultiSelect = false;
            this.testsResultDataGridView.Name = "testsResultDataGridView";
            this.testsResultDataGridView.ReadOnly = true;
            this.testsResultDataGridView.RowHeadersVisible = false;
            this.testsResultDataGridView.RowHeadersWidth = 51;
            this.testsResultDataGridView.RowTemplate.Height = 28;
            this.testsResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testsResultDataGridView.Size = new System.Drawing.Size(1276, 262);
            this.testsResultDataGridView.TabIndex = 33;
            this.testsResultDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.testsResultDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.testsResultDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.testsResultDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.testsResultDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.testsResultDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.testsResultDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.testsResultDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.testsResultDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.testsResultDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.testsResultDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.testsResultDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.testsResultDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.testsResultDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.testsResultDataGridView.ThemeStyle.ReadOnly = true;
            this.testsResultDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.testsResultDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.testsResultDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.testsResultDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.testsResultDataGridView.ThemeStyle.RowsStyle.Height = 28;
            this.testsResultDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.testsResultDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // alertPanel
            // 
            this.alertPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.alert_danger_background;
            this.alertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPanel.Controls.Add(this.alertText);
            this.alertPanel.Controls.Add(this.alertCloseBtn);
            this.alertPanel.Controls.Add(this.alertImage);
            this.alertTransition.SetDecoration(this.alertPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertPanel.Location = new System.Drawing.Point(-8, 708);
            this.alertPanel.Margin = new System.Windows.Forms.Padding(4);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(408, 68);
            this.alertPanel.TabIndex = 102;
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
            this.alertCloseBtn.Click += new System.EventHandler(this.AlertTimer_Tick);
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
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.alertTransition.SetDecoration(this.btnNext, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = global::webTRON_Management_Software.Properties.Resources.alert_icon;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.Location = new System.Drawing.Point(1164, 709);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(155, 52);
            this.btnNext.TabIndex = 148;
            this.btnNext.Text = "Next";
            this.btnNext.TextOffset = new System.Drawing.Point(-1, 0);
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.activeForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.alertTransition.SetDecoration(this.activePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(-3, -1);
            this.activePanel.Margin = new System.Windows.Forms.Padding(4);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(220, 98);
            this.activePanel.TabIndex = 124;
            // 
            // activeForm
            // 
            this.activeForm.AutoSize = true;
            this.activeForm.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeForm.ForeColor = System.Drawing.Color.White;
            this.activeForm.Location = new System.Drawing.Point(85, 49);
            this.activeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeForm.Name = "activeForm";
            this.activeForm.Size = new System.Drawing.Size(108, 25);
            this.activeForm.TabIndex = 21;
            this.activeForm.Text = "Dashboard";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.avatar;
            this.activeUserPicture.Location = new System.Drawing.Point(0, 18);
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
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1216, 33);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 123;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1281, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 122;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(1178, 21);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(20, 18);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 150;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // alertTimer
            // 
            this.alertTimer.Enabled = true;
            this.alertTimer.Interval = 5000;
            this.alertTimer.Tick += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // dragableTestForm
            // 
            this.dragableTestForm.TargetControl = this;
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 769);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.testResultsPanel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTestResults);
            this.Controls.Add(this.lblPrescribedTest);
            this.Controls.Add(this.prescribedTestPanel);
            this.Controls.Add(this.lblReferredToValue);
            this.Controls.Add(this.lblGenderValue);
            this.Controls.Add(this.lblAgeValue);
            this.Controls.Add(this.lblContactValue);
            this.Controls.Add(this.lblAddressValue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblRegisteredDateValue);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblReferredTo);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPatientIDValue);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegisteredDate);
            this.Controls.Add(this.lblRegistrationId);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.Tests_Load);
            this.prescribedTestPanel.ResumeLayout(false);
            this.prescribedTestPanel.PerformLayout();
            this.testResultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testsResultDataGridView)).EndInit();
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox usgCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox ctScanCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox ecgTestCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox stoolTestCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox urineTestCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox sugarTestCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox bloodTestCheckBox;
        private System.Windows.Forms.Label lblPrescribedTest;
        private System.Windows.Forms.Panel prescribedTestPanel;
        private Guna.UI2.WinForms.Guna2CheckBox xrayCheckBox;
        private System.Windows.Forms.Label activeForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private System.Windows.Forms.Label lblReferredToValue;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblAgeValue;
        private System.Windows.Forms.Label lblContactValue;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblRegisteredDateValue;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblReferredTo;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPatientIDValue;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRegisteredDate;
        private System.Windows.Forms.Label lblRegistrationId;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private System.Windows.Forms.Label lblTestResults;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Panel testResultsPanel;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
        private System.Windows.Forms.Timer alertTimer;
        private Guna.UI2.WinForms.Guna2DragControl dragableTestForm;
        private Guna.UI2.WinForms.Guna2DataGridView testsResultDataGridView;
        private Guna.UI2.WinForms.Guna2PictureBox btnBack;
    }
}