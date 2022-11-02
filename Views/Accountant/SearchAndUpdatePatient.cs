using MySql.Data.MySqlClient;
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
    public partial class SearchAndUpdatePatient : Form
    {

        Employee employee = new Employee();
        Patient ObjUpdate = new Patient();
        public SearchAndUpdatePatient()
        {
            InitializeComponent();
        }
        public SearchAndUpdatePatient(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //clear all fields
            Clear();
        }


        private void BtnMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(ageTextBox.Text) || string.IsNullOrEmpty(contactNumberTextBox.Text))
            {
                DisplayAlert("Danger", "Fill all the fields.");
            }
            else
            {
                ObjUpdate.patientID = lblPatientIDValue.Text;
                ObjUpdate.registrationDate = lblRegistrationDateValue.Text;
                ObjUpdate.firstName = firstNameTextBox.Text;
                ObjUpdate.lastName = lastNameTextBox.Text;
                ObjUpdate.address = addressTextBox.Text;
                ObjUpdate.referredTo = lblReferredToValue.Text;
                ObjUpdate.age = Convert.ToInt32(ageTextBox.Text);
                ObjUpdate.contactNumber = contactNumberTextBox.Text;
                ObjUpdate.status = lblStatusValue.Text;
                ObjUpdate.gender = lblGenderValue.Text;
                bool isSuccess = Patient.Update(ObjUpdate);
                if (isSuccess)
                {
                    DisplayAlert("Sucess", "Informatation has updated");

                    //clear all fields
                    Clear();
                    DisplayDataInDataGridView();
                    
                }
                else
                {
                    DisplayAlert("Danger", "Internal server error.");
                }
            }
        }
        private void DisplayDataInDataGridView()
        {
            DataGridView.Rows.Clear();
            DataTable dt = Patient.GetTableData();
            // from DataTable dt we have to read and Insert them in Gridview. DataRow is the datatype. item is name given to them which are rows of dt;
            foreach (DataRow item in dt.Rows) 
            {
                var date = DateTime.Parse(item[1].ToString());
                // adds a row in the DataGridView and returns the index of the added row;
                int n = DataGridView.Rows.Add();
                DataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                DataGridView.Rows[n].Cells[1].Value = date.ToString("dd/MM/yyyy");
                DataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                DataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                DataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                DataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                DataGridView.Rows[n].Cells[6].Value = item[6].ToString();
                DataGridView.Rows[n].Cells[7].Value = item[7].ToString();
                DataGridView.Rows[n].Cells[8].Value = item[8].ToString();
                DataGridView.Rows[n].Cells[9].Value = item[9].ToString();
            }
        }
        //Method to clear all fields
        private void Clear()
        {

            //clear all fields
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            addressTextBox.Text = "";
            lblGenderValue.Text = "-----------";
            ageTextBox.Text = "";
            contactNumberTextBox.Text = "";
            lblReferredToValue.Text = "----------";
            lblRegistrationDateValue.Text = "------------";
            lblPatientIDValue.Text = "------------";
            firstNameTextBox.Focus();
        }

        private void SearchAndUpdatePatient_Load(object sender, EventArgs e)
        {
            DisplayDataInDataGridView();

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

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPatientIDValue.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            lblRegistrationDateValue.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
            firstNameTextBox.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
            lastNameTextBox.Text = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
            lblGenderValue.Text = DataGridView.SelectedRows[0].Cells[4].Value.ToString();
            ageTextBox.Text = DataGridView.SelectedRows[0].Cells[5].Value.ToString();
            contactNumberTextBox.Text = DataGridView.SelectedRows[0].Cells[6].Value.ToString();
            addressTextBox.Text = DataGridView.SelectedRows[0].Cells[7].Value.ToString();
            lblStatusValue.Text = DataGridView.SelectedRows[0].Cells[8].Value.ToString();
            lblReferredToValue.Text = DataGridView.SelectedRows[0].Cells[9].Value.ToString();
          
            
            
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
           
            // inserts the data table returned from MySqlDataAdapter sda to the DataTable dt;
            DataTable dt = Patient.Search(searchTextBox.Text);
            // clear the values in the gridview;
            DataGridView.Rows.Clear();
            // from DataTable dt we have to read and Insert them in Gridview. DataRow is the datatype. item is name given to them which are rows of dt;
            foreach (DataRow item in dt.Rows) 
            {
                var date=DateTime.Parse(item[1].ToString());  
                // adds a row in the DataGridView and returns the index of the added row;
                int n = DataGridView.Rows.Add(); 
                DataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                DataGridView.Rows[n].Cells[1].Value = date.ToString("dd/MM/yyyy");
                DataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                DataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                DataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                DataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                DataGridView.Rows[n].Cells[6].Value = item[6].ToString();
                DataGridView.Rows[n].Cells[7].Value = item[7].ToString();
                DataGridView.Rows[n].Cells[8].Value = item[8].ToString();
                DataGridView.Rows[n].Cells[9].Value = item[9].ToString();
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Hide();
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
    } }
