using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGC.webapp.Data.Migrations
{
    public partial class UpdatedMigrationtabs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bad4ac6e-c6d3-42ac-b3be-dabbaaec6769",
                column: "ConcurrencyStamp",
                value: "7ba290ea-a0e6-4d16-8cb9-ef1bc04cdba9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfc6ac6b-b6d4-42dc-b6ae-dabbaeed6969",
                column: "ConcurrencyStamp",
                value: "791b7180-ab6a-488d-a051-ee0f93ec5f6e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa2bb1c-a7a4-56bc-d6ba-baaeff4d5479",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54c7d9e4-9b9e-4816-88dd-ea5c20719291", "AQAAAAEAACcQAAAAENhe9QypLiYC7+bBDteXBWHvjFNQUe2E4yDYVfxkZ6oafeyuplnAkXnczZqs58e15Q==", "f57a86e8-718d-493a-a301-e5e4f5aecd39" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bad4ac6e-c6d3-42ac-b3be-dabbaaec6769",
                column: "ConcurrencyStamp",
                value: "c24164b9-a788-4fcd-b2ec-edff4cad548c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfc6ac6b-b6d4-42dc-b6ae-dabbaeed6969",
                column: "ConcurrencyStamp",
                value: "e80bea7a-5c8b-4625-9d5c-33e9c9bc2bfe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa2bb1c-a7a4-56bc-d6ba-baaeff4d5479",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05513030-9d6a-4268-a786-281a05ee04be", "AQAAAAEAACcQAAAAEN4FNV3gkug3sQ/F2poPC2xGxAjJOzIQbMgCtTX6O/pdVsfv6Go1VEuCsgx//XKnIQ==", "7c0b2dd7-2468-49e0-b16b-b64865e792d0" });
        }
    }
}
