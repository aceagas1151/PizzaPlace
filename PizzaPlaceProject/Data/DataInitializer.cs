using CsvHelper;
using CsvHelper.Configuration;
using PizzaPlaceProject.Entities;
using System.Formats.Asn1;
using System.Globalization;
using PizzaPlaceProject.Data;

public static class DataInitializer
{
    public static void SeedDatabase(PizzaPlaceDbContext context)
    {
        if (!context.PizzaTypes.Any())
        {
            var pizzaTypes = LoadCsv<PizzaType>("Data/Sample Data/pizza_types.csv", new PizzaTypeMapper());
            context.PizzaTypes.AddRange(pizzaTypes);
        }

        if (!context.Pizzas.Any())
        {
            var pizzas = LoadCsv<Pizza>("Data/Sample Data/pizzas.csv", new PizzaMapper());
            context.Pizzas.AddRange(pizzas);
        }

        if (!context.Orders.Any())
        {
            var orders = LoadCsv<Order>("Data/Sample Data/orders.csv", new OrderMapper());
            context.Orders.AddRange(orders);
        }

        if (!context.OrderDetails.Any())
        {
            var orderDetails = LoadCsv<OrderDetail>("Data/Sample Data/order_details.csv", new OrderDetailMapper());
            context.OrderDetails.AddRange(orderDetails);
        }

        context.SaveChanges();
    }

    private static List<T> LoadCsv<T>(string path, ClassMap<T> map)
    {
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null,
            MissingFieldFound = null
        });

        csv.Context.RegisterClassMap(map);
        return csv.GetRecords<T>().ToList();
    }
}
