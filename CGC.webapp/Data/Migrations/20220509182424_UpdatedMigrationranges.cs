using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGC.webapp.Data.Migrations
{
    public partial class UpdatedMigrationranges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bad4ac6e-c6d3-42ac-b3be-dabbaaec6769",
                column: "ConcurrencyStamp",
                value: "bd3f65a1-a1b0-404e-814a-daa986cf78c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfc6ac6b-b6d4-42dc-b6ae-dabbaeed6969",
                column: "ConcurrencyStamp",
                value: "7ff65ab0-b6bc-4800-b7a2-468d4a61c366");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa2bb1c-a7a4-56bc-d6ba-baaeff4d5479",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fff01630-e2d8-4dc3-a296-bc900ac42e09", "AQAAAAEAACcQAAAAEIQWKiUS7R9k28ZGY6oN6AssodZYbLn0b4GVfSlRPnn8srByVlYJ6iY+3XsEjSA2HA==", "affa9917-9dfa-43cb-b89f-8c2c8a6b3195" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
