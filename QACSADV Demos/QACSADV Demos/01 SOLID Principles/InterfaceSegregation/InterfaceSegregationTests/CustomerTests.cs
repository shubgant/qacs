using InterfaceSegregation;
using NSubstitute;

namespace InterfaceSegregationTester
{
    public class CustomerTests
    {
        /// <summary>
        /// Now there is no confusion, we can create a list of objects that implement “ISale” 
        /// and add the relevant class instances to it. In case we make a mistake of adding 
        /// a "B_Enquiry" object to the list the compiler would complain as shown in the below code.
        /// </summary>
        [Fact]
        public void OldCustomerTestsSameAsBefore()
        {
            //Arrange
            List<ISale> customers = new List<ISale>();
            ILogger logger = Substitute.For<ILogger>();

            customers.Add(new A_SilverCustomer(logger));
            customers.Add(new A_GoldCustomer(logger));

            //Act
            foreach (ISale o in customers)
            {
                o.AddSaleToDatabase("Shoes", 100.00M);
            }

            //Assert
            //Code that ensures logging has worked correctly
            logger.Received(2).Handle(Arg.Any<string>());
        }

        /// <summary>
        /// Now there is no confusion, we can create a list of “IDatabase” interface 
        /// and add the relevant classes to it. In case we make a mistake of adding 
        /// "B_Enquiry" class to the list compiler would complain as shown in the below code.
        /// </summary>
        [Fact]
        public void NewCustomerTestsIncludeCallToRetrieveLoyaltyPointsMethod()
        {
            //Arrange
            List<ISaleV2> customers = new List<ISaleV2>();
            ILogger logger = Substitute.For<ILogger>();

            customers.Add(new B_PlatinumCustomer(logger));
            customers.Add(new B_DiamondCustomer(logger));
            int totalLoyaltyPoints = 0;

            //Act
            foreach (ISaleV2 o in customers)
            {
                o.AddSaleToDatabase("Shoes", 100.00M);
                totalLoyaltyPoints += o.RetrieveLoyaltyPoints();
            }

            //Assert
            //Code that ensures logging has worked correctly
            Assert.Equal(235, totalLoyaltyPoints);
            logger.Received(2).Handle(Arg.Any<String>()); 
        }

        /// <summary>
        /// Now there is no confusion, we can create a list of “IDisplay” interface 
        /// and add the relevant classes to it (including B_Enquiry).
        /// </summary>
        [Fact]
        public void GetDiscountsOldAndNewTogether()
        {
            //Arrange
            decimal totalSales = 200.00m;
            decimal sumOfTotalSales = 0.00m;
            List<IDiscount> customers = new List<IDiscount>();
            ILogger logger = Substitute.For<ILogger>();

            customers.Add(new A_SilverCustomer(logger));
            customers.Add(new A_GoldCustomer(logger));
            customers.Add(new B_PlatinumCustomer(logger));
            customers.Add(new B_DiamondCustomer(logger));
            customers.Add(new A_Enquiry(logger));

            //Act
            foreach (IDiscount o in customers)
            {
                sumOfTotalSales += o.GetDiscount(totalSales);
            }

            //Assert
            Assert.Equal(896.00m, sumOfTotalSales);
        }
    }
}
