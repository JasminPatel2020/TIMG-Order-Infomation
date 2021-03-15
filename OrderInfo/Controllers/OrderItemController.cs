using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderInfo.Models;

namespace OrderInfo.Controllers
{
    //[Produces("application/json")]
    //[Route("api/OrderItem")]
    public class OrderItemController : Controller
    {
        OrderItemDA objOI = new OrderItemDA();

        [HttpGet]
        [Route("api/OrderItem/Index")]
        public IEnumerable<OrderItemsVM> Index()
        {
            return objOI.GetOrderInfo();
        }

        [HttpGet("action")]
        [Route("api/OrderItem/ClientNames")]
        public List<string> GetClientNames()
        {
            return objOI.GetClientNames();
        }
    }
}