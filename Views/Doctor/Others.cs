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
    public partial class Others : Form
    {
        Employee employee =new Employee();
        public Others()
        {
            InitializeComponent();
        }

        public Others(Employee emp)
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

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(employee); ;
            tests.Show();
            this.Hide();
        }
    }
}
