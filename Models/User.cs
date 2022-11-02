using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace webTRON_Management_Software.Models
{
    public class User
    {
        //Connection String
        //private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
          private static string connectionString = "server=localhost;user id=root;pwd=laxudb; database=webtronmanagement";

        //Properties
        public string userID { get; set; }
        public string password { get; set; }

        //Methods
        //Method to insert data in database
        public static bool Insert(User obj)
        {
            //Declaring a default bool variable and initializing false
            bool isSucess = false;
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //String SqlQuery
                string SQLQuery = "INSERT INTO Users(userID,password) VALUES(@userID,AES_ENCRYPT(@password,'webTRON'))";
                //MySql Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                cmd.Parameters.AddWithValue("@userID", obj.userID);
                cmd.Parameters.AddWithValue("@password", obj.password);
                //Connection Open
                conn.Open();
                //Execute Query
                //Here ExecuteNonQuery() returns the number of rows affected
                int row = cmd.ExecuteNonQuery();
                isSucess = row > 0 ? true : false;

            }
            catch (Exception)
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
        //Method to insert data in database
        public static bool Delete(string userID)
        {
            //Declaring a default bool variable and initializing false
            bool isSucess = false;
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = "DELETE FROM users WHERE userID=BINARY @userID";
            try
            {
                //MySql Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                cmd.Parameters.AddWithValue("@userID",userID);
                //Connection Open
                conn.Open();
                //Execute Query
                //Here ExecuteNonQuery() returns the number of rows affected
                cmd.ExecuteNonQuery();

                SQLQuery = "DELETE FROM lastLogInInfo WHERE userID=BINARY @userID";
                cmd = new MySqlCommand(SQLQuery, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
                
                SQLQuery = "DELETE FROM verificationCodes WHERE userID=BINARY @userID";
                cmd = new MySqlCommand(SQLQuery, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
                isSucess = true;
            }
            catch (Exception)
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

        //Method to check wheather the user is authorized or not
        public static bool CheckUser(User obj)
        {
            //Declaring default bool variable and initiazling it false
            bool isExist = false;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string SQLQuery = "SELECT COUNT(userID) FROM users WHERE password=BINARY AES_ENCRYPT(@password,'webTRON') AND userID=BINARY @userID";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Creating parameter to add values
                cmd.Parameters.AddWithValue("@userID", obj.userID);
                cmd.Parameters.AddWithValue("@password", obj.password);
                //Open Connection
                conn.Open();
                //ExecuteQuery
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    int count = Convert.ToInt32(returnValue);
                    isExist = count == 1 ? true : false;
                }
                else
                {
                    isExist = false;
                }
            }
            catch (Exception)
            {
                isExist = false;
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return isExist;

        }
        //Method to store last loggedIn info of User
        public static bool StoreLogInInfo(string userID)
        {
            //Creating variable and initializing it with false
            bool isSucess = false;

            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //SQL Query
                string SQLQuery = $"INSERT INTO lastLogInInfo(userID,logInDate) VALUES(@userID,now())";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Add Parameters to query
                cmd.Parameters.AddWithValue("@userID", userID);
                //Open Connection
                conn.Open();
                //Execute Query
                int row = cmd.ExecuteNonQuery();
                isSucess = row == 1 ? true : false;

            }
            catch (Exception)
            {
                isSucess = false;
            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return isSucess;

        }
        //Method to update last loggedIn info of User
        public static bool UpdateLogInInfo(string userID)
        {
            //Creating variable and initializing it with false
            bool isSucess = false;

            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //SQL Query
                string SQLQuery = $"UPDATE lastLogInInfo SET logInDate=NOW() WHERE userID=@userID";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Add Parameters to query
                cmd.Parameters.AddWithValue("@userID", userID);
                //Open Connection
                conn.Open();
                //Execute Query
                int row = cmd.ExecuteNonQuery();
                isSucess = row == 1 ? true : false;

            }
            catch (Exception)
            {
                isSucess = false;
            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return isSucess;

        }
        //Method to check wheather the user login is first time or not into the system
        public static bool IsFirstTimeLogin(string userID)
        {
            //Declaring default bool variable and initiazling it false
            bool isFirstTime = false;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string SQLQuery = "SELECT EXISTS(Select *  FROM lastLogInInfo WHERE userID=@userID)";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Creating parameter to add values
                cmd.Parameters.AddWithValue("@userID", userID);

                //Open Connection
                conn.Open();
                //ExecuteQuery->In above query it returns either 0 or 1 
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    int count = Convert.ToInt32(returnValue);
                    isFirstTime = count == 0 ? true : false;
                }
                else
                {
                    MessageBox.Show("Internal Server Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            return isFirstTime;

        }
        //Method to get user role
        public static string GetUserRole(string userID)
        {
            string role = "undefined";
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string SQLQuery = "SELECT role FROM employeeInfo WHERE userID=@userID";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Creating parameter to add values
                cmd.Parameters.AddWithValue("@userID", userID);

                //Open Connection
                conn.Open();
                //ExecuteQuery->In above query it returns either 0 or 1 
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    role = returnValue.ToString();
                }
                else
                {
                    MessageBox.Show("Error Occured!\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            return role;

        }
        //Method to set account status
        public static void SetAccountStatus(string userID, string status)
        {
            
            //MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SqlQuery
            string SQLQuery = "INSERT INTO accountStatus VALUES(@userID,@status) ON DUPLICATE KEY UPDATE status=@status"; 
            try
            {
                //SQLCommand
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Add parameters
                cmd.Parameters.AddWithValue("@userID", userID);

                cmd.Parameters.AddWithValue("@Status", status);
                //Open Connection
                conn.Open();
                //Execute query
                cmd.ExecuteNonQuery();
               
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
          

        }

    }
}
