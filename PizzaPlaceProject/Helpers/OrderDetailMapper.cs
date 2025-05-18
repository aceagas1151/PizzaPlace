using CsvHelper.Configuration;
using PizzaPlaceProject.Entities;

public class OrderDetailMapper : ClassMap<OrderDetail>
{
    public OrderDetailMapper()
    {
        Map(m => m.Id).Name("order_details_id");
        Map(m => m.OrderId).Name("order_id");
        Map(m => m.PizzaId).Name("pizza_id");
        Map(m => m.Quantity).Name("quantity");
    }
}