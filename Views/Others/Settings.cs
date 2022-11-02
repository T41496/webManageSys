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

namespace webTRON_Management_Software.Views.Others
{
    public partial class Settings : Form
    {
        //Instantiate employee class
        Employee employee = new Employee();
        //Instantiate memorystream
        MemoryStream ms;
        public Settings()
        {
            InitializeComponent();
        }
        public Settings(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        //Sign out
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
        //Click event on dashboard button
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //Instantiate dashboard form
            var dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Close();

        }

        //Load event on settings form
        private void Settings_Load(object sender, EventArgs e)
        {
            //Initialize active user details
            InitializeActiverUserDetails();

        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            activeUserName.Text = employee.FirstName;
            lblUserIdValue.Text = employee.UserID;
            lblFullNameValue.Text = $"{employee.FirstName} {employee.LastName}";
            lblEmailValue.Text = employee.Email;
            lblContactNumberValue.Text = employee.ContactNumber;

            if (employee.img != null)
            {
                //Change active user picture
                MemoryStream ms = new MemoryStream(employee.img);
                activeUserPicture.Image = Image.FromStream(ms);
                userPicture.Image = Image.FromStream(ms);
            }

        }
        //Click event on changeinfo
        private void BtnChangeInfo_Click(object sender, EventArgs e)
        {
            //Instantiate change info form
            var changeInfo = new ChangeInfo(employee);
            changeInfo.Show();
            this.Close();
        }

        //Click event on change password
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            //Instantiate change password form
            var changePassword = new ChangePassword(employee);
            changePassword.Show();
            this.Close();
        }

        //CLick event on change picture button
        private void BtnChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Choose Image(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            if (opn.ShowDialog() == DialogResult.OK)
            {
                userPicture.Image = Image.FromFile(opn.FileName);
                //To change image in array of bytes
                MemoryStream ms = new MemoryStream();
                userPicture.Image.Save(ms, userPicture.Image.RawFormat);
                byte[] img = ms.ToArray();
                //Maximum
                if (img.Length > 16777215)
                {
                    DisplayAlert("Danger", "Image size exceeded 16MB.");
                }
                else
                {

                    //Store image in database
                    Employee.InsertImage(employee.UserID, img);

                    //Update information instantly
                    UpdateInformation();
                }


            }

        }
        //Update information instantly
        private void UpdateInformation()
        {
            string userID = employee.UserID;
            employee = Employee.GetActiveUserDetails(userID);
            //Change active user picture
             ms = new MemoryStream(employee.img);
            activeUserPicture.Image = Image.FromStream(ms);
           

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

        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
