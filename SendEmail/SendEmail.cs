using System.Net;
using System.Net.Mail;
using GetCrntIPAdrs;
using System.Configuration;

namespace Notifications
{
    public class SendNotifications
    {
        public int SendEmail()
        {
            try
            {
                //created object of SmtpClient details and provides server details
                SmtpClient MyServer = new SmtpClient(ConfigurationManager.AppSettings["SMTPCLNT"].ToString());
                //MyServer.Host = "";
                MyServer.Port = System.Convert.ToInt32(ConfigurationManager.AppSettings["SMTPPORT"]); ;
                MyServer.EnableSsl = System.Convert.ToBoolean(ConfigurationManager.AppSettings["SSLSWTCH"]);

                //Server Credentials
                NetworkCredential NC = new NetworkCredential();
                NC.UserName = ConfigurationManager.AppSettings["USERNAME"].ToString(); //"mailTo.247365";
                NC.Password = ConfigurationManager.AppSettings["USERPSWD"].ToString(); //"sh@gird#1";

                //assigned credetial details to server
                MyServer.Credentials = NC;

                //create sender address
                MailAddress from = new MailAddress(ConfigurationManager.AppSettings["USERNAME"].ToString() + "@" + 
                                                    ConfigurationManager.AppSettings["EMAILAPP"].ToString(), 
                                                    ConfigurationManager.AppSettings["DSPLYADRS"].ToString());

                //create receiver address
                MailAddress receiver = new MailAddress(ConfigurationManager.AppSettings["TOADRESS"].ToString());
                MailMessage Mymessage = new MailMessage(from, receiver);
                Mymessage.Subject = ConfigurationManager.AppSettings["MAILSBJCT"].ToString();
                Mymessage.Body = IPAdrs.getCurrentIP();

                //sends the email
                MyServer.Send(Mymessage);

                return 0;
            }
            catch(System.Net.WebException webex)
            {
                return 1;
            }
            catch(System.Exception ex)
            {
                return 2;
            }
        }


    }
}
