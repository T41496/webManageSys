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
    public partial class TreatmentWindow : Form
    {
        int numberOfTextBoxes = 1;
        int numberOfOldPrescriptionPanel = 1;
        //to get patientID from 
        string patientID;

        //array of text boxes
        Guna2TextBox[] textBoxArray = new Guna2TextBox[5];
        string textBoxName;
        // textboxArray[0]=newTopic1TextField;

        //declare insertModerator
        InsertModerator IM;

        //prescription text Array
        Guna2TextBox[] prescriptionTextBoxArray = new Guna2TextBox[5];
        // prescriptionTextBoxArray[0]=newTopic1TextField;

        //array of old prescription panels
        Guna.UI2.WinForms.Guna2Panel[] arrayOfOldPrescriptionPanel = new Guna2Panel[5];

        //instanciate last textboxes name and value
        public static string txtBoxName { get; set; }
        public static string textBoxValue { get; set; }

        Patient patient = new Patient();
        Employee employee = new Employee();

        public TreatmentWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                textBoxArray[i] = new Guna2TextBox();
            }
        }
        public TreatmentWindow(Employee emp)
        {
            InitializeComponent();
            employee = emp;
        }
        public TreatmentWindow(Employee emp, Patient ptn)
        {
            InitializeComponent();
            employee = emp;
            patient = ptn;
        }
        //Display alert
        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            alertTransition.HideSync(alertPanel);
        }
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
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BtnAddTopic_Click(object sender, EventArgs e)
        {
            bool ans = IM.hasValue(TreatmentWindow.txtBoxName, numberOfTextBoxes);
            if (IM.hasValue(TreatmentWindow.txtBoxName,numberOfTextBoxes) && numberOfTextBoxes<=5)
            { 
            numberOfTextBoxes++;
            int yBtnPoint = 82 + 45 * (numberOfTextBoxes - 1);
            int yTextFieldPoint = 37 + 45 * (numberOfTextBoxes - 1);

            //to change the position of the Add Topic Button
            btnAddTopic.Location = new Point(4, yBtnPoint);

            //to create textfield on the history panel
            Guna2TextBox textBox = new Guna2TextBox();
            textBoxName = "history_textBox" + "_" + numberOfTextBoxes;
            textBox.Name = textBoxName;
            textBox.TextChanged += NewTopic1TextField_TextChanged;
            textBox.PlaceholderText = "New Topic";

            textBox.Location = new Point(4, yTextFieldPoint);

            textBox.Size = new Size(149, 33);

            this.prescriptionPanel.Controls.Add(textBox);

            textBox.Focus();
            if (numberOfTextBoxes == 5)
            {
                btnAddTopic.Enabled = false;
            }
         }

        }

        private void PrescriptionPanel_Paint(object sender, PaintEventArgs e)
        {


            lblTodaysDateOutput.Text = Generator.GetRegistrationDate();
        }



        private void PatientSerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            patientID = lblPtn.Text + "-" + yearComboBox.Text + "-" + patientSerialNumberTextBox.Text;
     

        }
        //when we type topic on topic textbox it changes to the text field also
        private void NewTopic1TextField_TextChanged(object sender, EventArgs e)
        {
            lblTodaysPrescriptionTitleOutput.Text = ": " + history_textbox_1.Text;
            TreatmentWindow.txtBoxName = ((Guna2TextBox)sender).Name;
            TreatmentWindow.textBoxValue = ((Guna2TextBox)sender).Text;
         //   IM.add(TreatmentWindow.txtBoxName,TreatmentWindow.textBoxValue);
        }

        int i = 0;
        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            //search patient data if exists
            DataTable dt = Patient.SearchPatientID(patientID);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblRegistrationDateOutput.Text = dr[1].ToString();

                    patient.registrationDate = dr[1].ToString();

                    lblFirstNameOutput.Text = dr[2].ToString();

                    patient.firstName = dr[2].ToString();

                    lblLastNameOutput.Text = dr[3].ToString();

                    patient.lastName = dr[3].ToString();

                    lblGenderOutput.Text = dr[4].ToString();

                    patient.gender = dr[4].ToString();

                    lblAgeOutput.Text = dr[5].ToString();

                    patient.age = Convert.ToInt32(dr[5]);

                    lblContactOutput.Text = dr[6].ToString();

                    patient.contactNumber = dr[6].ToString();

                    lblAddressOutput.Text = dr[7].ToString();

                    patient.address = dr[7].ToString();

                    lblReferredToOutput.Text = dr[9].ToString();

                    patient.referredTo = dr[9].ToString();
                    patient.patientID = patientID;
                }

                //get patient prescription history if and only if paient exists
                dt = Prescription.GetPatientPrescriptionHistory(patientID);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        int panelYCoordinate = 194 * numberOfOldPrescriptionPanel;
                        numberOfOldPrescriptionPanel++;


                        //create old prescription panel 
                        Guna2Panel pnl = new Guna2Panel();
                        arrayOfOldPrescriptionPanel[i] = pnl;
                        pnl.Location = new Point(0, panelYCoordinate);
                        pnl.Size = new Size(804, 194);
                        pnl.Name = "oldPrescriptionPanel" + numberOfOldPrescriptionPanel;
                        pnl.BringToFront();
                        pnl.Visible = true;

                        //create textboxes
                        Guna2TextBox tb = new Guna2TextBox();
                        tb.Name = "oldPrescriptionTextField" + numberOfOldPrescriptionPanel;
                        tb.Text = dr[3].ToString();
                        tb.Location = new Point(12, 20);
                        tb.Size = new Size(789, 153);
                        tb.Multiline = true;
                        tb.Visible = true;
                        tb.ReadOnly = true;
                        tb.FillColor = Color.WhiteSmoke;
                        tb.BorderColor = Color.WhiteSmoke;

                        Label lb1 = new Label();
                        lb1.Name = "lblprescriptionDateOutput" + numberOfOldPrescriptionPanel;
                        lb1.Text = dr[1].ToString();
                        lb1.Location = new Point(10, 2);
                        lb1.Visible = true;
                        lb1.Size = new Size(97, 15);

                        Label lb2 = new Label();
                        lb2.Name = "lblPrescriptionTitleOutput" + numberOfOldPrescriptionPanel;
                        lb2.Text = dr[2].ToString();
                        lb2.Location = new Point(119, 2);
                        lb2.Visible = true;
                        lb2.Size = new Size(97, 15);

                        /*
                            Label lb2 = new Label();
                            lb2.Name = "lblPrescriptionTitleOutput" + numberOfOldPrescriptionPanel;
                            lb2.Text = dr[2].ToString();
                            lb2.Location = new Point(119, 2);
                            lb2.Visible = true;
                            lb2.Size = new Size(119, 2);
                        */

                        Label lb3 = new Label();
                        lb3.Name = "lblPrescribedBy" + numberOfOldPrescriptionPanel;
                        lb3.Text = "Prescribed By:";
                        lb3.Location = new Point(556, 173);
                        lb3.Size = new Size(84, 15);


                        Label lb4 = new Label();
                        lb4.Name = "lblPrescribedDoctorNameOutput";
                        lb4.Text = dr[4].ToString();
                        lb4.Location = new Point(651, 173);
                        lb4.Size = new Size(135, 15);

                        //add to the panel
                        this.prescriptionDisplayPanel.Controls.Add(arrayOfOldPrescriptionPanel[i]);
                        this.arrayOfOldPrescriptionPanel[i].Controls.Add(tb);
                        this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb1);
                        this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb2);
                        this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb3);
                        this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb4);

                    }
                }
            }
            else
            {
                DisplayAlert("Danger", "Patient Not Found.");
            }


            
        }


        private void TreatmentWindow_Load(object sender, EventArgs e) 
        {
            //if we have information in patient object then we set values to the form 
            if (!String.IsNullOrEmpty(patient.patientID))
            {
                //initialize label text
                yearComboBox.Text = patient.patientID.Split('-')[1];
                patientSerialNumberTextBox.Text = patient.patientID.Split('-')[2];
                lblRegistrationDateOutput.Text = patient.registrationDate;
                lblAddressOutput.Text = patient.address;
                lblAgeOutput.Text = patient.age.ToString();
                lblGenderOutput.Text = patient.gender;
                lblFirstNameOutput.Text = patient.firstName;
                lblLastNameOutput.Text = patient.lastName;
                lblContactOutput.Text = patient.contactNumber;
                lblReferredToOutput.Text = patient.referredTo;

                DataTable dt = new DataTable();
                    //get patient prescription history 
                    dt = Prescription.GetPatientPrescriptionHistory(patientID);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            int panelYCoordinate = 194 * numberOfOldPrescriptionPanel;
                            numberOfOldPrescriptionPanel++;


                            //create old prescription panel 
                            Guna2Panel pnl = new Guna2Panel();
                            arrayOfOldPrescriptionPanel[i] = pnl;
                            pnl.Location = new Point(0, panelYCoordinate);
                            pnl.Size = new Size(804, 194);
                            pnl.Name = "oldPrescriptionPanel" + numberOfOldPrescriptionPanel;
                            pnl.BringToFront();
                            pnl.Visible = true;

                            //create textboxes
                            Guna2TextBox tb = new Guna2TextBox();
                            tb.Name = "oldPrescriptionTextField" + numberOfOldPrescriptionPanel;
                            tb.Text = dr[3].ToString();
                            tb.Location = new Point(12, 20);
                            tb.Size = new Size(789, 153);
                            tb.Multiline = true;
                            tb.Visible = true;
                            tb.ReadOnly = true;
                            tb.FillColor = Color.WhiteSmoke;
                            tb.BorderColor = Color.WhiteSmoke;

                            Label lb1 = new Label();
                            lb1.Name = "lblprescriptionDateOutput" + numberOfOldPrescriptionPanel;
                            lb1.Text = dr[1].ToString();
                            lb1.Location = new Point(10, 2);
                            lb1.Visible = true;
                            lb1.Size = new Size(97, 15);

                            Label lb2 = new Label();
                            lb2.Name = "lblPrescriptionTitleOutput" + numberOfOldPrescriptionPanel;
                            lb2.Text = dr[2].ToString();
                            lb2.Location = new Point(119, 2);
                            lb2.Visible = true;
                            lb2.Size = new Size(97, 15);

                            /*
                                Label lb2 = new Label();
                                lb2.Name = "lblPrescriptionTitleOutput" + numberOfOldPrescriptionPanel;
                                lb2.Text = dr[2].ToString();
                                MessageBox.Show(dr[2].ToString());
                                lb2.Location = new Point(119, 2);
                                lb2.Visible = true;
                                lb2.Size = new Size(119, 2);

                            */

                            Label lb3 = new Label();
                            lb3.Name = "lblPrescribedBy" + numberOfOldPrescriptionPanel;
                            lb3.Text = "Prescribed By:";
                            lb3.Location = new Point(556, 173);
                            lb3.Size = new Size(84, 15);


                            Label lb4 = new Label();
                            lb4.Name = "lblPrescribedDoctorNameOutput";
                            lb4.Text = dr[4].ToString();
                            lb4.Location = new Point(651, 173);
                            lb4.Size = new Size(135, 15);

                            //add to the panel
                            this.prescriptionDisplayPanel.Controls.Add(arrayOfOldPrescriptionPanel[i]);
                            this.arrayOfOldPrescriptionPanel[i].Controls.Add(tb);
                            this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb1);
                            this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb2);
                            this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb3);
                            this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb4);

                        }
                    }
                
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
         
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
         
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(history_textbox_1.Text) && !String.IsNullOrEmpty(newPrescriptionTextField.Text))
            {
                //store in database
                Prescription.patientID = patientID;
                Prescription.prescriptionDate = lblTodaysDateOutput.Text;
                Prescription.prescriptionTopic = history_textbox_1.Text;
                Prescription.prescriptionText = newPrescriptionTextField.Text;
                Prescription.prescribedBy =employee.UserID;
                if (Prescription.savePrescription())
                {
                    Medicine medicine = new Medicine(patient, employee);
                    medicine.Show();
                    this.Hide();
                }
                else
                {
                    
                }
            }
            else
            {
                Medicine medicine = new Medicine(patient, employee);
                medicine.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

     
    }
}
