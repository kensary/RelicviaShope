using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RelicviaShope.Migrations;

/// <inheritdoc />
public partial class Migration4 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "Tovars",
            columns: new[] { "Id", "Description", "Name", "Price" },
            values: new object[,]
            {
                { 1001, "Описание товара 1", "Товар 1", 1000m },
                { 19991, "Описание товара 2", "Товар 2", 1000000m }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "Tovars",
            keyColumn: "Id",
            keyValue: 1001);

        migrationBuilder.DeleteData(
            table: "Tovars",
            keyColumn: "Id",
            keyValue: 19991);
    }
}
