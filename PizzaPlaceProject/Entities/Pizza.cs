namespace PizzaPlaceProject.Entities
{
    public class Pizza
    {
        public required string Id { get; set; }
        public required string PizzaTypeId { get; set; }
        public required string Size { get; set; }
        public decimal Price { get; set; }
    }
}
