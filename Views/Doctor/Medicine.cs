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
using webTRON_Management_Software.Utils;

namespace webTRON_Management_Software.Views.Doctor
{
    public partial class Medicine : Form
    {

        Patient patient = new Patient();
        Employee employee = new Employee();
        bool hasMedicineInfo1 = false;
        bool hasmedicineInfo2 = false;
        public Medicine()
        {
            InitializeComponent();
            startDatePicker1.Value = DateTime.Today;
            prescribedMedicineStartDate1.Value = DateTime.Today;
        }

        public Medicine(Patient ptn, Employee emp)
        {
            InitializeComponent();
            startDatePicker1.Value = DateTime.Today;
            prescribedMedicineStartDate1.Value = DateTime.Today;
            patient = ptn;
            employee = emp;
        }
        public Medicine(Employee emp)
        {
            InitializeComponent();
            startDatePicker1.Value = DateTime.Today;
            prescribedMedicineStartDate1.Value = DateTime.Today;
            employee = emp;

        }
        //Click event on add button of running medicine panel
        private void BtnAddRunningMedicine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(medicineNameTextBox1.Text) || string.IsNullOrEmpty(endDayTextBox1.Text))
            {
                DisplayAlert("Danger", "Fill required fields.");
            }
            else
            {
                Models.Medicine.Name=medicineNameTextBox1.Text;
                Models.Medicine.StartDate=DateTime.Parse(startDatePicker1.Text);
                Models.Medicine.EndDay=Convert.ToInt32(endDayTextBox1.Text);
                Models.Medicine.Remarks= remarksTextBox1.Text;
               if (Models.Medicine.Insert(patient.patientID,employee))
                {
                    DataTable dt1 = new DataTable();
                    dt1 = Models.Medicine.FetchRunningMedicines(patient.patientID);
                    runningMedicinesGridView.DataSource = dt1;
                    medicineNameTextBox1.Text = "";
                    endDayTextBox1.Text = "";
                    remarksTextBox1.Text = "";

                    //get previously taken medicine
                    DataTable dt = new DataTable();
                    dt = Models.Medicine.FetchPreviouslyTakenMedicines(patient.patientID);
                    previouslyTakenMedicineGridView.DataSource = dt;
                    DisplayAlert("Success", "Successfully inserted.");
                    hasMedicineInfo1 = false;

                }
            }

        }

        //CLick event on btnAddPrescribedMedicine
        private void BtnAddPrescribedMedicine_Click(object sender, EventArgs e)
        {
            
            //Validate input here
            if (string.IsNullOrEmpty(prescribedMedicineTextBox1.Text) || string.IsNullOrEmpty(prescribedMedicineEndDayTextBox1.Text))
            {
                DisplayAlert("Danger", "Fill required fields.");
            }
            else
            {
                Models.Medicine.Name = prescribedMedicineTextBox1.Text;
                Models.Medicine.StartDate = DateTime.Parse(prescribedMedicineStartDate1.Text);
                Models.Medicine.EndDay = Convert.ToInt32(prescribedMedicineEndDayTextBox1.Text);
                Models.Medicine.Remarks = prescribedMedicineRemarksTextBox1.Text;
                if (Models.Medicine.Insert(patient.patientID,employee))
                {
                    DataTable dt2 = new DataTable();
                    dt2 = Models.Medicine.FetchRunningMedicines(patient.patientID);
                    runningMedicinesGridView.DataSource = dt2;
                    prescribedMedicineTextBox1.Text = "";
                    prescribedMedicineEndDayTextBox1.Text = "";
                    prescribedMedicineRemarksTextBox1.Text = "";

                    //get previously taken medicine
                    DataTable dt3 = new DataTable();
                    dt3 = Models.Medicine.FetchPreviouslyTakenMedicines(patient.patientID);
                    previouslyTakenMedicineGridView.DataSource = dt3;
                    DisplayAlert("Success", "Successfully inserted.");
                    hasmedicineInfo2 = false;
                }
            }

        }
        //Click event on Next Button
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!hasMedicineInfo1 && !hasmedicineInfo2)
            {
                int row = Patient.UpdateStatus(patient.patientID, "OUT");
                if (row > 0)
                {
                    //move to dashboard
                    Dashboard dashboard = new Dashboard(employee);
                    dashboard.Show();
                    this.Hide();

                }
                else if (row == 0)
                {
                    DisplayAlert("Danger", "Provide Valid Patient Details.");
                }
                else if (row == -1)
                {
                    DisplayAlert("Danger", "Internal Server Error.");
                }


            }
            else
            {
                DisplayAlert("Alert", "Please save your data.");
            }
        }

        //Load event on medicine form
        private void MedicineForm_Load(object sender, EventArgs e)
        {
         

            if (!String.IsNullOrEmpty(patient.patientID))
            {
                //initialize label text
                lblRegistrationDateOutput.Text = patient.registrationDate;
                lblAddressOutput.Text = patient.address;
                lblAgeOutput.Text = patient.age.ToString();
                lblGenderOutput.Text = patient.gender;
                lblFirstNameOutput.Text = patient.firstName;
                lblLastNameOutput.Text = patient.lastName;
                lblContactOutput.Text = patient.contactNumber;
                lblReferredToOutput.Text = patient.referredTo;
                lblPatientIDOutput.Text = patient.patientID;

                //get running medicines
                DataTable dt = new DataTable();
                dt = Models.Medicine.FetchRunningMedicines(patient.patientID);
                runningMedicinesGridView.DataSource = dt;

                //get previously taken medicine
                dt = Models.Medicine.FetchPreviouslyTakenMedicines(patient.patientID);
                previouslyTakenMedicineGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Not allowed", "Error");
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
               
            }
            

        }

        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Initialize active patient details
       private void InitializeActiverPatientDetails()
        {
            lblPatientIDOutput.Text = "PTN-21-000000";
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
            else if (type == "Success")
            {
                alertPanel.BackgroundImage = Properties.Resources.alert_sucess_background;
                alertImage.Image = Properties.Resources.alert_sucess_icon;
                alertText.ForeColor = Color.Green;
            }
            alertText.Text = message;
            alertTransition.ShowSync(alertPanel);
        }

        //Click event on exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Load Grid View
        private void LoadGridView()
        {
            string patientID = lblPatientIDOutput.Text;
            DataTable dt = Models.Medicine.FetchPreviouslyTakenMedicines(patientID);
            previouslyTakenMedicineGridView.DataSource = dt;
            previouslyTakenMedicineGridView.ClearSelection();

            DataTable dataTable = Models.Medicine.FetchRunningMedicines(patientID);
            runningMedicinesGridView.DataSource =dataTable;
            runningMedicinesGridView.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TreatmentWindow treatmentWindow = new TreatmentWindow(employee,patient);
            treatmentWindow.Show();

        }

        private void endDayTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddPrescribedMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void medicineNameTextBox1_TextChanged(object sender, EventArgs e)
        {
            hasMedicineInfo1 = true;
        }

        private void endDayTextBox1_TextChanged(object sender, EventArgs e)
        {
            hasMedicineInfo1 = true;
        }

        private void remarksTextBox1_TextChanged(object sender, EventArgs e)
        {
            hasMedicineInfo1 = true;
        }

        private void prescribedMedicineTextBox1_TextChanged(object sender, EventArgs e)
        {
            hasmedicineInfo2 = true;
        }

        private void prescribedMedicineEndDayTextBox1_TextChanged(object sender, EventArgs e)
        {
            hasmedicineInfo2 = true;
        }

        private void prescribedMedicineRemarksTextBox1_TextChanged(object sender, EventArgs e)
        {
            hasmedicineInfo2 = true;
        }
    }
}
