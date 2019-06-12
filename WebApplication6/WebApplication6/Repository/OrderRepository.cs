using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;
using WebApplication6.TestData;

namespace WebApplication6.Repository
{
    public class OrderRepository : IRepository<Order>
    {
        private OrderData _orderData;
        public OrderRepository()
        {
            _orderData = new OrderData();
        }

        public List<Order> EntitiesList { get => _orderData.Orders().ToList(); set => _orderData.Orders(); }

        public void Add(Order order) => EntitiesList.Add(order);

        public void Delete(Order order) => EntitiesList.Remove(order);

        public IEnumerable<Order> Get() => EntitiesList;

        public Order GetById(int id) => EntitiesList.Single(x => x.Id == id);

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}