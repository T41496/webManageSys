using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webTRON_Management_Software.Models
{
    class Test
    {
        //Connection String
        //private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
        private static string connectionString = "server=localhost;user id=root;pwd=laxudb;database=webtronmanagement";

        //Methods

        //Method to store test name in database
        public static bool Insert(string patientID,List<string> prescribedTest)
        {
            //Create default variable and set it false initially
            bool isSucess = false;

            //MySql Command
            MySqlConnection conn = new MySqlConnection(connectionString);

            //MySql Query
            string SQLQuery = "INSERT INTO test VALUES";

            for(int index = 0; index < prescribedTest.Count; index++)
            {
                SQLQuery += $"('{patientID}','{prescribedTest[index]}',now(),'DIR-21-434344',NULL),";
            }
            //Remove  ',' from at the end of sql query
            SQLQuery = SQLQuery.Remove(SQLQuery.Length - 1);
            try
            {
                //MySQL Connection
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);

                //Open Connection
                conn.Open();

                //Execute Query
                cmd.ExecuteNonQuery();

                isSucess = true;
            }
            catch(Exception)
            {
                isSucess = false;
            }
            finally
            {
                //Close Connection
                conn.Close();
            }

            return isSucess;
        }
        //Method to fetch test results from the database
        public static DataTable FetchResult(string patientID)
        {
            //Instantiate DataTable
            DataTable dt = new DataTable();

            //MySQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);

            //SQLQuery
            string SQLQuery = "SELECT patientID AS 'Patient ID',testName AS 'Test Name',prescribedDate as 'Prescribed Date',reportID as 'Report ID',result AS 'Result' FROM test LEFT JOIN report USING(patientID,reportID,testName) WHERE patientID=BINARY @patientID";

            try
            {
                //Mysql command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);

                //Add Parameters
                cmd.Parameters.AddWithValue("@patientID", patientID);

                //Open Connection
                conn.Open();

                //Execute Query
                dt.Load(cmd.ExecuteReader());

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close connection
                conn.Close();
            }

            return dt;
        }
    }
}
