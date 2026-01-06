using SingleResponsibility;
using NSubstitute;
using Moq;
using static System.Formats.Asn1.AsnWriter;


namespace SingleResponsibilityUnitTests
{
    //Note: The following methods are not really testing anything. They are designed to 
    //simply show what the client code would look like for the 3 scenarios
    public class UnitTest1
    {
        string message = "Mailing list details";
        string expectedResult = "Mailing list details";

        [Fact]
        public void TestBadCustomer()
        {
            //Arrange
            A_BadCustomer badCustomer = new A_BadCustomer();

            //Act
            badCustomer.AddToMailingList(message);

            //Assert
            string actualresult = System.IO.File.ReadAllText("c:\\Temp\\Error.txt");
            Assert.Equal(expectedResult, actualresult);
        }

        [Fact]
        public void TestBetterCustomer()
        {   
            //Arrange
            B_BetterCustomer betterCustomer = new B_BetterCustomer();

            //Act
            betterCustomer.AddToMailingList(message);

            //Assert
            string actualresult = System.IO.File.ReadAllText("c:\\Temp\\Error.txt");
            Assert.Equal(expectedResult, actualresult);
        }

        [Fact]
        public void TestBestCustomer()
        {
            //Arrange
            ILogger logger = new FileLogger();
            C_BestCustomer bestCustomer = new C_BestCustomer(logger);

            //Act
            bestCustomer.AddToMailingList(message);

            //Assert
            string actualresult = System.IO.File.ReadAllText("c:\\Temp\\Error.txt");
            Assert.Equal(expectedResult, actualresult);
        }

        //Using a Mocking Framework allows you to create stubs 
        //but you can also use them to specify (and assert) expectations
        //such that a particular method is called a specified number of times.

        //Using the Moq mocking framework
        [Fact]
        public void TestBestCustomerUsingMoq()
        {
            //Arrange
            var logger = new Mock<ILogger>();
            logger.Setup(l => l.Handle(It.IsAny<string>()));
          
            //Act
            C_BestCustomer bestCustomer = new C_BestCustomer(logger.Object);
            bestCustomer.AddToMailingList("Mailing list details");

            //Assert
            logger.Verify(l => l.Handle(message));
        }

        //Using the NSubstitute mocking framework
        [Fact]
        public void TestBestCustomerUsingNSubstitute()
        {
            //Arrange
            ILogger logger = Substitute.For<ILogger>(); 
            string details = "Mailing list details";
            Exception ex = new Exception(details);

            //Act
            C_BestCustomer bestCustomer = new C_BestCustomer(logger);
            bestCustomer.AddToMailingList(details);

            //Assert
            logger.Received().Handle(ex.Message); 
        }
    }
}
