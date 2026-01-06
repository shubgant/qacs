using LiskovSubstitution;
using NSubstitute;
using System.Diagnostics;

namespace LoskovSubstitutionTester
{
    public class C_BestCustomerTests
    {
        /// <summary>
        /// Now there is no confusion, we can create a list of “ISale” objects 
        /// and add the relevant class instances to it. If we try to add a 
        /// “B_Enquiry” object to the list compiler would complain as shown in the below code.
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

            customers.Add(new C_SilverCustomer(logger));
            customers.Add(new C_GoldCustomer(logger));
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
        /// Now there is no confusion, we can create a list of objects that implement “IDiscount”  
        /// and add the relevant class instances to it (including B_Enquiry).
        /// </summary>
        [Fact]
        public void GetDiscounts()
        {
            //Arrange
            decimal price = 200m;
            decimal sumOfDiscountedPrices = 0m;
            List<IDiscount> customers = new List<IDiscount>();
            ILogger logger = new FileLogger();

            customers.Add(new C_SilverCustomer(logger));
            customers.Add(new C_GoldCustomer(logger));
            customers.Add(new B_Enquiry(logger));

            //Act
            foreach (IDiscount o in customers)
            {
                sumOfDiscountedPrices += o.GetDiscountedPrice(price);
            }

            //Assert
            Assert.Equal(566.00M, sumOfDiscountedPrices);
        }

        /// <summary>
        /// Now there is no confusion, we can create a list of objects that implement “IDiscount”  
        /// and add the relevant class instances to it (including B_Enquiry).
        /// Using NSubstitute framework for the FileLogger
        /// </summary>
        [Fact]
        public void GetDiscountsUsingJustMock()
        {
            //Arrange
            decimal price = 200m;
            decimal sumOfDiscountedPrices = 0m;
            string product = "eggs";
            decimal totalSales = 10.01m;
            string successMessage = $"product {product} sale of {totalSales:C} committed to database";
            string exceptionMessage = "A bad thing has happened.";

            List<IDiscount> customers = new List<IDiscount>();
            ILogger logger = Substitute.For<ILogger>();

            customers.Add(new C_SilverCustomer(logger));
            customers.Add(new C_GoldCustomer(logger));
            customers.Add(new B_Enquiry(logger));

            //Act
            foreach (IDiscount o in customers)
            {
                sumOfDiscountedPrices += o.GetDiscountedPrice(price);
                if (o is ISale)
                    ((ISale)o).AddSaleToDatabase("eggs", 10.01m);
            }

            //Assert
            Assert.Equal(566.00M, sumOfDiscountedPrices);
            logger.Received(2).Handle(Arg.Any<string>());
            logger.Received(2).Handle(successMessage);
            logger.Received(0).Handle(exceptionMessage);
        }
    }
}

