using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using JugoDrinks.Helpers;

namespace JugoDrinks.Hubs
{
    public class OrderHub : Hub
    {
        private readonly OrderService _orderService;

        public OrderHub(OrderService orderService)
        {
            _orderService = orderService;
        }

        public Task JoinGroup(string group)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, group);
        }

        public async Task NewOrder(string JuicyType, string ClientName)
        {
            var order = _orderService.Create(JuicyType, ClientName, Context.ConnectionId);
            await Clients.Caller.SendAsync("OrderReceived", order);
            await Clients.Group("CEO").SendAsync("OrderReceived", order);
            if (order.JuicyType.Contains("Apple"))
                await Clients.Group("AppleCorp").SendAsync("OrderReceived", order);
            else
                await Clients.Group("OrangeCorp").SendAsync("OrderReceived", order);
        }

        public async Task SendJuice(int id)
        {
            var order = _orderService.GetLastOrder(id);
            await Clients.Client(order.ConnectionId).SendAsync("SendJuice", order);
            await Clients.Group("CEO").SendAsync("SendJuice", order);
            await Clients.Group("Transport").SendAsync("SendJuice", order);
        }

        public async Task JuiceDelivered(int id)
        {
            var order = _orderService.GetLastOrder(id);
            await Clients.Client(order.ConnectionId).SendAsync("JuiceDelivered", order);
            await Clients.Group("CEO").SendAsync("JuiceDelivered", order);
        }

    }
}
