using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProjectHamburger.Migrations
{
    public partial class init31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserID",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "ExtraIngredients",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "72086d4a-673e-4da2-a3b9-f0009d670044");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "151c42f1-94f1-4dbc-accb-dc67b405ba53");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserID",
                table: "Orders",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserID",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppUserID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "42f26739-3de2-44a9-ad5d-21688a24d3ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ed30e97e-6d98-47d5-9379-d5f9b3718840");

            migrationBuilder.InsertData(
                table: "ExtraIngredients",
                columns: new[] { "ID", "CoverImage", "Name", "Price" },
                values: new object[] { 1, "bbq.jpg", "BBQ", 18 });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserID",
                table: "Orders",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
