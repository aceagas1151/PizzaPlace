namespace PizzaPlaceProject.Entities
{
    public class Order
    {
        public required int Id { get; set; }
        public required DateTime OrderDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
