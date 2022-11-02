using Guna.UI2.WinForms;
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

namespace webTRON_Management_Software.Views.Doctor
{
    public partial class Tests : Form
    {
        Employee employee = new Employee();
        string patientID;
        //List of test
        List<Guna2CheckBox> testsList = new List<Guna2CheckBox>();
        //Prescribed Test Name's List
        List<string> prescribedTests = new List<string>();

        public Tests()
        {
            InitializeComponent();
        }
        public Tests(Employee emp)
        {
            InitializeComponent();
            employee = emp;
        }
        //Hide alert
        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            alertTransition.HideSync(alertPanel);
        }
        //Display alert
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

        //Click event on close button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Load event on tests form
        private void Tests_Load(object sender, EventArgs e)
        {
            //Initialize active patient details
            InitializeActiverPatientDetails();

            //Add all the checkboxes to the tests list
            AddTests();

            //Load grid view
            LoadGridView();
        }
        //Initialize active patient details
        private void InitializeActiverPatientDetails()
        {
            lblPatientIDValue.Text = "PTN-21-000000";
        }
        //Add all the checkboxes to the tests list
        private void AddTests()
        {
            testsList.Add(bloodTestCheckBox);
            testsList.Add(sugarTestCheckBox);
            testsList.Add(urineTestCheckBox);
            testsList.Add(stoolTestCheckBox);
            testsList.Add(ecgTestCheckBox);
            testsList.Add(ctScanCheckBox);
            testsList.Add(xrayCheckBox);
            testsList.Add(usgCheckBox);

        }

        //Click event on next button
        private void BtnNext_Click(object sender, EventArgs e)
        {
            Others others = new Others(employee);
            others.Show();
            this.Hide();
            /*
            bool isSucess;
            //Set patient ID
            patientID = lblPatientIDValue.Text;

            foreach(Guna2CheckBox obj in testsList)
            {
                if (obj.Checked)
                {
                    prescribedTests.Add(obj.Text);
                }
            }
            if (prescribedTests.Count > 0)
            {
                isSucess = Test.Insert(patientID, prescribedTests);
            }
            else
            {
                isSucess = true;
            }
            if (isSucess)
            {
                DisplayAlert("Sucess", "Tests stored sucessfully.");
            }
            else
            {
                DisplayAlert("Danger", "Error occured.");
            }
            */
            
        }
        //Load Grid View
        private void LoadGridView()
        {
            string patientID = lblPatientIDValue.Text;

            DataTable dt = Test.FetchResult(patientID);
            testsResultDataGridView.DataSource = dt;
            testsResultDataGridView.ClearSelection();

        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
        
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine(employee);
            medicine.Show();
            this.Hide();

        }
    }
}
