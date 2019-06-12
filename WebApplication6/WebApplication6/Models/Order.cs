using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<int> BookId { get; set; }
        public int UserId { get; set; }
        public decimal Cost { get; set; }
    }
}