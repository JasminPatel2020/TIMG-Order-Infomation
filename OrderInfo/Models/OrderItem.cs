using System;
using System.Collections.Generic;

namespace OrderInfo.Models
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int ParentOrder { get; set; }
    }
}
