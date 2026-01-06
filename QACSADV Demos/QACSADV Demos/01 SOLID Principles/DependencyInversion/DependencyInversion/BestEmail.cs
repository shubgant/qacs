using System;

public class BestEmail:IMessageService {

    private string emailAddress;
    private string emailMessage;

    public BestEmail(string emailAddress, string emailMessage)
    {
        this.emailAddress = emailAddress;
        this.emailMessage = emailMessage;
    }
    public void SendMessage()
    {
        //Code that sends email
        Console.WriteLine($"Sending best email to {emailAddress}. Message reads: {emailMessage}");
    }
}

