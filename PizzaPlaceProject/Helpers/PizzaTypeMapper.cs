using CsvHelper.Configuration;
using PizzaPlaceProject.Entities;

public class PizzaTypeMapper : ClassMap<PizzaType>
{
    public PizzaTypeMapper()
    {
        Map(m => m.Id).Name("pizza_type_id");
        Map(m => m.Name).Name("name");
        Map(m => m.Category).Name("category");
        Map(m => m.Ingredients).Name("ingredients");
    }
}
