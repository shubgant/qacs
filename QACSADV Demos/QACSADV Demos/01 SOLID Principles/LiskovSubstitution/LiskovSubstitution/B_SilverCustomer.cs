using System;

namespace LiskovSubstitution
{
    public class B_SilverCustomer : B_GoodCustomer
    {
        public B_SilverCustomer(FileLogger logger):base(logger)
        {

        }

        public override decimal GetDiscountedPrice(decimal price)
        {
            return price - (price * 5 / 100);

        }

    }
}
