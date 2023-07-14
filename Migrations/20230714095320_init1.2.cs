using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProjectHamburger.Migrations
{
    public partial class init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuSize",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "MenuSize",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "16a98230-5875-43eb-b289-1acaa73452f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e59839c9-ed90-4b36-9649-824492eb78db");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuSize",
                table: "Menus");

            migrationBuilder.AddColumn<int>(
                name: "MenuSize",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3e0a5853-b916-44fb-9fbb-385180ce4da5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "281a36b6-ae82-4f31-8fff-cc22b7abdc24");
        }
    }
}
