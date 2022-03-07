using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Education.Persistence.Migrations
{
    public partial class EducationMigrationsInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CreationDate", "Description", "Precio", "PublicationDate", "Title" },
                values: new object[] { new Guid("66344d40-c88e-4c44-a6ef-2a07c161bbca"), new DateTime(2022, 3, 6, 22, 22, 49, 676, DateTimeKind.Local).AddTicks(892), "C basico", 56m, new DateTime(2024, 3, 6, 22, 22, 49, 677, DateTimeKind.Local).AddTicks(7856), "C title" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CreationDate", "Description", "Precio", "PublicationDate", "Title" },
                values: new object[] { new Guid("1cc49d88-b0c3-442c-a87e-a2b5e38ddfdc"), new DateTime(2022, 3, 6, 22, 22, 49, 679, DateTimeKind.Local).AddTicks(9783), "C avanzado", 80m, new DateTime(2024, 3, 6, 22, 22, 49, 679, DateTimeKind.Local).AddTicks(9839), "C title-avanzado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
