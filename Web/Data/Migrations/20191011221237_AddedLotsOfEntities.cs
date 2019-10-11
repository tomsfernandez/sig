using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddedLotsOfEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    StreetHeight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dock",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Occupied = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrailerInsurance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PolicyNumber = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    InsuranceBusinessName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerInsurance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleInsurance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PolicyNumber = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    InsuranceBusinessName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleInsurance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseLocation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Section = table.Column<string>(nullable: true),
                    Aisle = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusinessName = table.Column<string>(nullable: true),
                    Cuit = table.Column<string>(nullable: true),
                    AddressId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trailer",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LicensePlate = table.Column<string>(nullable: true),
                    TrailerInsuranceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trailer_TrailerInsurance_TrailerInsuranceId",
                        column: x => x.TrailerInsuranceId,
                        principalTable: "TrailerInsurance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    LicensePlate = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    VehicleInsuranceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleInsurance_VehicleInsuranceId",
                        column: x => x.VehicleInsuranceId,
                        principalTable: "VehicleInsurance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Remittance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false),
                    DeliveryType = table.Column<string>(nullable: true),
                    ClientId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remittance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remittance_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverPermit",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleId = table.Column<long>(nullable: false),
                    DriverId = table.Column<long>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverPermit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverPermit_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverPermit_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RTO",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleId = table.Column<long>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CertifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RTO_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RUTA",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleId = table.Column<long>(nullable: false),
                    ClientId = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUTA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RUTA_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RUTA_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Merchandise",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    ExternCode = table.Column<string>(nullable: true),
                    TotalBoxes = table.Column<int>(nullable: false),
                    BoxHeight = table.Column<double>(nullable: false),
                    BoxWidth = table.Column<double>(nullable: false),
                    BoxLength = table.Column<double>(nullable: false),
                    BoxWeight = table.Column<double>(nullable: false),
                    RemittanceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Merchandise_Remittance_RemittanceId",
                        column: x => x.RemittanceId,
                        principalTable: "Remittance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_AddressId",
                table: "Client",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverPermit_DriverId",
                table: "DriverPermit",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverPermit_VehicleId",
                table: "DriverPermit",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Merchandise_RemittanceId",
                table: "Merchandise",
                column: "RemittanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Remittance_ClientId",
                table: "Remittance",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_RTO_VehicleId",
                table: "RTO",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RUTA_ClientId",
                table: "RUTA",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_RUTA_VehicleId",
                table: "RUTA",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_TrailerInsuranceId",
                table: "Trailer",
                column: "TrailerInsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleInsuranceId",
                table: "Vehicle",
                column: "VehicleInsuranceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dock");

            migrationBuilder.DropTable(
                name: "DriverPermit");

            migrationBuilder.DropTable(
                name: "Merchandise");

            migrationBuilder.DropTable(
                name: "RTO");

            migrationBuilder.DropTable(
                name: "RUTA");

            migrationBuilder.DropTable(
                name: "Trailer");

            migrationBuilder.DropTable(
                name: "WarehouseLocation");

            migrationBuilder.DropTable(
                name: "Remittance");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "TrailerInsurance");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "VehicleInsurance");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
