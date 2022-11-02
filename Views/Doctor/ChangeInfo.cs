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
    public partial class ChangeInfo : Form
    {
        //Instantiate Employee
        Employee employee = new Employee();
        public ChangeInfo()
        {
            InitializeComponent();
        }
        public ChangeInfo(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        //Click Event on Update Button
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTxtBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(contactNumberTextBox.Text) || (!isMale.Checked && !isFemale.Checked && !isOthers.Checked))
            {
                DisplayAlert("Danger", "Fill all the fields.");
            }
            else
            {
                //Instantiate employee class
                Employee obj = new Employee();
                obj.UserID = employee.UserID;
                obj.FirstName = firstNameTxtBox.Text.Trim();
                obj.LastName = lastNameTextBox.Text.Trim();
                obj.Email = emailTextBox.Text;
                obj.Address = addressTextBox.Text;
                obj.ContactNumber = contactNumberTextBox.Text;
                obj.DateOfBirth = dateOfBirthPicker.Value.ToString("yyyy-MM-dd");
                //Fetch Sex
                if (isMale.Checked)
                {
                    obj.Gender = isMale.Text;
                }
                else if (isFemale.Checked)
                {
                    obj.Gender = isFemale.Text;
                }
                else if (isOthers.Checked)
                {
                    obj.Gender = isOthers.Text;
                }
                //Update information
                bool isInformationUpdatedSucessfully = Employee.Update(obj);
                if (isInformationUpdatedSucessfully)
                {
                    DisplayAlert("Sucess", "Information updated sucessfully.");
                    //Upadte new information instantly
                    UpdateInformation();
                    //Clear Fields
                    ClearFields();

                }
                else
                {
                    DisplayAlert("Danger", "Error occured.");
                }
            }

        }
        //Click Event on Dashboard 
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //Instantiate dashboard form
            var dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Close();
        }

        //Click event on Settings
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //Instantiate settings form
            var settings = new Settings(employee);
            settings.Show();
            this.Close();
        }

        //Click event on Signout
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

        //Click Event on Minimize Button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Load event on form
        private void ChangeInfo_Load(object sender, EventArgs e)
        {
            //Initialize active user details
            InitializeActiverUserDetails();
        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            DateTime dateOfBirth = DateTime.Parse(employee.DateOfBirth);
            activeUserName.Text = employee.FirstName;
            userIdValue.Text = employee.UserID;
            roleValue.Text = employee.Role;
            firstNameTxtBox.Text = employee.FirstName;
            lastNameTextBox.Text = employee.LastName;
            emailTextBox.Text = employee.Email;
            addressTextBox.Text = employee.Address;
            dateOfBirthPicker.Value = dateOfBirth;
            contactNumberTextBox.Text = employee.ContactNumber;
            if (employee.Gender == "Male")
            {
                isMale.Checked = true;
            }
            else if (employee.Gender == "Female")
            {
                isFemale.Checked = true;

            }
            else
            {
                isOthers.Checked = true;
            }
            if (employee.img != null)
            {
                //Change active user picture
                MemoryStream ms = new MemoryStream(employee.img);
                activeUserPicture.Image = Image.FromStream(ms);
            }
        }
        //Update information instantly
        private void UpdateInformation()
        {
            string userID = employee.UserID;
            employee = Employee.GetActiveUserDetails(userID);
            activeUserName.Text = employee.FirstName;
        }

        //Clear form fields
        private void ClearFields()
        {
            firstNameTxtBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            dateOfBirthPicker.Value = new DateTime(2000, 1, 1);
            contactNumberTextBox.Text = "";
            isMale.Checked = false;
            isFemale.Checked = false;
            isOthers.Checked = false;
        }

        //Hide Alert
        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            alertTransition.HideSync(alertPanel);
        }
        //Show alert
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

        //Click event on patients
        private void BtnPatients_Click(object sender, EventArgs e)
        {
            var patients = new Patients(employee);
            patients.Show();
            this.Hide();
        }

        private void contactNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
