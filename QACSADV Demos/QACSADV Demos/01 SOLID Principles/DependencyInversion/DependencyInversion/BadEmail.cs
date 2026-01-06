using System;

public class BadEmail 
{
    private string emailAddress;
    private string emailMessage;

    public BadEmail(string emailAddress, string emailMessage)
    {
        this.emailAddress = emailAddress;
        this.emailMessage = emailMessage;
    }
    public void SendEmail()
    {
        //Code that sends email
    	Console.WriteLine($"Sending bad email to {emailAddress}. Message reads: {emailMessage}");
    }
}