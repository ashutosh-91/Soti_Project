using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class NewTableCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorSpecialization",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    SpecializationCode = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    SpecializationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecialization", x => new { x.DoctorId, x.SpecializationCode });
                    table.ForeignKey(
                        name: "FK_DoctorSpecialization_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorSpecialization_Specializations_SpecializationCode",
                        column: x => x.SpecializationCode,
                        principalTable: "Specializations",
                        principalColumn: "SpecializationCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Surgery",
                columns: table => new
                {
                    SurgeryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "5000, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    EndTime = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    StartTime = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    SurgeryCategory = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    SurgeryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgery", x => x.SurgeryId);
                    table.ForeignKey(
                        name: "FK_Surgery_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId");
                    table.ForeignKey(
                        name: "FK_Surgery_Specializations_SurgeryCategory",
                        column: x => x.SurgeryCategory,
                        principalTable: "Specializations",
                        principalColumn: "SpecializationCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpecialization_SpecializationCode",
                table: "DoctorSpecialization",
                column: "SpecializationCode");

            migrationBuilder.CreateIndex(
                name: "IX_Surgery_DoctorId",
                table: "Surgery",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgery_SurgeryCategory",
                table: "Surgery",
                column: "SurgeryCategory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorSpecialization");

            migrationBuilder.DropTable(
                name: "Surgery");
        }
    }
}
