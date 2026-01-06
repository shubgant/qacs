using System;

namespace LiskovSubstitution
{
    public class B_GoldCustomer : B_GoodCustomer
    {
        public B_GoldCustomer(FileLogger logger):base(logger)
        {
            
        }

        public override decimal GetDiscountedPrice(decimal price)
        {
            return price - (price * 10 / 100);
        }

    }
}
