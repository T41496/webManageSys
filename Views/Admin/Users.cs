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
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Admin
{
    public partial class Users : Form
    {
        //Instantiate Employee Class
        Employee employee = new Employee();
        public Users()
        {
            InitializeComponent();
        }
        public Users(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }
       
        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click event on new account button
        private void BtnAddNewAccount_Click(object sender, EventArgs e)
        {
            //Instantiating create account form
            CreateAccount createAccount = new CreateAccount(employee);
            createAccount.Show();
            this.Hide();
        }
        //Click event on settings button

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //Instantiating Settings form
            var setting = new Settings(employee);
            setting.Show();
            this.Hide();
        }
        //Click event on Dashboard icon
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Admin.Dashboard(employee);
            dashboard.Show();
            this.Hide();


        }
        //Load event on users form
        private void Users_Load(object sender, EventArgs e)
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
        //Click event on signout and exit button
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
        //Click event on Search user button
        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            var search = new Search(employee);
            search.Show();
            this.Hide();
        }
    }
}
