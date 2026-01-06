using EFFromDatabase.Models;
using Microsoft.EntityFrameworkCore;

//using (NorthwindContext ctx = new NorthwindContext())
//{
//    foreach (Customer c in ctx.Customers
//                                .Include(c => c.Orders)
//                                .ThenInclude(o => o.OrderDetails)
//                                .ThenInclude(od => od.Product))
//    {
//        Console.WriteLine(c.ContactName);
//        foreach (Order o in c.Orders)
//        {
//            Console.WriteLine("..." + o.OrderId);
//            foreach (OrderDetail od in o.OrderDetails)
//            {
//                Console.WriteLine("......" + od.Product.ProductName);
//            }
//        }
//    }
//}

//using (NorthwindContext ctx = new NorthwindContext())
//{
//    var discontinued = ctx.Products.Where(p => p.Discontinued).IgnoreQueryFilters().ToList();
//    discontinued.ForEach(d => Console.WriteLine(d.ProductName));
//}

using (NorthwindContext ctx = new NorthwindContext())
{
    Product chang = ctx.Products
                          .Where(p => p.ProductName == "Chang").Single();
    Console.WriteLine(
       $"Unitprice={chang.UnitPrice} unitInStock={chang.UnitsInStock}");

    decimal? offerPrice = chang.UnitPrice;
    if (chang.UnitsInStock < 5 && chang.Discontinued)
    {
        offerPrice /= 2;
    }
    Console.WriteLine($"Offer price = {chang.OfferPrice}");
}



