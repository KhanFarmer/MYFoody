using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Foody.DataAccessLayer.Migrations
{
    public partial class addressMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdressDetail",
                table: "Adresses",
                newName: "AddressDetail");

            migrationBuilder.RenameColumn(
                name: "AdressId",
                table: "Adresses",
                newName: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressDetail",
                table: "Adresses",
                newName: "AdressDetail");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Adresses",
                newName: "AdressId");
        }
    }
}
