using System;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Press a key to start listening..");
            //Console.ReadKey();

            var connection = new HubConnectionBuilder()
                .WithUrl("http://rarguello.somee.com/hub")
                .AddMessagePackProtocol()
                .Build();

            connection.StartAsync().GetAwaiter().GetResult();


            connection.InvokeAsync("JoinGroup", "CEO").Wait();

            connection.On<Order>("OrderReceived", (order) =>
            {               
                Console.WriteLine($"Order {order.Id}: Client {order.ClientName} ordered an {order.JuicyType}");
            });

            connection.On<Order>("SendJuice", (order) =>
            {
                Console.WriteLine($"Order {order.Id}: On the way");
            });

            connection.On<Order>("JuiceDelivered", (order) =>
            {
                Console.WriteLine($"Order {order.Id}: Delivered");
            });


            Console.WriteLine("Listening.");
            Console.ReadKey();
        }
    }
}
