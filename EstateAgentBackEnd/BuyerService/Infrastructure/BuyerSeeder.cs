using AutoFixture;
using BuyerService.Models;

namespace BuyerService.Infrastructure
{
    public static class BuyerSeeder
    {
        public static void Seed(this BuyerContext buyerContext)
        {
            if (!buyerContext.Buyers.Any())
            {
                Fixture fixture = new Fixture();
                fixture.Customize<Buyer>(buyer => buyer.Without(p => p.Id));

                List<Buyer> products = fixture.CreateMany<Buyer>(100).ToList();
                buyerContext.AddRange(products);
                buyerContext.SaveChanges();
            }
        }

    }
}
