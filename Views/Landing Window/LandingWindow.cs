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
using Accountant=webTRON_Management_Software.Views.Accountant;
using Admin=webTRON_Management_Software.Views.Admin;
using Doctor=webTRON_Management_Software.Views.Doctor;
using Others=webTRON_Management_Software.Views.Others;
using Utilities=webTRON_Management_Software.Views.Utilities;

namespace webTRON_Management_Software.Views.Landing_Window
{
    public partial class LandingWindow : Form
    {

        //Instantiating User Class
        User newUser = new User();
        //Instantiating Employee Class
        Employee activeUser;
        public LandingWindow()
        {
            InitializeComponent();
        }

        //Login Button Click Event
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
              //Validating user input
            if (string.IsNullOrEmpty(userIDTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                userIDTextBox.BorderColor = Color.Red;
                passwordTextBox.BorderColor = Color.Red;

            }
            else
            {
                //Instantiate object properties
                newUser.userID = userIDTextBox.Text;
                newUser.password = passwordTextBox.Text;
                //Check valid user or nont
                bool isSucess = User.CheckUser(newUser);
                if (isSucess)
                {
                    //Get User Details
                    activeUser = Employee.GetActiveUserDetails(newUser.userID);
                   

                    //Set Logged in user status Online
                    Employee.SetStatus(newUser.userID, "Online");

                    //check wheather the user login is first time or not into the system
                    bool isFirstTime = User.IsFirstTimeLogin(newUser.userID);
                    if (isFirstTime)
                    {
                        this.Hide();
                        //Instantiate change password form
                        Utilities.ChangePassword changePassword = new Utilities.ChangePassword(activeUser);
                        changePassword.ShowDialog();
                        //Than store loginInfo in database
                        User.StoreLogInInfo(newUser.userID);

                    }
                    else
                    {
                        User.UpdateLogInInfo(newUser.userID);

                    }
                    //Authorize User
                    AuthorizeUser();

                }
                else
                {
                    //Validation response
                    userIDTextBox.BorderColor = Color.Red;
                    passwordTextBox.BorderColor = Color.Red;
                }
            }

        }
        //Minimize button click event
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button click event
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Method to authorize user
        private void AuthorizeUser()
        {
            //Get User Role
            string userRole = User.GetUserRole(newUser.userID);
            switch (userRole)
            {
                case "Admin":
                    this.Hide();
                    var adminDashBoard = new Admin.Dashboard(activeUser);
                    adminDashBoard.Show();
                    break;
                case "Doctor":
                    this.Hide();
                    var doctorDashboard = new Doctor.Dashboard(activeUser);
                    doctorDashboard.Show();
                    break;
                case "Accountant":
                    this.Hide();
                    var accountDashboard = new Accountant.Dashboard(activeUser);
                    accountDashboard.Show();
                    break;
                case "Others":
                    this.Hide();
                    var otherDashboard = new Others.Dashboard(activeUser);
                    otherDashboard.Show();
                   break;

            }

        }
        //Method to handle click event
        private void LblForgetPassword_Click(object sender, EventArgs e)
        {
            //Instantiating forget password form
            this.Hide();
            var forgetPassword = new Utilities.ForgetPassword();
            forgetPassword.Show();
        }


        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length!=0 && passwordTextBox.BorderColor == Color.Red)
            {
                passwordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }

        }

        private void userIDTextBox_Leave(object sender, EventArgs e)
        {
            if (userIDTextBox.Text.Length !=0 && userIDTextBox.BorderColor == Color.Red)
            {
                userIDTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void UserIDTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            this.ActiveControl = null;
            BtnLogIn_Click(null,null);

        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            this.ActiveControl = null;
            BtnLogIn_Click(null, null);
        }
    }
}
