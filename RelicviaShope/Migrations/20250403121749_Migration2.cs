using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelicviaShope.Migrations;

/// <inheritdoc />
public partial class Migration2 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Tovars",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Tovars", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Users",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                Inn = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Users", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "ShopingCards",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                UserId = table.Column<int>(type: "int", nullable: false),
                TovarId = table.Column<int>(type: "int", nullable: false),
                Quantity = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ShopingCards", x => x.Id);
                table.ForeignKey(
                    name: "FK_ShopingCards_Tovars_TovarId",
                    column: x => x.TovarId,
                    principalTable: "Tovars",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ShopingCards_Users_UserId",
                    column: x => x.UserId,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_ShopingCards_TovarId",
            table: "ShopingCards",
            column: "TovarId");

        migrationBuilder.CreateIndex(
            name: "IX_ShopingCards_UserId",
            table: "ShopingCards",
            column: "UserId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "ShopingCards");

        migrationBuilder.DropTable(
            name: "Tovars");

        migrationBuilder.DropTable(
            name: "Users");
    }
}
