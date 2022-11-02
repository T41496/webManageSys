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

namespace webTRON_Management_Software.Views.Doctor
{
    public partial class Patients : Form
    {
        Employee employee = new Employee();
        public Patients()
        {
            InitializeComponent();
        }
        public Patients(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Hide();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings(employee);
            settings.Show();
            this.Hide();
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

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Patients_Load(object sender, EventArgs e)
        {
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
    }
}
