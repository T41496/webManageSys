using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace webTRON_Management_Software.Models
{
    public class Employee
    {
        //Connection String
        //private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
       private static string connectionString = "server=localhost;user id=root;pwd=laxudb;database=webtronmanagement";

        //Properties
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public byte[] img { get; set; }

        //Methods
        //Method to insert Employee data in database 
        public static bool Insert(Employee obj)
        {
            //Declaring a default bool variable and initializing false
            bool isSucess = false;
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //String SqlQuery
                string SQLQuery = "INSERT INTO employeeInfo(userID,firstName,lastName,email,address,contactNumber,dateOfBirth,gender,role,status) VALUES(@userID,@firstName,@lastName,@email,@address,@contactNumber,@dateOfBirth,@gender,@role,@status)";
                //MySql Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                cmd.Parameters.AddWithValue("@userID", obj.UserID);
                cmd.Parameters.AddWithValue("@firstName", obj.FirstName);
                cmd.Parameters.AddWithValue("@lastName", obj.LastName);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@address", obj.Address);
                cmd.Parameters.AddWithValue("@contactNumber", obj.ContactNumber);
                cmd.Parameters.AddWithValue("@dateOfBirth", obj.DateOfBirth);
                cmd.Parameters.AddWithValue("@gender", obj.Gender);
                cmd.Parameters.AddWithValue("@role", obj.Role);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                //Connection Open
                conn.Open();
                //Execute Query
                //Here ExecuteNonQuery() returns the number of rows affected
                int row = cmd.ExecuteNonQuery();
                isSucess = row > 0 ? true : false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isSucess = false;
            }

            finally
            {
                //Close Connection
                conn.Close();
            }
            return isSucess;

        }
        //Method to insert Employee image in database 
        public static void InsertImage(string userID, byte[] img)
        {
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLQuery
            string SQLQuery = "INSERT INTO userPicture(userID,picture) VALUES(@userID,@img) ON DUPLICATE KEY UPDATE picture=@img";
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Add paramters
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@img", img);
                //Connection Open
                conn.Open();
                //Execute Query
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
       
        //Method to update data on database
        public static bool Update(Employee obj)
        {
            //Declaring a default bool variable and initializing false
            bool isSucess = false;
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);

            //String SqlQuery
            string SQLQuery = "UPDATE employeeInfo SET firstName=@firstName,lastName=@lastName,email=@email,address=@address,contactNumber=@contactNumber,dateOfBirth=@dateOfBirth,gender=@gender WHERE userID= BINARY @userID";
            try
            {
                //MySql Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                cmd.Parameters.AddWithValue("@userID", obj.UserID);
                cmd.Parameters.AddWithValue("@firstName", obj.FirstName);
                cmd.Parameters.AddWithValue("@lastName", obj.LastName);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@address", obj.Address);
                cmd.Parameters.AddWithValue("@contactNumber", obj.ContactNumber);
                cmd.Parameters.AddWithValue("@dateOfBirth", obj.DateOfBirth);
                cmd.Parameters.AddWithValue("@gender", obj.Gender);
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
        //Method to retreive datas from database
        public static DataTable Fetch()
        {
            //Instantiating Data Table
            DataTable dt = new DataTable();
            //MySqlConnection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = "SELECT userID AS 'User ID',firstName AS 'First Name',lastName AS 'Last Name',email AS 'Email',address AS 'Address',contactNumber AS 'Contact Number',dateOfBirth AS 'Date Of Birth',gender AS 'Gender',role AS 'Role',status AS 'Status' FROM activeEmployees";
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
        //Method to retreive staff datas from database
        public static DataTable FetchStaffsDetails()
        {
            //Instantiating Data Table
            DataTable dt = new DataTable();
            //MySqlConnection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = "SELECT firstName AS 'First Name',lastName AS 'Last Name',email AS 'Email',contactNumber AS 'Contact Number',role AS 'Role' FROM activeEmployees";
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
        public static DataTable Search(string searchString)
        {

            //Instantiating Data Table
            DataTable dt = new DataTable();
            //MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = $"SELECT userID AS 'User ID',firstName AS 'First Name',lastName AS 'Last Name',email AS 'Email',address AS 'Address',contactNumber AS 'Contact Number',dateOfBirth AS 'Date Of Birth',gender AS 'Gender',role AS 'Role',status AS 'Status' FROM activeEmployees" +
                             $" WHERE userID LIKE '%{searchString}%' OR firstName LIKE '%{searchString}%' OR lastName LIKE '%{searchString}%' OR email LIKE '%{searchString}%' OR address LIKE '%{searchString}%' OR contactNumber LIKE '%{searchString}%' OR dateOfBirth LIKE '%{searchString}%' OR" +
                             $" gender LIKE '%{searchString}%' OR role LIKE '%{searchString}%' OR status LIKE '%{searchString}%'";
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
        //Method to search data from database
        public static DataTable SearchStaffDetails(string searchString)
        {
            //Instantiating Data Table
            DataTable dt = new DataTable();
            //MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = $"SELECT firstName AS 'First Name',lastName AS 'Last Name',email AS 'Email',contactNumber AS 'Contact Number',role AS 'Role' FROM employeeInfo WHERE firstName LIKE '%{searchString}%' OR lastName LIKE '%{searchString}%' OR email LIKE '%{searchString}%' OR contactNumber LIKE '%{searchString}%' OR role LIKE '%{searchString}%'";
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

        //Method to check wheather the email is exist in database or not
        public static bool IsEmailExist(string email)
        {
            //Declaring default bool variable and initiazling it false
            bool isExist = false;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string SQLQuery = "SELECT EXISTS(Select userID FROM employeeInfo WHERE email=BINARY @email)";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Creating parameter to add values
                cmd.Parameters.AddWithValue("@email", email);

                //Open Connection
                conn.Open();
                //ExecuteQuery->In above query it returns either 0 or 1 
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    int count = Convert.ToInt32(returnValue);
                    isExist = count == 1 ? true : false;
                }
                else
                {
                    MessageBox.Show("Internal Server Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //Method to store verification code in database
        public static bool StoreVerificationCode(string userEmail, double verificationCode)
        {
            //Fetched user ID
            string fetchedUserID = "";

            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //First SQLQuery
                string SQLQueryFirst = "SELECT userID FROM employeeInfo WHERE email=BINARY @userEmail";
                //Second SQLQuery
                string SQLQuerySecond = "INSERT INTO verificationCodes(userID,code) VALUES(@fetchedUserID,@verificationCode) ON DUPLICATE KEY UPDATE code=@verificationCode";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQueryFirst, conn);

                //Add Parameters
                cmd.Parameters.AddWithValue("@userEmail", userEmail);
                //Open Connection
                conn.Open();
                //Execute query
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    fetchedUserID = returnValue.ToString();


                }
                else
                {
                    MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmd = new MySqlCommand(SQLQuerySecond, conn);
                cmd.Parameters.AddWithValue("@fetchedUserID", fetchedUserID);
                cmd.Parameters.AddWithValue("@verificationCode", verificationCode);
                //Execute query
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {
                return false;
            }

            finally
            {
                //Close Connection
                conn.Close();
            }
            return true;

        }
        //Method to check valid verification code
        public static bool IsValidVerificationCode(string userEmail, int code)
        {
            //Declare default variable and set it false
            bool isValid = false;
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //SQL Query
                string SQLQuery = "SELECT EXISTS(SELECT userID FROM employeeInfo NATURAL JOIN verificationCodes WHERE email=BINARY @userEmail AND code=@code)";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Pass parameters
                cmd.Parameters.AddWithValue("@userEmail", userEmail);
                cmd.Parameters.AddWithValue("@code", code);
                //Connection open
                conn.Open();
                //Execute query->it returns either 0 or 1
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    int value = Convert.ToInt32(returnValue);
                    isValid = value == 1 ? true : false;
                }
                else
                {
                    isValid = false;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }
            return isValid;
        }
        //Method to update password from database
        public static bool UpdatePassword(string userEmail, string newPassword)
        {
            //Fetched user ID
            string fetchedUserID = "";

            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //First SQLQuery
                string SQLQueryFirst = "SELECT userID FROM employeeInfo WHERE email=BINARY @userEmail";
                //Second SQLQuery
                string SQLQuerySecond = "UPDATE Users SET password=AES_ENCRYPT(@newPassword,'webTRON') WHERE userID=BINARY @userID";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQueryFirst, conn);

                //Add Parameters
                cmd.Parameters.AddWithValue("@userEmail", userEmail);
                //Open Connection
                conn.Open();
                //Execute query
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    fetchedUserID = returnValue.ToString();


                }
                else
                {
                    return false;
                }
                cmd = new MySqlCommand(SQLQuerySecond, conn);
                cmd.Parameters.AddWithValue("@userID", fetchedUserID);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                //Execute query
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            finally
            {
                //Close Connection
                conn.Close();
            }
            //Password changed sucessfully so return true
            return true;

        }
        //Method to return total number of online/offline user
        public static (int, int) GetTotalUserStatus()
        {
            //Data Reader Mysql
            MySqlDataReader reader;
            //Mysql Connectiion
            MySqlConnection conn = new MySqlConnection(connectionString);
            int countOfTotalOfflineUser = 0, countOfTotalOnlineUser = 0;

            try
            {
                //SQL Query
                string SQLQuery = @"SELECT COUNT(IF(status='online',1,null)) AS countOfOnlineUser ,COUNT(IF(status='offline',1,null)) AS countOfTotalOfflineUser FROM employeeInfo";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                //Execute Query
                reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);//To read single row
                while (reader.Read())
                {
                    countOfTotalOnlineUser = Convert.ToInt32(reader.GetValue(0));
                    countOfTotalOfflineUser = Convert.ToInt32(reader.GetValue(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return (countOfTotalOfflineUser, countOfTotalOnlineUser);
        }
        //Method that return active employee information
        public static Employee GetActiveUserDetails(string userID)
        {
            //Data Reader
            MySqlDataReader reader;
            //Instantiate Employee class object
            Employee obj = new Employee();
            //Mysql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = "SELECT * FROM employeeInfo LEFT JOIN userPicture USING(userID) WHERE userID=BINARY @userId";
            try
            {
                //MySqlCommand
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Pass Parameters
                cmd.Parameters.AddWithValue("@userId", userID);
                //Open Connection
                conn.Open();
                //Execute Query
                reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                //Fetch Data
                while (reader.Read())
                {
                    //Instantiate object attributes
                    obj.UserID = reader.GetValue(0).ToString();
                    obj.FirstName = reader.GetValue(1).ToString();
                    obj.LastName = reader.GetValue(2).ToString();
                    obj.Email = reader.GetValue(3).ToString();
                    obj.Address = reader.GetValue(4).ToString();
                    obj.ContactNumber = reader.GetValue(5).ToString();
                    obj.DateOfBirth = reader.GetValue(6).ToString();
                    obj.Gender = reader.GetValue(7).ToString();
                    obj.Role = reader.GetValue(8).ToString();
                    obj.Status = reader.GetValue(9).ToString();
                    if (reader.GetValue(10).ToString()!= "")
                    {
                    
                        obj.img = (byte[])reader.GetValue(10);

                    }
                    else
                    {
                        obj.img =null;
                    }

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
            return obj;
        }
        //Method to set status of employee either online or offline
        public static void SetStatus(string userId, string status)
        {

            //MySqlConnection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SqlQuery
            string SqlQuery = "UPDATE employeeInfo SET status=@status WHERE userId=BINARY @userID";
            try
            {
                //MySqlCommand
                MySqlCommand cmd = new MySqlCommand(SqlQuery, conn);
                //Add parameters with value
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@status", status);
                //Connection open
                conn.Open();
                //Execute Query
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
