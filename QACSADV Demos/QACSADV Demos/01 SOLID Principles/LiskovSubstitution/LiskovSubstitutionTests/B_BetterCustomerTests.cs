using LiskovSubstitution;
using System;



namespace LoskovSubstitutionTester
{

    public class B_BetterCustomerTests
    {
        /// <summary>
        /// Now there is no confusion, we can create a list of “IDatabase” interface 
        /// and add the relevant classes to it. In case we make a mistake of adding 
        /// “B_Enquiry” class to the list compiler would complain as shown in the below code.
        /// </summary>
        [Fact]
        public void NoEnquiryProblemBecauseCodeWouldNotCompile()
        {
            //Arrange
            string product = "Shoes";
            decimal price = 100.00M;
            List<ISale> customers = new List<ISale>();
            FileLogger logger = new FileLogger();
            string expectedLogFileContent = $"product {product} sale of {price:C} committed to database";

            customers.Add(new B_SilverCustomer(logger));
            customers.Add(new B_GoldCustomer(logger));
            //The following line will now not compile:
            //customers.Add(new B_Enquiry(logger));

            //Act
            foreach (ISale o in customers)
            {
                o.AddSaleToDatabase(product, price);
            }

            //Assert
            //Code that ensures logging has worked correctly
            string actualLogFileContent = System.IO.File.ReadAllText("c:\\Temp\\Log.txt");
            Assert.Equal(expectedLogFileContent, actualLogFileContent);
        }

        /// <summary>
        /// Now there is no confusion, we can create a list of “IDisplay” interface 
        /// and add the relevant classes to it (including B_Enquiry).
        /// </summary>
        [Fact]
        public void GetDiscounts()
        {
            //Arrange
            decimal price = 200m;
            decimal sumOfDiscountedPrices = 0m;
            List<IDiscount> customers = new List<IDiscount>();
            FileLogger logger = new FileLogger();

            customers.Add(new B_SilverCustomer(logger));
            customers.Add(new B_GoldCustomer(logger));
            customers.Add(new B_Enquiry(logger));

            //Act
            foreach (IDiscount o in customers)
            {
                sumOfDiscountedPrices += o.GetDiscountedPrice(price);
            }

            //Assert
            Assert.Equal(566.00M, sumOfDiscountedPrices);
        }

    }
}
