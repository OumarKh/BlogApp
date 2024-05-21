using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class AddingModelsauthtoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab1ed398-a464-4beb-a726-08e3bf3c35c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3a67a2a-d1ed-4184-93bc-45c52bea9172", "AQAAAAIAAYagAAAAEPZGt3vVTcCqfhuRW9AVMh/l0fJc2qHiQXPmI/oIesavgsvCuJ8j+lnJ6wyUJWNlpA==", "533a95eb-64af-4e07-934c-b58b70b80fdb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab1ed398-a464-4beb-a726-08e3bf3c35c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "419f0c0b-2cd5-4b3a-b1f8-b48b9da88858", "AQAAAAIAAYagAAAAEPRTyhc3G+aEiePn0odwXP+nZQSjFccgI3i4WMDjZ5XnS50JDbaaOxPEiUNXM9BQKw==", "c3dcf4c1-8854-4473-a214-86fec37af13a" });
        }
    }
}
