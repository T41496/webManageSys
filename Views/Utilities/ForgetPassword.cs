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
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Utilities
{
    public partial class ForgetPassword : Form
    {
       
        //Entered email
        string enteredEmail;

        public ForgetPassword()
        {
            InitializeComponent();
        }
      

        //Click event on close button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click event on send verification code
        private void BtnSendVerificationCode_Click(object sender, EventArgs e)
        {
            //Check if textbox is empty or null
            if(string.IsNullOrEmpty(recoveryEmailTextBox.Text))
            {
                recoveryEmailTextBox.BorderColor = Color.Red;

            }
            else
            {
                enteredEmail = recoveryEmailTextBox.Text;

                //Validate Email
                UserEmail email = new UserEmail();
                email.value = enteredEmail;

                EmailValidator emailValidator = new EmailValidator();

                ValidationResult result = emailValidator.Validate(email);
                var resultString = result.ToString("-");
                var message = resultString.Split('-');
                
                if (result.IsValid)
                {
                    //Check email is exist in database or not
                    if (Employee.IsEmailExist(enteredEmail))
                    {
                        //Send Verification code and store this in database
                        int generatedVerificationCode = Generator.GenerateVerificationCode();
                        bool isMailSendSucessfully = Email.SendVerificationCode(enteredEmail, generatedVerificationCode);
                        if (isMailSendSucessfully)
                        {
                            bool isCodeStoredSucessfully = Employee.StoreVerificationCode(enteredEmail, generatedVerificationCode);
                            if (isCodeStoredSucessfully)
                            {
                                //Show enterVerificationCodePanel
                                verificationPanelTransition.ShowSync(enterVerificationCodePanel);
                            }
                            else
                            {
                                MessageBox.Show("Internal Server Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Internal Server Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        recoveryEmailTextBox.BorderColor = Color.Red;

                    }

                }
                else
                {
                    recoveryEmailTextBox.BorderColor = Color.Red;
                }

            }
    
        }
        //Click event on verify button click
        private void BtnVerify_Click(object sender, EventArgs e)
        {
            //Check all the text fields are filled or not
            if(string.IsNullOrEmpty(verificationCodeTextBox1.Text) || string.IsNullOrEmpty(verificationCodeTextBox2.Text)|| string.IsNullOrEmpty(verificationCodeTextBox3.Text) || string.IsNullOrEmpty(verificationCodeTextBox4.Text))
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
                bool isValid = Employee.IsValidVerificationCode(enteredEmail, code);
                if (isValid)
                {
                    resetPasswordPanelTransition.ShowSync(resetPasswordPanel);
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
        //TextChange event on different verificationCodeTextBox 
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
        //Click event on password reset button
        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newPasswordTextBox.Text) || string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                newPasswordTextBox.BorderColor = Color.Red;
                confirmPasswordTextBox.BorderColor = Color.Red;
            }
            else if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                confirmPasswordTextBox.BorderColor = Color.Red;

            }
            else
            {
                //Validate Password Strength
                Password password = new Password();
                password.value = newPasswordTextBox.Text;

                PasswordValidator passwordValidator = new PasswordValidator();

                ValidationResult result = passwordValidator.Validate(password);

                if (result.IsValid)
                {
                    string newPassword = newPasswordTextBox.Text;
                    //Store new password in database
                    bool isChanged = Employee.UpdatePassword(enteredEmail, newPassword);
                    if (isChanged)
                    {
                        MessageBox.Show("Password has changed sucessfully.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Then hide ForgetPassword form and show Landing window again
                        this.Hide();
                        LandingWindow landingWindow = new LandingWindow();
                        landingWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Internal Server Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    newPasswordTextBox.BorderColor = Color.Red;
                    confirmPasswordTextBox.BorderColor = Color.Red;

                }

               
            }

        }

        private void newPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if(newPasswordTextBox.Text.Length!=0 && newPasswordTextBox.BorderColor == Color.Red)
            {
                newPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void confirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text.Length != 0 && newPasswordTextBox.BorderColor == Color.Red)
            {
                confirmPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }

        }
    }
}
