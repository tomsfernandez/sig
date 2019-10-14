using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddMerchandiseInsurance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MerchandiseInsurance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PolicyNumber = table.Column<int>(nullable: false),
                    CoverageType = table.Column<string>(nullable: true),
                    SafetyMeasures = table.Column<string>(nullable: true),
                    InsuredMerchandise = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    InsuranceBusinessName = table.Column<string>(nullable: true),
                    RemittanceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchandiseInsurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MerchandiseInsurance_Remittance_RemittanceId",
                        column: x => x.RemittanceId,
                        principalTable: "Remittance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MerchandiseInsurance_RemittanceId",
                table: "MerchandiseInsurance",
                column: "RemittanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MerchandiseInsurance");
        }
    }
}
