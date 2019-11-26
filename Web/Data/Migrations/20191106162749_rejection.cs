using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Web.Models.Domain;

namespace Web.Data.Migrations
{
    public partial class rejection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RejectionReason",
                table: "Entry", 
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Traceytown", "United Arab Emirates", "Luella Track", "45468" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Rosenbaumburgh", "Lebanon", "Hessel Pine", "3230" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Vivianton", "Burundi", "Kuhlman Station", "488" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "North Marianneville", "Qatar", "Isac Orchard", "969" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Lake Ellieborough", "Trinidad and Tobago", "Anya Prairie", "5989" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "South Alvenastad", "Palestinian Territory", "Kozey Corner", "625" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Port Stephon", "Central African Republic", "Parker Cliffs", "729" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "South Gersonborough", "Liechtenstein", "Julian Path", "27238" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "North Cliffordhaven", "Saint Pierre and Miquelon", "Kihn Mill", "691" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Saraihaven", "Turkmenistan", "Caitlyn Prairie", "48151" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Bartell - Breitenberg", "29160167" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Muller Group", "45648427" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Schumm - Raynor", "22662460" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Kertzmann, Blanda and White", "34347744" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Maggio, Gibson and Schulist", "32157437" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Terry and Sons", "53803436" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Kuvalis - Price", "65901205" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Price Group", "62448345" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Rice, Farrell and Luettgen", "31471534" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Gusikowski - Carroll", "10518212" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "106.120.104.74", "Buckridge", "Grayson" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "210.88.219.113", "Weber", "Charlene" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "14.171.209.70", "Grady", "Bud" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "91.131.84.9", "Monahan", "Natasha" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "163.102.164.125", "Trantow", "Claude" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "60.8.23.84", "Gleason", "Edgar" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "209.67.240.21", "Johnston", "Linnie" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "63.21.56.126", "Kirlin", "Delaney" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "95.201.107.232", "Runte", "Jaylan" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "198.96.185.204", "Zulauf", "Madelyn" });

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 20, 20, 40, 21, 436, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 31, 14, 18, 37, 833, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 13, 16, 11, 23, 796, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 28, 9, 42, 43, 69, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2020, 2, 5, 4, 16, 28, 319, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2020, 2, 24, 2, 3, 5, 67, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 5, 5, 42, 49, 454, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 31, 17, 37, 31, 21, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 20, 7, 55, 33, 411, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 28, 18, 55, 37, 112, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 25, 2, 37, 6, 817, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2019, 11, 29, 21, 39, 31, 319, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 19, 22, 44, 52, 179, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2019, 11, 15, 20, 30, 50, 616, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 16, 0, 9, 1, 349, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2020, 2, 21, 2, 27, 53, 599, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2019, 11, 30, 10, 26, 34, 211, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 19, 2, 24, 6, 68, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 27, 21, 51, 35, 808, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 21, 2, 39, 42, 990, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LicensePlate",
                value: "16358-7422");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LicensePlate",
                value: "96483-1254");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LicensePlate",
                value: "11610-0508");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4L,
                column: "LicensePlate",
                value: "69841");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5L,
                column: "LicensePlate",
                value: "47816-7470");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6L,
                column: "LicensePlate",
                value: "29663");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7L,
                column: "LicensePlate",
                value: "66499-1472");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8L,
                column: "LicensePlate",
                value: "30198");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9L,
                column: "LicensePlate",
                value: "63747-3237");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10L,
                column: "LicensePlate",
                value: "10853-1973");

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 7, 23, 16, 7, 440, DateTimeKind.Local).AddTicks(4521), "Leuschke Group", 96512043 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 7, 19, 58, 30, 67, DateTimeKind.Local).AddTicks(599), "Gorczany - Leuschke", 33517780 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 24, 14, 44, 48, 695, DateTimeKind.Local).AddTicks(5754), "Ledner Inc", 16571426 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 13, 22, 18, 46, 757, DateTimeKind.Local).AddTicks(899), "Kilback, Glover and Block", 11828204 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 2, 5, 57, 8, 493, DateTimeKind.Local).AddTicks(9385), "Weber - Moore", 82703424 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 10, 8, 18, 33, 297, DateTimeKind.Local).AddTicks(3430), "Gusikowski - Boyer", 58549988 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 10, 9, 40, 13, 228, DateTimeKind.Local).AddTicks(6222), "Bosco - Feeney", 13349622 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 4, 5, 44, 59, 38, DateTimeKind.Local).AddTicks(3189), "Jast Group", 57533971 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 11, 8, 20, 47, 18, 863, DateTimeKind.Local).AddTicks(9183), "Waters - Satterfield", 73337188 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 8, 12, 2, 41, 191, DateTimeKind.Local).AddTicks(5310), "Little - Lebsack", 40478562 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Mercedes Benz", "55960-6455", "El Camino", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Hyandai", "15533-5349", "F-150", "Minivan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Land Rover", "04069-0586", "Taurus", "Convertible" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Honda", "39587-7972", "Wrangler", "Crew Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Cadillac", "74459", "Aventador", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Kia", "05901-0052", "PT Cruiser", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Hyandai", "39083", "Fiesta", "Minivan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Dodge", "07720", "A4", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Audi", "83680-9769", "Focus", "Crew Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Fiat", "85505", "Accord", "Sedan" });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 52, 10, 534, DateTimeKind.Local).AddTicks(8295), "Hoppe, Lueilwitz and Klocko", 43192182 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 21, 3, 44, 42, 622, DateTimeKind.Local).AddTicks(3714), "Crist Inc", 32897630 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 15, 15, 21, 11, 439, DateTimeKind.Local).AddTicks(6035), "Aufderhar - Monahan", 44353599 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 3, 7, 13, 37, 58, 853, DateTimeKind.Local).AddTicks(537), "Bergstrom - Schumm", 62228060 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 15, 17, 47, 51, 383, DateTimeKind.Local).AddTicks(8254), "Langworth - Sporer", 55288507 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 12, 14, 53, 29, 391, DateTimeKind.Local).AddTicks(7134), "Anderson - Kerluke", 27485514 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 26, 7, 15, 22, 90, DateTimeKind.Local).AddTicks(8785), "Murray - Champlin", 46565730 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 11, 10, 57, 36, 341, DateTimeKind.Local).AddTicks(7726), "Morar - Boyle", 9734630 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 30, 16, 3, 12, 517, DateTimeKind.Local).AddTicks(571), "Medhurst - Schneider", 30579415 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 30, 18, 50, 55, 689, DateTimeKind.Local).AddTicks(2498), "Bahringer Inc", 21522024 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RejectionText",
                table: "Entry",
                newName: "RejectionReason");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Huelborough", "Slovenia", "Sporer Causeway", "063" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "North Ebbaberg", "Nigeria", "Kamryn Junctions", "576" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "East Darontown", "Belarus", "Quigley Crest", "69688" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Marquardtstad", "Malta", "Domenic Villages", "303" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Port Viola", "Qatar", "Jefferey Keys", "272" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Aliyahchester", "Mauritius", "June Falls", "24443" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Gislasonberg", "Morocco", "Naomi Trafficway", "284" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Dachtown", "Mayotte", "Kaela Shore", "0829" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Tiannaview", "Iceland", "Bradtke Square", "196" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "East Bridie", "Malta", "Jaleel Track", "4751" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Dooley - Boyle", "66834380" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Olson, Littel and Hamill", "37493615" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "O'Hara, Torphy and Jacobi", "31147293" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Hoeger - Bergstrom", "30123519" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Kunze LLC", "48157087" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Konopelski and Sons", "55223614" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Lesch LLC", "71129730" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Beer - Buckridge", "06139407" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Predovic - Rolfson", "37004873" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Weimann, Pacocha and Hickle", "05882786" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "161.1.175.48", "Herman", "Carey" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "75.230.99.218", "Towne", "Frank" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "153.141.93.200", "Von", "Desmond" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "49.35.197.28", "Leannon", "Ted" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "179.98.192.253", "Gutkowski", "Brent" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "134.163.186.35", "Pollich", "Ada" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "17.50.160.166", "McClure", "Muriel" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "111.240.117.13", "Schulist", "Ardella" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "181.196.152.233", "McCullough", "Aubree" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "31.132.23.42", "Russel", "Jefferey" });

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 6, 4, 6, 7, 22, 356, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 24, 11, 47, 3, 7, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 14, 11, 51, 15, 773, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 5, 11, 12, 55, 926, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 22, 0, 8, 27, 813, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 16, 0, 58, 48, 210, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 6, 30, 19, 28, 8, 169, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 18, 11, 58, 53, 347, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 3, 9, 34, 26, 73, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2019, 11, 18, 12, 8, 47, 567, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 25, 2, 9, 40, 940, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 21, 1, 18, 51, 680, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 9, 4, 50, 3, 94, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 8, 3, 59, 34, 456, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2019, 11, 16, 10, 52, 28, 944, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 17, 0, 35, 34, 221, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 2, 28, 11, 19, 6, 252, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 23, 12, 44, 38, 854, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 6, 10, 18, 6, 5, 987, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 11, 8, 55, 47, 768, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LicensePlate",
                value: "95470");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LicensePlate",
                value: "91564-6666");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LicensePlate",
                value: "48027");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4L,
                column: "LicensePlate",
                value: "39216-2844");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5L,
                column: "LicensePlate",
                value: "63697-7362");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6L,
                column: "LicensePlate",
                value: "92029");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7L,
                column: "LicensePlate",
                value: "78319-0401");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8L,
                column: "LicensePlate",
                value: "59163-1269");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9L,
                column: "LicensePlate",
                value: "07675");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10L,
                column: "LicensePlate",
                value: "94018");

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 23, 12, 52, 5, 9, DateTimeKind.Local).AddTicks(7697), "Bruen LLC", 10345047 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 18, 1, 17, 11, 854, DateTimeKind.Local).AddTicks(6940), "Wyman Group", 34785423 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 3, 12, 40, 56, 794, DateTimeKind.Local).AddTicks(4748), "O'Hara - Hane", 75170769 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 5, 21, 30, 15, 509, DateTimeKind.Local).AddTicks(8447), "Corwin, Wehner and Olson", 13887322 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 23, 19, 27, 58, 795, DateTimeKind.Local).AddTicks(6065), "Feeney Group", 12022540 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 3, 4, 4, 11, 7, 372, DateTimeKind.Local).AddTicks(3673), "Tromp, Nolan and Muller", 28280644 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 16, 22, 33, 48, 772, DateTimeKind.Local).AddTicks(2326), "Ankunding - Botsford", 30769823 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 6, 23, 25, 14, 950, DateTimeKind.Local).AddTicks(6472), "Larkin Inc", 94953817 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 12, 7, 48, 39, 631, DateTimeKind.Local).AddTicks(2641), "Rowe Group", 59551072 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 44, 55, 980, DateTimeKind.Local).AddTicks(411), "Gusikowski, Doyle and Donnelly", 96158517 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Toyota", "08731", "CTS", "Cargo Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Chrysler", "13629-7304", "Cruze", "Hatchback" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Jaguar", "06159-9312", "El Camino", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Dodge", "30648-4687", "Ranchero", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Jeep", "48888", "Charger", "Passenger Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Mini", "11522-1692", "Land Cruiser", "Coupe" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Porsche", "23078", "ATS", "Coupe" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Fiat", "79554", "Focus", "Crew Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Tesla", "14594", "Alpine", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Ferrari", "18992", "Roadster", "Coupe" });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 24, 10, 53, 57, 875, DateTimeKind.Local).AddTicks(8061), "Lockman - Pacocha", 63703719 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 12, 23, 33, 0, 918, DateTimeKind.Local).AddTicks(8962), "O'Connell and Sons", 2541693 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 20, 20, 40, 51, 739, DateTimeKind.Local).AddTicks(4655), "Miller - Tromp", 23765108 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 11, 23, 3, 34, 18, 6, DateTimeKind.Local).AddTicks(9240), "Morar, Gleason and Bartoletti", 80483670 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 4, 17, 30, 18, 399, DateTimeKind.Local).AddTicks(3859), "Spencer and Sons", 56519815 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 3, 12, 19, 13, 27, 381, DateTimeKind.Local).AddTicks(8935), "Bins Group", 4371045 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 27, 18, 27, 48, 798, DateTimeKind.Local).AddTicks(1796), "Pouros, Osinski and Fritsch", 44933333 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 5, 13, 36, 6, 582, DateTimeKind.Local).AddTicks(8518), "Stroman, Huel and Hoppe", 19090641 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 11, 23, 7, 47, 5, 830, DateTimeKind.Local).AddTicks(6410), "Feeney, Deckow and Dicki", 49858129 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 30, 15, 55, 38, 411, DateTimeKind.Local).AddTicks(9009), "Runolfsson, Bogisich and Emmerich", 25577075 });
        }
    }
}
