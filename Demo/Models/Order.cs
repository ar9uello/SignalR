namespace JugoDrinks.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string JuicyType { get; set; }
        public string ClientName { get; set; }
        public string ConnectionId { get; set; }
    }
}
