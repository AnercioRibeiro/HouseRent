using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HouseRent_API.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tipology = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Elevator = table.Column<bool>(type: "bit", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PaymentPeriodicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Municipalities = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Address", "CreatedDate", "Description", "Details", "Division", "Elevator", "Floor", "Identifier", "ImageUrl", "Latitude", "Longitude", "Municipalities", "Name", "PaymentPeriodicy", "Price", "Tipology", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Projecto Nova vida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartamento T2", "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa", null, false, "3º Andar", "1234", "", "-8.8303705", "13.2779031", "Kilamba Kiaxi", "", "Mensal", 400000m, "T2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Projecto Nova vida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartamento T2", "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa", null, false, "3º Andar", "1234", "", "-8.8303705", "13.2779031", "Kilamba Kiaxi", "", "Mensal", 400000m, "T2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Projecto Nova vida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartamento T2", "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa", null, false, "3º Andar", "1234", "", "-8.8303705", "13.2779031", "Kilamba Kiaxi", "", "Mensal", 400000m, "T2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Projecto Nova vida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartamento T2", "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa", null, false, "3º Andar", "1234", "", "-8.8303705", "13.2779031", "Kilamba Kiaxi", "", "Mensal", 400000m, "T2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Projecto Nova vida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartamento T2", "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa", null, false, "3º Andar", "1234", "", "-8.8303705", "13.2779031", "Kilamba Kiaxi", "", "Mensal", 400000m, "T2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Projecto Nova vida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartamento T2", "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa", null, false, "3º Andar", "1234", "", "-8.8303705", "13.2779031", "Kilamba Kiaxi", "", "Mensal", 400000m, "T2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Projecto Nova vida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartamento T2", "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa", null, false, "3º Andar", "1234", "", "-8.8303705", "13.2779031", "Kilamba Kiaxi", "", "Mensal", 400000m, "T2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Projecto Nova vida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartamento T2", "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa", null, false, "3º Andar", "1234", "", "-8.8303705", "13.2779031", "Kilamba Kiaxi", "", "Mensal", 400000m, "T2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publications");
        }
    }
}
