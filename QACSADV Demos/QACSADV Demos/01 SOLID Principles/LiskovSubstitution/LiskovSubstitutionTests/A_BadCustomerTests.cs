using System;
using LiskovSubstitution;

namespace LoskovSubstitutionTester
{
    public class A_BadCustomerTests
    {
        /// <summary>
        /// So as per polymorphism rule my parent “A_BadCustomer” class object can point to any of 
        /// its child class objects i.e. “A_GoldCustomer”, “A_SilverCustomer” or “A_Enquiry” 
        /// during runtime without any issues. 
        /// So for instance in the below code you can see we have created a list 
        /// collection of “A_BadCustomer” and thanks to polymorphism I can add 
        /// “A_SilverCustomer” , “A_GoldCustomer” and “A_Enquiry” customer to the 
        /// “customer” collection without any issues. Thanks to polymorphism I can
        /// also browse the “customer” list using the parent customer 
        /// object and invoke the “AddSaleToDatabase” method as shown in the below code.
        /// The trouble is when the AddSaleToDatabase method of the "A_Enquiry" object is invoked it throws
        /// and exception because Enquiry objects cannot be saved to the database 
        /// because they are not actual customers.
        /// 
        /// The A_Enquiry class looks like a customer in that it has a GetDiscount method
        /// but it is not a customer because it shouldn't have an AddSaleToDatabase method.
        /// </summary>
        [Fact]
        public void EnquiryProblem()
        {
            //Arrange
            List<A_BadCustomer> customers = new List<A_BadCustomer>();
            ILogger logger = new FileLogger();

            customers.Add(new A_SilverCustomer(logger));
            customers.Add(new A_GoldCustomer(logger));
            customers.Add(new A_Enquiry(logger));

            //Act & Assert
            Exception exception = Assert.Throws<Exception>(() =>
            {
                foreach (A_BadCustomer o in customers)
                {
                    o.AddSaleToDatabase("Shoes", 100.00M);
                }
            });

            //Assert
            Assert.Equal("Not Allowed!", exception.Message);

        }
    }
}
