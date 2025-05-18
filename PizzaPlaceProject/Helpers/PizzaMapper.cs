using CsvHelper.Configuration;
using PizzaPlaceProject.Entities;

public class PizzaMapper : ClassMap<Pizza>
{
    public PizzaMapper()
    {
        Map(m => m.Id).Name("pizza_id");
        Map(m => m.PizzaTypeId).Name("pizza_type_id");
        Map(m => m.Size).Name("size");
        Map(m => m.Price).Name("price");
    }
}