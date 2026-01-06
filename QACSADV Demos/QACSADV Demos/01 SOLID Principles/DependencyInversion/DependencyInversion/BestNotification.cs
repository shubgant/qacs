public class BestNotification {
    private IMessageService messageService;
    
    //constructor gets an IMessageService injected into it. 
    //The injected messaging service could be sending our message as
    //an email, a SMS message or to a database
    public BestNotification(IMessageService messageService)
    {
        this.messageService = messageService;
    }

    public void SendNotification()
    {
        messageService.SendMessage();
    }
}