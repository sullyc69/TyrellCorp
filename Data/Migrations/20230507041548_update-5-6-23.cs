using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class update5623 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Replicants",
                columns: new[] { "Id", "FactoryId", "FunctionIds", "Image", "InceptDate", "MentalAbility", "Name", "NexusModel", "PhysicalAbility", "RetirementDate", "Sex" },
                values: new object[] { 2, 2, null, null, new DateTime(1963, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medium", "Ginger", 2, "Weak", null, "Female" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Replicants",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
