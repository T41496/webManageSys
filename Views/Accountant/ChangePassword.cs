﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Utils;
using webTRON_Management_Software.Utils.Validators;
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Accountant
{
    public partial class ChangePassword : Form
    {
        string newPassword = "", confirmPassword = "";

        //Instantiate Employee Class
        Employee employee = new Employee();
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }
        //Load event on form
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            //Initialize active user details
            InitializeActiverUserDetails();
        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            activeUserName.Text = employee.FirstName;
            if (employee.img != null)
            {
                //Change active user picture
                MemoryStream ms = new MemoryStream(employee.img);
                activeUserPicture.Image = Image.FromStream(ms);
            }

        }

        private void SignOut(object sender, EventArgs e)
        {
            //WARNING:To check which element has clicked          
            string elementType = sender.GetType().ToString();
            var value = MessageBox.Show("Are you sure?", "Sign out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (value.ToString() == "Yes")
            {
                Employee.SetStatus(employee.UserID, "Offline");
                //It ensures sign out has clicked
                if (elementType == "Guna.UI2.WinForms.Guna2Button")
                {
                    LandingWindow landingWindow = new LandingWindow();
                    landingWindow.Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }


            }

        }
        //Click Event on Minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click Event on Dashboard button
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Hide();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPasswordTextBox.Text))
            {
                currentPasswordTextBox.BorderColor = Color.Red;

            }
            if (string.IsNullOrEmpty(newPasswordTextBox.Text))
            {
                newPasswordTextBox.BackColor = Color.Red;

            }
            if (string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                confirmPasswordTextBox.BackColor = Color.Red;

            }
            else
            {
                string currentPassword = currentPasswordTextBox.Text;

                //Instantiate User Class
                User usr = new User();
                usr.userID = employee.UserID;
                usr.password = currentPassword;

                //Check current password or not
                bool isValid = User.CheckUser(usr);
                if (isValid)
                {
                    newPassword = newPasswordTextBox.Text;
                    confirmPassword = confirmPasswordTextBox.Text;
                    if (newPassword == confirmPassword)
                    {
                        //Validate Password 
                        Password password = new Password();
                        password.value = newPassword;

                        PasswordValidator validator = new PasswordValidator();
                        ValidationResult result = validator.Validate(password);

                        if (result.IsValid)
                        {
                            //Send verification code and store code in database
                            int code = Generator.GenerateVerificationCode();
                            bool isMailSendSucessfully = Email.SendVerificationCode(code, employee.Email);
                            bool isCodeStoredSucessfully = Employee.StoreVerificationCode(employee.Email, code);
                            if (isMailSendSucessfully && isCodeStoredSucessfully)
                            {
                                //Show confirmation code panel
                                verificationCodePanel.Visible = true;
                            }
                            else
                            {
                                DisplayAlert("Danger", "Internal Server Error.");
                            }

                        }
                        else
                        {
                            newPasswordTextBox.BorderColor = Color.Red;
                            confirmPasswordTextBox.BorderColor = Color.Red;
                        }

                    }
                    else
                    {
                        confirmPasswordTextBox.BorderColor = Color.Red;
                    }
                }
                else
                {
                    currentPasswordTextBox.BorderColor = Color.Red;
                    newPasswordTextBox.Text = "";
                    confirmPasswordTextBox.Text = "";
                }

            }
        }

        private void BtnVerify_Click(object sender, EventArgs e)
        {
            //Check all the text fields are filled or not
            if (string.IsNullOrEmpty(verificationCodeTextBox1.Text) || string.IsNullOrEmpty(verificationCodeTextBox2.Text) || string.IsNullOrEmpty(verificationCodeTextBox3.Text) || string.IsNullOrEmpty(verificationCodeTextBox4.Text))
            {
                verificationCodeTextBox1.BorderColor = Color.Red;
                verificationCodeTextBox2.BorderColor = Color.Red;
                verificationCodeTextBox3.BorderColor = Color.Red;
                verificationCodeTextBox4.BorderColor = Color.Red;

            }
            else
            {
                string verificationCode = $"{verificationCodeTextBox1.Text}{verificationCodeTextBox2.Text}{verificationCodeTextBox3.Text}{verificationCodeTextBox4.Text}";
                int code = Convert.ToInt32(verificationCode);
                //Check verification is valid or not
                bool isValid = Employee.IsValidVerificationCode(employee.Email, code);
                if (isValid)
                {
                    bool isPasswordChangedSucessfully = Employee.UpdatePassword(employee.Email, newPassword);
                    if (isPasswordChangedSucessfully)
                    {
                        DisplayAlert("Sucess", "Password changed sucessfully.");
                        //Instantiate settings form
                        Settings settings = new Settings(employee);
                        //Show settings form
                        settings.Show();
                        //Hide current form
                        this.Hide();
                    }
                    else
                    {
                        DisplayAlert("Danger", "Internal Server Error.");
                    }

                }
                else
                {
                    verificationCodeTextBox1.BorderColor = Color.Red;
                    verificationCodeTextBox2.BorderColor = Color.Red;
                    verificationCodeTextBox3.BorderColor = Color.Red;
                    verificationCodeTextBox4.BorderColor = Color.Red;

                }

            }
        }

        //Enter event on Verification Code Pannel 
        private void VerificationCodePanel_Enter(object sender, EventArgs e)
        {
            verificationCodeTextBox1.Focus();
        }

        private void VerificationCodeTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox4.Text.Length == 1)
            {
                btnVerify.Focus();
            }

        }

        private void VerificationCodeTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox3.Text.Length == 1)
            {
                verificationCodeTextBox4.Focus();
            }

        }

        private void VerificationCodeTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox2.Text.Length == 1)
            {
                verificationCodeTextBox3.Focus();
            }

        }

        private void VerificationCodeTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox1.Text.Length == 1)
            {
                verificationCodeTextBox2.Focus();
            }
        }

        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            alertTransition.HideSync(alertPanel);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //Instantiating Settings form
            var settings = new Settings(employee);
            settings.Show();
            this.Hide();
        }

        private void currentPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.Text.Length != 0 && currentPasswordTextBox.BorderColor == Color.Red)
            {
                currentPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void newPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text.Length != 0 && newPasswordTextBox.BorderColor == Color.Red)
            {
                newPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void confirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text.Length != 0 && confirmPasswordTextBox.BorderColor == Color.Red)
            {
                confirmPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        //Show alert
        private void DisplayAlert(string type, string message)
        {
            if (type == "Danger")
            {
                alertPanel.BackgroundImage = Properties.Resources.alert_danger_background;
                alertImage.Image = Properties.Resources.alert_danger_icon;
                alertText.ForeColor = Color.Red;

            }
            else if (type == "Sucess")
            {
                alertPanel.BackgroundImage = Properties.Resources.alert_sucess_background;
                alertImage.Image = Properties.Resources.alert_sucess_icon;
                alertText.ForeColor = Color.Green;
            }
            alertText.Text = message;
            alertTransition.ShowSync(alertPanel);
        }
    }
}
