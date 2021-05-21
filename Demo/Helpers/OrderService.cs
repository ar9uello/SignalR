using JugoDrinks.Models;
using System.Collections.Generic;
using System.Linq;

namespace JugoDrinks.Helpers
{
    public class OrderService
    {
        private static readonly List<Order> orders = new List<Order>();

        public Order Create(string JuicyType, string ClientName, string connectionId)
        {
            var id = orders.Count() == 0 ? 1 : orders.Max(x => x.Id) + 1;
            var order = new Order() { Id = id, JuicyType = JuicyType, ClientName = ClientName, ConnectionId = connectionId };
            orders.Add(order);
            return order;
        }

        public Order GetLastOrder(int id)
        {
            var order = orders.FirstOrDefault(x => x.Id == id);
            return order;
        }


    }

}
