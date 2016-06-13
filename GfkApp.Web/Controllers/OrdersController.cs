using GfkApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GfkApp.Web.Controllers
{
    public class OrdersController : ApiController
    {
        [Authorize]
        public List<Order> Get()
        {
            return Order.CreateOrders();
        }

    }
}
