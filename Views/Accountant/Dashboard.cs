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

namespace webTRON_Management_Software.Views.Accountant
{
    public partial class Dashboard : Form
    {
        //Instantiate employee class
        Employee employee = new Employee();
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        //Method to sign out
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

        //Load Event on Dashboard
        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            //Initialize activeUserDetails
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
        //Click Event on Minimize Button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings(employee);
            settings.Show();
            this.Hide();
        }

       //CLick Event on Create Patient
        private void BtnCreatePatient_Click(object sender, EventArgs e)
        {
            //Instantiating create account form
            CreateNewPatient createNewPatient = new CreateNewPatient(employee);
            createNewPatient.Show();
            this.Hide();
        }

        //Click event on Renew Patient
        private void BtnRenewPatient_Click(object sender, EventArgs e)
        {
            RenewPatient renewPatient = new RenewPatient(employee);
            renewPatient.Show();
            this.Hide();

        }

        private void BtnSearchPatient_Click(object sender, EventArgs e)
        {
            SearchAndUpdatePatient searchAndUpdatePatient = new SearchAndUpdatePatient(employee);
            searchAndUpdatePatient.Show();
            this.Hide();
        }

       
    }
}
