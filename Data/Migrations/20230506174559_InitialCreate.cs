using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Functionality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NexusModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NexusModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Replicants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    NexusModel = table.Column<int>(type: "int", nullable: true),
                    InceptDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FunctionIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalAbility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MentalAbility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetirementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Replicants_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Replicants_NexusModel_NexusModel",
                        column: x => x.NexusModel,
                        principalTable: "NexusModel",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Factories",
                columns: new[] { "Id", "Description", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Micro Gravity Assembly Plant", "Earth Orbit", "Earth Orbital Replicants" },
                    { 2, "Low Gravity Assembly Plant", "Titan", "Off World Replicants" },
                    { 3, "Full Gravity Assembly Plant", "Los Angeles, Earth", "LA Replicants" }
                });

            migrationBuilder.InsertData(
                table: "Functions",
                columns: new[] { "Id", "Functionality" },
                values: new object[,]
                {
                    { 1, "Pleasure" },
                    { 2, "Military" },
                    { 3, "Loader, (nuc)" },
                    { 4, "Combat" },
                    { 5, "Leisure" },
                    { 6, "Assasination" },
                    { 7, "Janitorial" },
                    { 8, "Construction" }
                });

            migrationBuilder.InsertData(
                table: "NexusModel",
                columns: new[] { "Id", "ModelDescription" },
                values: new object[,]
                {
                    { 1, "Nexus 1" },
                    { 2, "Nexus 2" },
                    { 3, "Nexus 3" },
                    { 4, "Nexus 4" },
                    { 5, "Nexus 5" },
                    { 6, "Nexus 6" },
                    { 7, "Nexus 7" },
                    { 8, "Nexus 8" }
                });

            migrationBuilder.InsertData(
                table: "Replicants",
                columns: new[] { "Id", "FactoryId", "FunctionIds", "Image", "InceptDate", "MentalAbility", "Name", "NexusModel", "PhysicalAbility", "RetirementDate", "Sex" },
                values: new object[] { 1, 1, null, null, new DateTime(1963, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stupid", "Gilligan", 1, "Weak", null, "Male" });

            migrationBuilder.CreateIndex(
                name: "IX_Replicants_FactoryId",
                table: "Replicants",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Replicants_NexusModel",
                table: "Replicants",
                column: "NexusModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "Replicants");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "NexusModel");
        }
    }
}
