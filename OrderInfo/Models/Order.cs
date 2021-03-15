using System;
using System.Collections.Generic;

namespace OrderInfo.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Gst { get; set; }
        public decimal Total { get; set; }
    }
}
