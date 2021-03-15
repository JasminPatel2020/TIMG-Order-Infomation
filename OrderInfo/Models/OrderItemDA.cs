using System.Collections.Generic;
using System.Linq;

namespace OrderInfo.Models
{
    public class OrderItemDA
    {
        OrderItemContext dbc = new OrderItemContext();

        internal IEnumerable<OrderItemsVM> GetOrderInfo()
        {
            try
            {
                 var query = dbc.Order
                            .Join(
                                dbc.OrderItem,
                                Order => Order.Id,
                                OrderItem => OrderItem.ParentOrder,
                                (Order, OrderItem) => new OrderItemsVM()
                                {
                                    ClientId = Order.ClientId,
                                    ClientName = Order.ClientName,
                                    OrderDate = Order.OrderDate,
                                    Gst = Order.Gst,
                                    Total = Order.Total,
                                    ProductCode = OrderItem.ProductCode,
                                    Quantity = OrderItem.Quantity,
                                    TotalPrice = OrderItem.TotalPrice
                                }
                            ).ToList();
                return query.ToList();
            }
            catch
            {
                throw;
            }
        }

        internal List<string> GetClientNames()
        {
            try
            {
                return dbc.Order.Select(u => u.ClientName).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
