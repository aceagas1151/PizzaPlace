namespace PizzaPlaceProject.Entities
{
    public class PizzaType
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string Category { get; set; }
        public required string Ingredients { get; set; }

        //public ICollection<Pizza> Pizzas { get; set; }
    }
}
