using System;
using System.Net;

public class BestSMS :IMessageService 
{
    string userName;
    string userPassword;
    string destinationNumber;
    string sourceNumber;
    string message;
    //Note: You could sign up to ViaNett 
    //(https://www.vianett.com/en/free-demonstration-account)
    //for a free demonstration account
    //doing so will give you a url like the one below and the opportunity to send
    //5 SMS messages free of charge
    string url = "http://smsc.vianett.no/v3/send.ashx?";

    public BestSMS(string userName, string userPassword, string destinationNumber, string sourceNumber, string message)
    {
        this.userName = System.Web.HttpUtility.UrlEncode(userName);
        this.userPassword = userPassword;
        this.destinationNumber = destinationNumber;
        this.sourceNumber = sourceNumber;
        this.message = System.Web.HttpUtility.UrlEncode(message, System.Text.Encoding.GetEncoding("ISO-8859-1"));
    }

	public void SendMessage() {
        using (WebClient web = new WebClient()) {
            try {
                string smsMessage = $"{url}src={sourceNumber}&dst={destinationNumber}&msg={message}&username={userName}&password={userPassword}";
                string result = web.DownloadString(smsMessage);
                if (result.Contains("OK"))
                {
                    Console.WriteLine("Sms sent successfully");
                }
                else
                {
                    Console.WriteLine("Some issue delivering");
                }
            }
            catch(Exception exn) {
                Console.WriteLine(exn.Message);
            }
        }
	}
}