using DotNetCore.CAP;
using EventSubscriber.Models;

namespace EventSubscriber.EventSubscribers
{
    public class OrderPlacedEventSubscriber : ICapSubscribe
    {
        [CapSubscribe("OrderPlaced")]
        public async Task<IResult> Consumer(Order order)
        {
            //Handle the order placed event
            string orderText = $"Order No: {order.OrderId}, For CustomerId:{order.CustomerId}, ProductId: {order.ProductId}. Quantity={order.Quantity}, Order Date: {order.OrderDate}";
            Console.WriteLine(orderText);
            return Results.NoContent();
        }
    }

}
