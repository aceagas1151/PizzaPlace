using Microsoft.EntityFrameworkCore;
using PizzaPlaceProject.Entities;

namespace PizzaPlaceProject.Data
{
    public class PizzaPlaceDbContext : DbContext
    {
        public PizzaPlaceDbContext(DbContextOptions<PizzaPlaceDbContext> options)
           : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaType> PizzaTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Order has many OrderDetails
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId);

            // PizzaType has many Pizzas
            modelBuilder.Entity<PizzaType>()
                .HasMany(pt => pt.Pizzas)
                .WithOne(p => p.PizzaType)
                .HasForeignKey(p => p.PizzaTypeId);

            // Pizza has many OrderDetails
            modelBuilder.Entity<Pizza>()
                .HasMany(p => p.OrderDetails)
                .WithOne(od => od.Pizza)
                .HasForeignKey(od => od.PizzaId);
        }
    }
}
