using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaPlaceProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pizzas_PizzaId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_PizzaTypes_PizzaTypeId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_PizzaTypeId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_PizzaId",
                table: "OrderDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_PizzaTypeId",
                table: "Pizzas",
                column: "PizzaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PizzaId",
                table: "OrderDetails",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pizzas_PizzaId",
                table: "OrderDetails",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_PizzaTypes_PizzaTypeId",
                table: "Pizzas",
                column: "PizzaTypeId",
                principalTable: "PizzaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
