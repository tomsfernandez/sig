using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entry",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntryDate = table.Column<DateTime>(nullable: true),
                    ExitDate = table.Column<DateTime>(nullable: true),
                    RemittanceId = table.Column<long>(nullable: false),
                    DriverId = table.Column<long>(nullable: false),
                    VehicleId = table.Column<long>(nullable: false),
                    TrailerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entry_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entry_Remittance_RemittanceId",
                        column: x => x.RemittanceId,
                        principalTable: "Remittance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entry_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entry_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entry_DriverId",
                table: "Entry",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_RemittanceId",
                table: "Entry",
                column: "RemittanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_TrailerId",
                table: "Entry",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_VehicleId",
                table: "Entry",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entry");
        }
    }
}
