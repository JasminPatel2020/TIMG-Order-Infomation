using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderInfo.Models
{
    public class OrderItemsVM
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Gst { get; set; }
        public decimal Total { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
