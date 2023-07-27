using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HouseRent_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedPublicationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
