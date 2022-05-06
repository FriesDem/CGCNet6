using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGC.webapp.Data.Migrations
{
    public partial class Updatedcontent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bad4ac6e-c6d3-42ac-b3be-dabbaaec6769",
                column: "ConcurrencyStamp",
                value: "377c0125-91d8-4f54-958a-e9c9a929726a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfc6ac6b-b6d4-42dc-b6ae-dabbaeed6969",
                column: "ConcurrencyStamp",
                value: "2689df99-58b3-417b-be6d-1e854a73cf4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa2bb1c-a7a4-56bc-d6ba-baaeff4d5479",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5c7dd5d-254b-4754-a64a-dba6c61a2b8a", "AQAAAAEAACcQAAAAEC+l0ui/Bog5ocYbMsV/rN8HnnMbiRENyLQ9xpJWXHHG1XlZRZ9DfQPlGBYiLpuLbQ==", "b4ab2d94-75fd-40ac-aa6d-0a97c3806fbc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
