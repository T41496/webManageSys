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
using webTRON_Management_Software.Views.Admin;
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Others
{
   
    public partial class Dashboard : Form
    {
        //Instantiate employee class
        Employee employee = new Employee();

        bool isStaffsDataVisible = true;
        DataTable dt;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        //Load event on Dashboard
        private void OtherDashboard_Load(object sender, EventArgs e)
        {
            //Load Grid View
            LoadGridView();

            FormatGridView();

            //Initialize activeUserDetails
            InitializeActiverUserDetails();
        }
        //Format Column
        private void FormatGridView()
        {
            //Change width height of columns,rows of grid view at run time
            gridView.Rows[0].Selected = false;
            gridView.Columns[0].Width = 150;
            gridView.Columns[1].Width = 150;
            gridView.Columns[3].Width = 150;
            gridView.Columns[4].Width = 100;
        }

        //Load data on grid data table
        private void LoadGridView()
        {
            //Instantiate data table
            dt = Employee.FetchStaffsDetails();
            gridView.DataSource = dt;
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

        //Sign Out
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
        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        //Click event on settings button
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings(employee);
            settings.Show();
            this.Hide();
        }
    
        private void BtnPatients_Click(object sender, EventArgs e)
        {
            if (isStaffsDataVisible)
            {
                textBox.Text = "";
                isStaffsDataVisible = false;
                btnPatients.FillColor = Color.FromArgb(49, 131, 228);
                btnStaffs.FillColor = Color.FromArgb(23, 107, 207);

                //Re-Instantiate data table
                dt = Patient.FetchPatientsDetails();
                gridView.DataSource = dt;

                FormatGridView();

            }
            
        }

        private void BtnStaffs_Click(object sender, EventArgs e)
        {
            if (!isStaffsDataVisible)
            {
                isStaffsDataVisible = true;
                textBox.Text = "";
                btnStaffs.FillColor = Color.FromArgb(49, 131, 228);
                btnPatients.FillColor = Color.FromArgb(23, 107, 207);

                //Re-Instantiate data table
                dt = Employee.FetchStaffsDetails();
                gridView.DataSource = dt;


                FormatGridView();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            string searchString = textBox.Text.Trim();
            if (isStaffsDataVisible)
            {
                dt = Employee.SearchStaffDetails(searchString);
            }
            else
            {
                dt = Patient.SearchPatientDetails(searchString);
            }
                gridView.DataSource = dt;
        }
    }
}
