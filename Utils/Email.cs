using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webTRON_Management_Software.Utils
{
    class Email
    {
        private static string smtpAddress = "smtp.gmail.com";
        private static int portNumber = 587;
        private static bool enableSSL = true;
        private static string emailFromAddress = "webtroninfo@gmail.com"; //Sender Email Address  
        private static string password = "webTRON@123@"; //Sender Password  
        
        
        static string emailToAddress;
        static string subject;
        static string body;
       
        //Method to send account info
       public static bool SendAccountInfo(string userEmail,string userID,string password)
        {
            //Set default status false
            bool isSucess =false;
            emailToAddress = userEmail;
            subject = "New Account Created";
            body = $"Welcome to the webTRON Management Software.\n\nYour UserID:{userID}\nYour Password:{password}";

            //This method sends mail
            isSucess=SendEmail();
            return isSucess;
        }
        //Method to send verification code
        public static bool SendVerificationCode(string userEmail,double verificationCode)
        {
            //Set default status false
            bool isSucess = false;
            emailToAddress = userEmail;
            subject = "Forget Password";
            body = $"Your verification code:{verificationCode}";
            //Send Email
            isSucess = SendEmail();
            return isSucess;
        }
        //Method to send verification code->Overloaded method
        public static bool SendVerificationCode(double verificationCode,string userEmail)
        {
            //Set default status false
            bool isSucess = false;
            emailToAddress = userEmail;
            subject = "Change Passowrd";
            body = $"Your verification code:{verificationCode}";
            //Send Email
            isSucess = SendEmail();
            return isSucess;
        }

        //Method to send email
        private static bool SendEmail()
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = subject;
                mail.Body = body;
                //To send attachment uncomment the following code
                /*
                mail.IsBodyHtml = true;
                mail.Attachments.Add(new Attachment("{attachmentLocation}"));
                */
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    try
                    {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);

                    }
                    catch (Exception)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}
