using StockValueCalculator;

namespace StockValueCalculatorTests
{
    public class InventoryTests
    {
        [Fact]
        public void TestTotalStockValue()
        {
            //Arrange
            decimal expectedTotalStockValue = 113.16m;

            //Act
            Inventory inventory = new Inventory();

            IProduct book1 = new Book("Hard Ground", "Tom Waits", 184, 8.99m);
            IProduct cd1 = new CD("Blood Money", "Tom Waits", 13, 9.99m);
            IProduct book2 = new Book("The World's Greatest Books", "John Bramwell", 1254, 84.99m);
            IProduct cd2 = new CD("Sky at Night", "I am Kloot", 12, 5.99m);

            inventory.AddProduct(book1);
            inventory.AddProduct(cd1);
            inventory.AddProduct(book2);
            inventory.AddProduct(cd2);

            //Assert
            Assert.Equal(expectedTotalStockValue, inventory.TotalStockValue);

        }
    }
}