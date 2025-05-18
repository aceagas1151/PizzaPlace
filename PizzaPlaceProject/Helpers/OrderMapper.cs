using CsvHelper.Configuration;
using PizzaPlaceProject.Entities;

public class OrderMapper : ClassMap<Order>
{
    public OrderMapper()
    {
        Map(m => m.Id).Name("order_id");
        Map(m => m.OrderDate).Convert(row =>
        {
            var date = row.Row.GetField("date");
            var time = row.Row.GetField("time");
            return DateTime.Parse($"{date} {time}");
        });
    }
}