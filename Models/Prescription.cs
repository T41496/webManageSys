using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace webTRON_Management_Software.Models
{
    class Prescription
    {
        static public string patientID { get; set; }
        static public string prescriptionDate { get; set; }
        static public string prescriptionTopic { get; set; }
        static public string prescriptionText { get; set; }
        static public string prescribedBy { get; set; }


        //connection string
        private static string connectionString = "server=localhost;user id=root; password=laxudb;persistsecurityinfo=True;database=webtronmanagement";
        //private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
        //instance variables of the class Patient
        static MySqlConnection con = new MySqlConnection(connectionString);
        public static DataTable GetPatientPrescriptionHistory(string ID)
        {
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM prescription WHERE patientId LIKE '%"+ID+"%' ORDER BY prescribedDate DESC",con);
            if (ad == null)
            {
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            //*Note* if we returned object by initializing instances of the object one by one then it becomes a bit 
            //tidious and memory consuming
        }
        public static bool savePrescription()
        {
            MySqlCommand command= new MySqlCommand();
            command.Connection = con;
            command.CommandText = "INSERT INTO prescription VALUES(@prmPatiendID,@prmPrescribedDate,@prmPrescriptionTopic,@prmPrescriptionText,@prmPrescribedBy)";
            command.Parameters.AddWithValue("prmPatiendID", patientID);
            command.Parameters.AddWithValue("prmPrescribedDate", DateTime.Parse(prescriptionDate));
            command.Parameters.AddWithValue("prmPrescriptionTopic", prescriptionTopic);
            command.Parameters.AddWithValue("prmPrescriptionText", prescriptionText);
            command.Parameters.AddWithValue("prmPrescribedBy", prescribedBy);
            try
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        
    }
}
