using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPMessagerExample
{
    //Same set up and structure as BadEmail
    public class BetterEmail
    {
        private string emailAddress;
        private string emailMessage;

        public BetterEmail(string emailAddress, string emailMessage)
        {
            this.emailAddress = emailAddress;
            this.emailMessage = emailMessage;
        }
        public void SendEmail()
        {
            //Code that sends email
            Console.WriteLine($"Sending better(ish) email to {emailAddress}. Message reads: {emailMessage}");
        }
    }
}
