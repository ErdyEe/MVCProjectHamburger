using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProjectHamburger.Migrations
{
    public partial class changetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuExtraIngredients");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuExtraIngredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraIngredientID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuExtraIngredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuExtraIngredients_ExtraIngredients_ExtraIngredientID",
                        column: x => x.ExtraIngredientID,
                        principalTable: "ExtraIngredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuExtraIngredients_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0c2b3fed-0654-4e2b-834b-04d48e00f286");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c5590883-5e7b-4d1f-b359-1bab91c1039e");

            migrationBuilder.CreateIndex(
                name: "IX_MenuExtraIngredients_ExtraIngredientID",
                table: "MenuExtraIngredients",
                column: "ExtraIngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuExtraIngredients_MenuID",
                table: "MenuExtraIngredients",
                column: "MenuID");
        }
    }
}
