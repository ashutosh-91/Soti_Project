using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class Surgery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surgery",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndTime = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SurgeryId = table.Column<int>(type: "int", nullable: false),
                    SurgeryCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurgeryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgery", x => x.DoctorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Surgery");
        }
    }
}
