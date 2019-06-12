using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.TestData
{
    public class OrderData
    {
        public IEnumerable<Order> Orders() => new List<Order>
        {
            new Order{Id=1,BookId=new List<int>{1,2,3},UserId=1},
            new Order{Id=2,BookId=new List<int>{1,5,7,8},UserId=2},
        };
    }
}