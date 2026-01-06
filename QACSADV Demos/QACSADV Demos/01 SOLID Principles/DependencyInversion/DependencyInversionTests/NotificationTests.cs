using System;
using DIPMessagerExample;
using NSubstitute;
using System.IO;


namespace DIPMessagingExampleTester
{
    public class NotificationTests
    {
        [Fact]
        public void BadNotificationTest()
        {
            //Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            string emailAddress = "Esme@OverThere.com";
            string emailMessage = "Hello from over here";
            string expectedOutput = $"Sending bad email to {emailAddress}. Message reads: {emailMessage}\r\n";


            //Act
            BadNotification notification = new BadNotification(emailAddress, emailMessage);
            notification.SendNotification();

            //Assert
            Assert.Equal(expectedOutput, writer.ToString());
        }

        [Fact]
        public void BetterNotificationTest()
        {
            //Actually things are NOT much better. The
            //"BetterNotification" object is still restricted
            //to using only "Email" objects

            //Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            string emailAddress = "Esme@OverThere.com";
            string emailMessage = "Hello from over here";
            string expectedOutput = $"Sending better(ish) email to {emailAddress}. Message reads: {emailMessage}\r\n";

            //Act
            BetterEmail email = new BetterEmail(emailAddress, emailMessage);
            BetterNotification notification = new BetterNotification(email);
            notification.SendNotification();

            //Assert
            Assert.Equal(expectedOutput, writer.ToString());

        }

        [Fact]
        public void BestNotificationTestUsingEmail()
        {
            //Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            string emailAddress = "Esme@OverThere.com";
            string emailMessage = "Hello from over here";
            string smsExpectedOutput = "Some issue delivering\r\n";
            string emailExpectedOutput = $"Sending best email to {emailAddress}. Message reads: {emailMessage}\r\n";

            IMessageService emailMessageService = new BestEmail(emailAddress, emailMessage);

            string userName = "Ted Tester";
            string userPassword = "Pa$$w0rd";
            string msgRecipient = "07800757165";
            string msgSource = "07800757165";
            string msgText = "Hi there!";
            IMessageService smsMessageService = new BestSMS(userName, userPassword, msgRecipient, msgSource, msgText);

            //can use any kind of messaging system
            //as long as it implements IMessageService

            //Act
            //Inject service into Notification object's constructor
            BestNotification notification = new BestNotification(emailMessageService);
            notification.SendNotification();

            //Assert
            Assert.Equal(emailExpectedOutput, writer.ToString());
        }


        [Fact]
        public void BestNotificationTestUsingSMS()
        {
            //Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            string emailAddress = "Esme@OverThere.com";
            string emailMessage = "Hello from over here";
            string smsExpectedOutput = "Some issue delivering\r\n";
            string emailExpectedOutput = $"Sending best email to {emailAddress}. Message reads: {emailMessage}\r\n";

            IMessageService emailMessageService = new BestEmail(emailAddress, emailMessage);

            string userName = "Ted Tester";
            string userPassword = "Pa$$w0rd";
            string msgRecipient = "07800757165";
            string msgSource = "07800757165";
            string msgText = "Hi there!";
            IMessageService smsMessageService = new BestSMS(userName, userPassword, msgRecipient, msgSource, msgText);

            //can use any kind of messaging system
            //as long as it implements IMessageService

            //Arrange
            //Inject alternative service into Notification object's constructor
            BestNotification notification = new BestNotification(smsMessageService);
            notification.SendNotification();

            //Assert
            Assert.Equal(smsExpectedOutput, writer.ToString());
        }


        [Fact]
        public void BestNotificationTestUsingNSubstitute()
        {
            //Arrange
            //string emailAddress = "Esme@OverThere.com";
            //string emailMessage = "Hello from over here";
            IMessageService emailMessageService = Substitute.For<IMessageService>();
      
            //string userName = "Ted Tester";
            //string userPassword = "Pa$$w0rd";
            //string msgRecipient = "07800757165";
            //string msgSource = "07800757165";
            //string msgText = "Hi there!";
            IMessageService smsMessageService = Substitute.For<IMessageService>();

            //can use any kind of messaging system
            //as long as it implements IMessageService

            //Act
            //Inject service into Notification object's constructor
            BestNotification notification = new BestNotification(emailMessageService);
            notification.SendNotification();

            //Inject alternative service into Notification object's constructor
            notification = new BestNotification(smsMessageService);
            notification.SendNotification();

            //Assert
            emailMessageService.Received(1).SendMessage();
            smsMessageService.Received(1).SendMessage();
        }
    }
}
