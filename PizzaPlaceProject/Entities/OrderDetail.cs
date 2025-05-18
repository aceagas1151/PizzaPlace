namespace PizzaPlaceProject.Entities
{
    public class OrderDetail
    {
        public required int Id { get; set; }
        public required int OrderId { get; set; }
        public required string PizzaId { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Pizza Pizza { get; set; }
    }
}
