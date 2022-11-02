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
    public partial class RenewPatient : Form
    {
        Employee employee = new Employee();
        public RenewPatient()
        {
            InitializeComponent();
        }
        public RenewPatient(Employee emp)
        {
            employee = emp;
            InitializeComponent();

        }

        
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void DisplayDataInDataGridView()
        {
            DataGridView.Rows.Clear();
            DataTable dt = Patient.GetTableData();
            foreach (DataRow item in dt.Rows) // from DataTable dt we have to read and Insert them in Gridview. DataRow is the datatype. item is name given to them which are rows of dt;
            {
                int n = DataGridView.Rows.Add(); // adds a row in the DataGridView and returns the index of the added row;
                DataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                DataGridView.Rows[n].Cells[1].Value = item[1].ToString();
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

        private void RenewPatient_Load(object sender, EventArgs e)
        {
            DataGridView.RowCount = 2;
                DateTime dateTime = DateTime.Now;
            int year = (dateTime.Year) % 100;
            int[] yearArray = new int[10];
            for (var i = 0; i < 10; i++)
                yearArray[i] = year - i;
            for (var i = 0; i < 10; i++)
                yearComboBox.Items.Add(yearArray[i]);
            yearComboBox.StartIndex = 0;

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

        private void PatientSerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string idToSearch = roleTextBox.Text+"-"+yearComboBox.Text+"-"+patientSerialNumberTextBox.Text;
            Patient patient = new Patient();
            patient.patientID = idToSearch;
;

            DataTable dt = Patient.SeachAndGetTopRowFromTable(patient);  // inserts the data table returned from MySqlDataAdapter sda to the DataTable dt;
            DataGridView.Rows.Clear(); // clear the values in the gridview;
            foreach (DataRow item in dt.Rows) // from DataTable dt we have to read and Insert them in Gridview. DataRow is the datatype. item is name given to them which are rows of dt;
            {
                int n = DataGridView.Rows.Add(); // adds a row in the DataGridView and returns the index of the added row;
                DataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                DataGridView.Rows[n].Cells[1].Value = item[1].ToString();
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

        private void BtnRenew_Click(object sender, EventArgs e)
        {
            try
            {
                string patientID = DataGridView.Rows[0].Cells[0].Value.ToString();
                int row = Patient.UpdateStatus(patientID,"IN");
                if (row > 0)
                {
                    DisplayAlert("Sucess", "Successfully Renewed.");
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
           
            catch (Exception)
            {
                DisplayAlert("Danger", "Provide Valid Patient Details.");
            }
           
           
        }
        //Method to signout
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
    }
}
