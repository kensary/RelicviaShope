using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelicviaShope.Migrations;

/// <inheritdoc />
public partial class Migration3 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Discriminator",
            table: "Users");

        migrationBuilder.DropColumn(
            name: "Inn",
            table: "Users");

        migrationBuilder.CreateTable(
            name: "Admins",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Admins", x => x.Id);
                table.ForeignKey(
                    name: "FK_Admins_Users_Id",
                    column: x => x.Id,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Traders",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false),
                Inn = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Traders", x => x.Id);
                table.ForeignKey(
                    name: "FK_Traders_Users_Id",
                    column: x => x.Id,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Admins");

        migrationBuilder.DropTable(
            name: "Traders");

        migrationBuilder.AddColumn<string>(
            name: "Discriminator",
            table: "Users",
            type: "nvarchar(8)",
            maxLength: 8,
            nullable: false,
            defaultValue: "");

        migrationBuilder.AddColumn<string>(
            name: "Inn",
            table: "Users",
            type: "nvarchar(max)",
            nullable: true);
    }
}
