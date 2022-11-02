using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace webTRON_Management_Software.Models
{
    public class Patient
    {
        //connection string
        //private static string connectionString = "server=localhost;user id=root; password=password;persistsecurityinfo=True;database=webtronmanagement";
        private static string connectionString = "server=localhost;user id=root;pwd=laxudb;database=webtronmanagement";
        //instance variables of the class Patient
        public string patientID { get; set; }
        public string registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string referredTo { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string contactNumber { get; set; }
        public string status { get; set; }


        // method to insert the datas to the database 
        public static bool Insert(Patient ptn)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
          
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO patientInfo VALUES(@prmPatientID,@prmRegistrationDate,@prmFirstName,@prmLastName,@prmGender,@prmAge,@prmContactNumber,@prmAddress,@prmStatus,@prmReferredTo)";
            command.Parameters.AddWithValue("prmPatientID", ptn.patientID);
            command.Parameters.AddWithValue("prmRegistrationDate", ptn.registrationDate);
            command.Parameters.AddWithValue("prmFirstName", ptn.firstName);
            command.Parameters.AddWithValue("prmLastName", ptn.lastName);
            command.Parameters.AddWithValue("prmContactNumber", ptn.contactNumber);
            command.Parameters.AddWithValue("prmGender", ptn.gender);
            command.Parameters.AddWithValue("prmReferredTo", ptn.referredTo);
            command.Parameters.AddWithValue("prmStatus", ptn.status);
            command.Parameters.AddWithValue("prmAge", ptn.age);
            command.Parameters.AddWithValue("prmAddress", ptn.address);
            //prmPatientID,prmRegistrationDate
            try {  
            conn.Open();
            command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }



        public static bool Update(Patient ObjUpdate)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {

                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE patientInfo SET firstName=@prmFirstName,lastName=@prmLastName, contactNumber= @prmContactNumber,age=@prmAge,address=@prmAddress WHERE patientID=@parmPatientID";
                command.Parameters.AddWithValue("prmFirstName", ObjUpdate.firstName);
                command.Parameters.AddWithValue("prmLastName", ObjUpdate.lastName);
                command.Parameters.AddWithValue("parmPatientID", ObjUpdate.patientID);
                command.Parameters.AddWithValue("prmContactNumber", ObjUpdate.contactNumber);
                command.Parameters.AddWithValue("prmAge", ObjUpdate.age);
                command.Parameters.AddWithValue("prmAddress", ObjUpdate.address);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
               
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }


        public static DataTable GetTableData()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM patientInfo", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);  // inserts the data table returned from MySqlDataAdapter  sda to the DataTable dt;
            return dt;

        }
        public static DataTable Search(string searchString)
        {
            //Instantiating Data Table
            DataTable dt = new DataTable();
            //MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = $"SELECT patientID AS 'Patient ID',registrationDate as 'Registration Date',firstName AS 'First Name',lastName AS 'Last Name',gender AS 'Gender',age AS 'Age',contactNumber AS 'Contact Number',address AS 'Address',status AS 'Status',referredTo as 'Referred To' FROM patientInfo" +
                             $" WHERE patientID LIKE '%{searchString}%' OR firstName LIKE '%{searchString}%' OR lastName LIKE '%{searchString}%' OR registrationDate LIKE '%{searchString}%' OR address LIKE '%{searchString}%' OR contactNumber LIKE '%{searchString}%' OR gender LIKE '%{searchString}%' OR" +
                             $" age LIKE '%{searchString}%' OR status LIKE '%{searchString}%' OR referredTo LIKE '%{searchString}%'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                //Load DataTable
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public static DataTable SeachAndGetTopRowFromTable(Patient obj)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter(@"SELECT * from patientinfo WHERE patientID LIKE '%" + obj.patientID + "%' LIMIT 1", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static int UpdateStatus(String patientID,string status)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE patientinfo SET status=@prmStatus WHERE patientID=@prmPatientID";
                command.Parameters.AddWithValue("prmPatientID", patientID);
                command.Parameters.AddWithValue("prmStatus",status);
                int row = command.ExecuteNonQuery();
                return row;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        //Method to retreive Patient datas from database
        public static DataTable FetchPatientsDetails()
        {
            //Instantiating Data Table
            DataTable dt = new DataTable();
            //MySqlConnection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = "SELECT patientID AS 'Patient ID',firstName AS 'First Name',lastName AS 'Last Name',address as 'Address',contactNumber AS 'Contact Number',registrationDate as 'Registration Date' FROM patientInfo";
            try
            {
                //MySQLCommand
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                //Load DataTable
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;

        }
        //Method to search data from database
        public static DataTable SearchPatientDetails(string searchString)
        {
            //Instantiating Data Table
            DataTable dt = new DataTable();
            //MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = $"SELECT patientID as 'Patient ID',firstName AS 'First Name',lastName AS 'Last Name',address as 'Address',contactNumber AS 'Contact Number',registrationDate as 'Registration Date' FROM patientInfo WHERE patientID LIKE '%{searchString}' OR firstName LIKE '%{searchString}%' OR lastName LIKE '%{searchString}%' OR address LIKE '%{searchString}%' OR contactNumber LIKE '%{searchString}%' OR registrationDate LIKE '%{searchString}%'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                //Load DataTable
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }
        public static DataTable SearchPatientID(String patientID)
        {
            DataTable dt = new DataTable();
            //MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = $"SELECT * FROM patientinfo WHERE patientID='{patientID}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                //Load DataTable
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }
    }

}
