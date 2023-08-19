using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRent_API.Migrations
{
    /// <inheritdoc />
    public partial class ChangePublicationPropertyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Properties_PublicationId",
                table: "Publications");

            migrationBuilder.RenameColumn(
                name: "PublicationId",
                table: "Publications",
                newName: "PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Publications_PublicationId",
                table: "Publications",
                newName: "IX_Publications_PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Properties_PropertyId",
                table: "Publications",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Properties_PropertyId",
                table: "Publications");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "Publications",
                newName: "PublicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Publications_PropertyId",
                table: "Publications",
                newName: "IX_Publications_PublicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Properties_PublicationId",
                table: "Publications",
                column: "PublicationId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
