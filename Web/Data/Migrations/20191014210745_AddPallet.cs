using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddPallet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pallet",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AmountOfBoxes = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    EntryTimestamp = table.Column<DateTime>(nullable: false),
                    ExitTimestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    WarehouseLocationId = table.Column<long>(nullable: true),
                    MerchandiseId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pallet_Merchandise_MerchandiseId",
                        column: x => x.MerchandiseId,
                        principalTable: "Merchandise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pallet_WarehouseLocation_WarehouseLocationId",
                        column: x => x.WarehouseLocationId,
                        principalTable: "WarehouseLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pallet_MerchandiseId",
                table: "Pallet",
                column: "MerchandiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Pallet_WarehouseLocationId",
                table: "Pallet",
                column: "WarehouseLocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pallet");
        }
    }
}
