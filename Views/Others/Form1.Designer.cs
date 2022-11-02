
namespace webTRON_Management_Software.Views.Others
{
    partial class Form1
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
            this.btnAddTopic = new Guna.UI2.WinForms.Guna2Button();
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
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegisteredDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.CheckedState.Parent = this.btnAddTopic;
            this.btnAddTopic.CustomImages.Parent = this.btnAddTopic;
            this.btnAddTopic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnAddTopic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddTopic.ForeColor = System.Drawing.Color.White;
            this.btnAddTopic.HoverState.Parent = this.btnAddTopic;
            this.btnAddTopic.Image = global::webTRON_Management_Software.Properties.Resources.PlusSign;
            this.btnAddTopic.Location = new System.Drawing.Point(301, 205);
            this.btnAddTopic.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.ShadowDecoration.Parent = this.btnAddTopic;
            this.btnAddTopic.Size = new System.Drawing.Size(199, 41);
            this.btnAddTopic.TabIndex = 1;
            this.btnAddTopic.Text = "Add Topic";
            // 
            // lblReferredToValue
            // 
            this.lblReferredToValue.AutoSize = true;
            this.lblReferredToValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReferredToValue.Location = new System.Drawing.Point(1053, 376);
            this.lblReferredToValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferredToValue.Name = "lblReferredToValue";
            this.lblReferredToValue.Size = new System.Drawing.Size(131, 25);
            this.lblReferredToValue.TabIndex = 104;
            this.lblReferredToValue.Text = "{{referredTo}}";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.AutoSize = true;
            this.lblGenderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderValue.Location = new System.Drawing.Point(803, 399);
            this.lblGenderValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(84, 20);
            this.lblGenderValue.TabIndex = 103;
            this.lblGenderValue.Text = "{{gender}}";
            // 
            // lblAgeValue
            // 
            this.lblAgeValue.AutoSize = true;
            this.lblAgeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeValue.Location = new System.Drawing.Point(805, 360);
            this.lblAgeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgeValue.Name = "lblAgeValue";
            this.lblAgeValue.Size = new System.Drawing.Size(60, 20);
            this.lblAgeValue.TabIndex = 102;
            this.lblAgeValue.Text = "{{age}}";
            // 
            // lblContactValue
            // 
            this.lblContactValue.AutoSize = true;
            this.lblContactValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactValue.Location = new System.Drawing.Point(579, 399);
            this.lblContactValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactValue.Name = "lblContactValue";
            this.lblContactValue.Size = new System.Drawing.Size(88, 20);
            this.lblContactValue.TabIndex = 101;
            this.lblContactValue.Text = "{{contact}}";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressValue.Location = new System.Drawing.Point(576, 365);
            this.lblAddressValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(93, 20);
            this.lblAddressValue.TabIndex = 100;
            this.lblAddressValue.Text = "{{address}}";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValue.Location = new System.Drawing.Point(299, 396);
            this.lblNameValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(74, 20);
            this.lblNameValue.TabIndex = 99;
            this.lblNameValue.Text = "{{name}}";
            // 
            // lblRegisteredDateValue
            // 
            this.lblRegisteredDateValue.AutoSize = true;
            this.lblRegisteredDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDateValue.Location = new System.Drawing.Point(299, 362);
            this.lblRegisteredDateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisteredDateValue.Name = "lblRegisteredDateValue";
            this.lblRegisteredDateValue.Size = new System.Drawing.Size(144, 20);
            this.lblRegisteredDateValue.TabIndex = 98;
            this.lblRegisteredDateValue.Text = "{{registeredDate}}";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(721, 402);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 97;
            this.lblGender.Text = "Gender:";
            // 
            // lblReferredTo
            // 
            this.lblReferredTo.AutoSize = true;
            this.lblReferredTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReferredTo.Location = new System.Drawing.Point(931, 376);
            this.lblReferredTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferredTo.Name = "lblReferredTo";
            this.lblReferredTo.Size = new System.Drawing.Size(121, 25);
            this.lblReferredTo.TabIndex = 96;
            this.lblReferredTo.Text = "Referred To:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(748, 362);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 20);
            this.lblAge.TabIndex = 95;
            this.lblAge.Text = "Age:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(488, 399);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(72, 20);
            this.lblContact.TabIndex = 94;
            this.lblContact.Text = "Contact:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(483, 365);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 93;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(236, 397);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 92;
            this.lblName.Text = "Name:";
            // 
            // lblRegisteredDate
            // 
            this.lblRegisteredDate.AutoSize = true;
            this.lblRegisteredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDate.Location = new System.Drawing.Point(148, 362);
            this.lblRegisteredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisteredDate.Name = "lblRegisteredDate";
            this.lblRegisteredDate.Size = new System.Drawing.Size(136, 20);
            this.lblRegisteredDate.TabIndex = 91;
            this.lblRegisteredDate.Text = "Registered Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 783);
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
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegisteredDate);
            this.Controls.Add(this.btnAddTopic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddTopic;
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
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRegisteredDate;
    }
}