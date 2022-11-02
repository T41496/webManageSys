using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Utils;
using webTRON_Management_Software.Utils.Validators;

namespace webTRON_Management_Software.Views.Utilities
{
    public partial class ChangePassword : Form
    {
        //Instantiate user class
        Employee employee = new Employee();

        string newPassword = "",confirmPassword="";

        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(Employee obj)
        {
            employee = obj;
            InitializeComponent();
        }

        //Click event on exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Click event on verify button
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
                        MessageBox.Show("Password changed sucessfully.", "Sucesss", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Hide current form
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Internal Server Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        //Text change event on verification code
        private void VerificationCodeTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox1.Text.Length == 1)
            {
                verificationCodeTextBox2.Focus();
            }

        }

        private void VerificationCodeTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox2.Text.Length == 1)
            {
                verificationCodeTextBox3.Focus();
            }

        }
        private void VerificationCodeTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox3.Text.Length == 1)
            {
                verificationCodeTextBox4.Focus();
            }
        }


        private void VerificationCodeTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox4.Text.Length == 1)
            {
                btnVerify.Focus();
            }

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



        //Click event on change password
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
                                MessageBox.Show("Internal Server Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
