using System;
using System.Collections.Generic;
using OpenClosedPrinciple;

namespace OpenClosedUnitTests
{
    public class OpenCloseTests
    {
        [Fact]
        public void GoldBadCustomerTest()
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            decimal expectedResult = 900.00m;

            //Act
            A_BadCustomer badCustomer = new A_BadCustomer();
            badCustomer.CustomerType = CustomerType.Gold;
            decimal discountedPrice = badCustomer.GetDiscountedPrice(originalPrice);

            //Assert
            Assert.Equal(expectedResult, discountedPrice);
        }

        [Fact]
        public void SilverBadCustomerTest()
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            decimal expectedResult = 950.00m;

            //Act
            A_BadCustomer badCustomer = new A_BadCustomer();
            badCustomer.CustomerType = CustomerType.Silver;
            decimal discountedPrice = badCustomer.GetDiscountedPrice(originalPrice);

            //Assert
            Assert.Equal(expectedResult, discountedPrice);
        }

        [Fact]
        public void GoldGoodCustomerTest()
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            decimal expectedResult = 900.00m;

            //Act
            B_GoodCustomer goodCustomer = new GoldCustomer();
            decimal discountedPrice = goodCustomer.GetDiscountedPrice(originalPrice);

            //Assert
            Assert.Equal(expectedResult, discountedPrice);
        }

        [Fact]
        public void SilverGoodCustomerTest()
        {
            //Arrange
            decimal originalPrice = 1000.00m;
            decimal expectedResult = 950.00m;

            //Act
            B_GoodCustomer goodCustomer = new SilverCustomer();
            decimal discountedPrice = goodCustomer.GetDiscountedPrice(originalPrice);

            Assert.Equal(expectedResult, discountedPrice);
        }

        [Fact]
        public void MixedGoodCustomersTest()
        {
            //Arrange
            B_GoodCustomer customer1 = new SilverCustomer();
            B_GoodCustomer customer2 = new GoldCustomer();
            B_GoodCustomer customer3 = new GoldCustomer();

            List<B_GoodCustomer> customers = new List<B_GoodCustomer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            decimal totalDiscountedPrices = 0m;
            decimal originalPrice = 1000.00m;
            decimal expectedDiscountedTotal = 2750.00m;

            //Act
            foreach (B_GoodCustomer customer in customers)
            {
                totalDiscountedPrices += customer.GetDiscountedPrice(originalPrice);
            }

            //Assert
            Assert.Equal(expectedDiscountedTotal, totalDiscountedPrices);
        }
    }
}
