using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accountant=webTRON_Management_Software.Views.Accountant;
using Doctor=webTRON_Management_Software.Views.Doctor;
using Admin=webTRON_Management_Software.Views.Admin;
using webTRON_Management_Software.Views.Landing_Window;
using Others=webTRON_Management_Software.Views.Others;
using LabAssistant = webTRON_Management_Software.Views.Lab_Assistant;
using webTRON_Management_Software.Views.Utilities;

namespace webTRON_Management_Software
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //Run main window here
            // Application.Run(new LandingWindow());

              Application.Run(new LandingWindow());

            //Application.Run(new Doctor.Medicine());
            //Application.Run(new Admin.CreateAccount());
            //Application.Run(new Doctor.TreatmentWindow());   

        }
    }
}
