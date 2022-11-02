using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Utils;
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Accountant
{
    public partial class CreateNewPatient : Form
    {
        Employee employee = new Employee();
        public CreateNewPatient()
        {
            InitializeComponent();
        }
        public CreateNewPatient(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        private void CreatePatient_Load(object sender, EventArgs e)
        {
            string regNumber = Generator.GeneratePatientId();
            string regDate = Generator.GetRegistrationDate();
            lblRegistrationIdOutput.Text = regNumber;
            lblRegistrationDateOutput.Text = regDate;

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



        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

 

        private void BtnCreateNewPatient_Click(object sender, EventArgs e)
        {

            // check if all the fields are Filled or not.
            if (string.IsNullOrEmpty(firstNameTxtBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(ageTextBox.Text) || string.IsNullOrEmpty(contactNumberTextBox.Text) || (isMale.Checked == false & isFemale.Checked == false & isOthers.Checked == false))
            {
                DisplayAlert("Danger", "Fill all the fields.");
            }
            else
            {
                Patient ptn = new Patient();
                ptn.patientID = lblRegistrationIdOutput.Text;
                ptn.registrationDate = lblRegistrationDateOutput.Text;
                ptn.firstName = firstNameTxtBox.Text;
                ptn.lastName = lastNameTextBox.Text;
                ptn.address = addressTextBox.Text;
                ptn.referredTo = referredToComboBox.Text;
                ptn.age=Convert.ToInt32(ageTextBox.Text);
                ptn.contactNumber = contactNumberTextBox.Text;
                ptn.status = "IN";
              
                if (isMale.Checked)
                    ptn.gender = isMale.Text;
                    
                
                else if (isFemale.Checked)
                    ptn.gender = isFemale.Text;
                    
                else if (isOthers.Checked)
                    ptn.gender = isOthers.Text;

                
                    

                bool isSuccess = Patient.Insert(ptn);
                if (isSuccess)
                {
                    PrintPanelContanerPanel.Visible = true;
                    //TO DISPLAY THE NEXT REGISTRATION ID AFTER INSERTING THE INFO OF ONE PATIENT...
                    string regNumber = Generator.GeneratePatientId();
                    string regDate = Generator.GetRegistrationDate();
                    lblRegistrationIdOutput.Text = regNumber;
                    lblRegistrationDateOutput.Text = regDate;
                }
                else
                {
                    DisplayAlert("Danger", "Internal Server Error");
                }


            }



        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //to print the Ticket
            Printer printer = new Printer(printPanel.Width,printPanel.Height,printPanel);
            printer.Print(printPanel);
            PrintPanelContanerPanel.Visible = false;
            //clear all fields
            ClearFields();
        }


        private void PrintPanel_Paint(object sender, PaintEventArgs e)
        {
            LblPanelRegistrationIdOutput.Text = lblRegistrationIdOutput.Text;
            LblPanelRegistrationDateOutput.Text = lblRegistrationDateOutput.Text;
            LblPanelFNameOutput.Text = firstNameTxtBox.Text;
            LblPanelLNameOutput.Text = lastNameTextBox.Text;
            LblPanelAgeOutput.Text = ageTextBox.Text;
          
            if (isMale.Checked)
                LblPanelSexOutput.Text = "M";
            else if (isFemale.Checked)
                LblPanelSexOutput.Text = "F";
            else if (isOthers.Checked)
                LblPanelSexOutput.Text = "O";
            
            LblPanelAddressOutput.Text = addressTextBox.Text;
            LblPanelReferredToOutput.Text = referredToComboBox.Text;

            //to create QR CODE...
            QRCoder.QRCode qr = QRCodeGenerator.generateQRCode(lblRegistrationIdOutput.Text);
            QRCodePictureBox.Image = qr.GetGraphic(50);
        }
        private void ClearFields()
        {
            firstNameTxtBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            addressTextBox.Text = "";
            isFemale.Checked = false;
            isMale.Checked = false;
            isOthers.Checked = false;
            ageTextBox.Text = "";
            contactNumberTextBox.Text = "";
            referredToComboBox.SelectedIndex = -1;
            firstNameTxtBox.Focus();
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

        //CLick event on Back Button
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
    }
}
