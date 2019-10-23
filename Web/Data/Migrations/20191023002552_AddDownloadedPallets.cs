using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddDownloadedPallets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DownloadedPallets",
                table: "Merchandise",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Frederictown", "Chile", "Ewald Estates", "080" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Elnoraborough", "Tanzania", "Schmidt Common", "3355" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Glennatown", "Nepal", "Howell Mount", "24159" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "South Christelletown", "Fiji", "Cormier Fork", "3134" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Audraburgh", "Luxembourg", "Schimmel Forge", "43835" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Nicholasfort", "Guyana", "Koch Springs", "9553" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Feltonberg", "Virgin Islands, U.S.", "Emmanuelle Fields", "218" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Weimannborough", "Bahamas", "Tatum Crest", "785" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Jofurt", "Bahrain", "Raynor Oval", "31591" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Schroederton", "Bolivia", "Leila Plaza", "47787" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Kihn - Smitham", "68486778" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Rau, Kuvalis and Corkery", "07740725" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Brakus - Bartoletti", "81216871" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Smitham, Moore and Bernhard", "64474243" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Berge and Sons", "31426039" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Yundt, Schuster and Bosco", "38872600" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Aufderhar, Spencer and Thiel", "80432760" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Terry - Funk", "06407902" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Hudson, Boehm and Stanton", "79365017" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Jacobi - Gleason", "05424726" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "193.158.41.127", "Spencer", "Tyree" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "77.46.97.178", "Pouros", "Jewell" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "250.0.161.193", "Bradtke", "Alene" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "27.28.167.169", "Johnston", "Michele" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "224.122.252.255", "Aufderhar", "Andreane" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "205.90.53.187", "Rutherford", "Bettie" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "235.90.216.35", "Kuhlman", "Alan" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "55.78.176.235", "Gibson", "Heidi" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "106.207.110.28", "O'Reilly", "Eliezer" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "165.24.230.190", "Kohler", "Liliane" });

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 17, 19, 54, 43, 460, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 4, 11, 0, 27, 12, 589, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 4, 1, 50, 32, 93, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 17, 13, 44, 10, 930, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2019, 11, 18, 12, 54, 54, 750, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 7, 15, 20, 58, 418, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 7, 6, 35, 20, 562, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 21, 5, 43, 56, 400, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 19, 6, 18, 58, 354, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 2, 6, 15, 49, 12, 609, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 16, 12, 1, 13, 351, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 4, 3, 36, 5, 986, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 24, 22, 58, 49, 798, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 12, 14, 39, 14, 433, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 2, 7, 23, 22, 131, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 2, 8, 12, 43, 121, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 27, 21, 16, 5, 491, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 9, 11, 57, 54, 594, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 22, 18, 28, 45, 613, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 17, 16, 44, 30, 802, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LicensePlate",
                value: "51250-2000");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LicensePlate",
                value: "26423");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LicensePlate",
                value: "41587");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4L,
                column: "LicensePlate",
                value: "12137-3604");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5L,
                column: "LicensePlate",
                value: "90017");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6L,
                column: "LicensePlate",
                value: "38492");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7L,
                column: "LicensePlate",
                value: "31149-6219");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8L,
                column: "LicensePlate",
                value: "19904");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9L,
                column: "LicensePlate",
                value: "56390-8632");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10L,
                column: "LicensePlate",
                value: "50863");

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 30, 21, 52, 41, 862, DateTimeKind.Local).AddTicks(7892), "Terry - Trantow", 93395465 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 26, 8, 10, 39, 88, DateTimeKind.Local).AddTicks(5010), "Klein, Wintheiser and Auer", 33577081 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 33, 49, 76, DateTimeKind.Local).AddTicks(9699), "Howe - Gutmann", 7938399 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 20, 14, 6, 22, 124, DateTimeKind.Local).AddTicks(7468), "Wehner, Boyer and Cole", 18054095 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 3, 17, 8, 16, 298, DateTimeKind.Local).AddTicks(5734), "Murazik Group", 35701699 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 3, 18, 19, 12, 29, 453, DateTimeKind.Local).AddTicks(7709), "Collins - Bins", 31617192 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 29, 1, 49, 24, 906, DateTimeKind.Local).AddTicks(4455), "Bode LLC", 39643841 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 10, 16, 52, 33, 716, DateTimeKind.Local).AddTicks(6903), "Beer - Gorczany", 95712772 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 10, 17, 54, 21, 385, DateTimeKind.Local).AddTicks(9983), "O'Keefe, Ziemann and Romaguera", 37388263 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 3, 8, 0, 4, 23, 968, DateTimeKind.Local).AddTicks(1214), "Spinka - Sauer", 17462075 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Toyota", "81660-1169", "Taurus", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Dodge", "40091", "PT Cruiser", "Cargo Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Aston Martin", "14328-3530", "Grand Cherokee", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Maserati", "80378-0145", "Escalade", "Passenger Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LicensePlate", "Model", "Type" },
                values: new object[] { "76404-8100", "Explorer", "Hatchback" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Dodge", "71506", "Silverado", "Passenger Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Aston Martin", "06475", "Grand Caravan", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Toyota", "27868-9035", "XTS", "Passenger Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Porsche", "00520-9414", "Accord", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Hyandai", "86628-6340", "Impala", "Hatchback" });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 24, 2, 54, 13, 321, DateTimeKind.Local).AddTicks(7871), "Torphy Group", 83138140 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 23, 13, 26, 35, 77, DateTimeKind.Local).AddTicks(3582), "Will, Beer and Reinger", 62901444 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 4, 1, 37, 23, 192, DateTimeKind.Local).AddTicks(999), "Dare, Reynolds and Homenick", 25605006 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 25, 21, 30, 35, 963, DateTimeKind.Local).AddTicks(5927), "Lynch - Witting", 73845416 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 12, 12, 42, 33, 89, DateTimeKind.Local).AddTicks(7431), "Jakubowski - Cassin", 83546402 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 27, 22, 2, 18, 526, DateTimeKind.Local).AddTicks(5628), "Olson, Welch and Strosin", 87209181 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 21, 21, 22, 52, 546, DateTimeKind.Local).AddTicks(1274), "Balistreri - Gottlieb", 38591587 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 21, 20, 5, 24, 302, DateTimeKind.Local).AddTicks(6450), "Wolff Inc", 87963311 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 18, 16, 43, 14, 534, DateTimeKind.Local).AddTicks(6540), "Hahn - Schulist", 40245058 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 26, 20, 16, 21, 986, DateTimeKind.Local).AddTicks(6578), "Rutherford - Powlowski", 62604819 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DownloadedPallets",
                table: "Merchandise");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Helenland", "Palestinian Territory", "Predovic Shoals", "842" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "East Nathanaelborough", "New Zealand", "Hagenes Hollow", "2938" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "New Newton", "Turks and Caicos Islands", "Hans Plaza", "82992" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Thielland", "Armenia", "Barton Islands", "519" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Reeceborough", "Antarctica (the territory South of 60 deg S)", "Adella Village", "3543" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "O'Reillybury", "Albania", "Volkman Spurs", "270" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "South Jazlyn", "Poland", "Una Alley", "116" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "New Edyth", "Suriname", "Shemar Greens", "6746" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "East Lukasport", "Albania", "Monserrate Garden", "268" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Julianport", "Seychelles", "Hettinger Ramp", "1322" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "O'Kon - Treutel", "57135663" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Goyette - Gutmann", "48389471" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Graham, Osinski and Hessel", "89200452" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Walsh, Stamm and Will", "38701221" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Wisoky Inc", "22879349" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Koch, Armstrong and Gottlieb", "95788340" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Braun LLC", "34545195" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Lang LLC", "97256328" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Carroll Inc", "94863291" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Heathcote Group", "70868739" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "77.102.55.124", "Wiegand", "Loy" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "122.80.72.84", "Carter", "Camron" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "114.26.93.29", "Medhurst", "Zachery" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "227.159.217.28", "Champlin", "Domingo" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "182.227.144.199", "Spencer", "Seth" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "154.185.236.10", "Reichel", "Tom" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "230.159.80.131", "Hickle", "Felton" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "28.246.216.21", "Spencer", "Sonya" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "100.249.222.3", "Cormier", "Weldon" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "129.48.33.22", "Rogahn", "Orion" });

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 11, 15, 20, 48, 513, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 10, 1, 6, 48, 348, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 16, 12, 19, 59, 378, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 2, 10, 19, 40, 51, 366, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2020, 6, 29, 7, 36, 25, 539, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 15, 12, 23, 17, 352, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 19, 22, 20, 14, 475, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 27, 16, 49, 38, 815, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 25, 16, 7, 5, 984, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 4, 1, 10, 7, 197, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 11, 21, 19, 9, 20, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 27, 20, 44, 30, 481, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 3, 21, 52, 42, 785, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 30, 4, 8, 29, 511, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 8, 18, 32, 13, 867, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 11, 21, 11, 37, 410, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 7, 19, 20, 38, 765, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 6, 27, 1, 22, 37, 451, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 25, 5, 45, 37, 521, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 24, 12, 31, 54, 163, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LicensePlate",
                value: "47332");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LicensePlate",
                value: "17566-9167");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LicensePlate",
                value: "27382");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4L,
                column: "LicensePlate",
                value: "16698");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5L,
                column: "LicensePlate",
                value: "11424-1217");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6L,
                column: "LicensePlate",
                value: "54189-1486");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7L,
                column: "LicensePlate",
                value: "24362-0805");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8L,
                column: "LicensePlate",
                value: "73716-4145");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9L,
                column: "LicensePlate",
                value: "45652-9734");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10L,
                column: "LicensePlate",
                value: "27226-6780");

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 13, 21, 32, 8, 597, DateTimeKind.Local).AddTicks(9018), "Huels Group", 30255388 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 17, 5, 5, 17, 586, DateTimeKind.Local).AddTicks(6890), "Schuster, Williamson and Satterfield", 72119129 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 28, 23, 33, 14, 247, DateTimeKind.Local).AddTicks(557), "Maggio Group", 87607000 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 7, 20, 48, 53, 112, DateTimeKind.Local).AddTicks(3876), "Wisoky - Cremin", 1829235 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 1, 6, 20, 37, 516, DateTimeKind.Local).AddTicks(7334), "Satterfield - Prosacco", 59367819 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 15, 13, 26, 22, 296, DateTimeKind.Local).AddTicks(3334), "Lockman and Sons", 54783126 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 21, 6, 44, 37, 896, DateTimeKind.Local).AddTicks(8448), "Maggio - Schulist", 51919368 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 15, 12, 2, 51, 167, DateTimeKind.Local).AddTicks(9624), "Donnelly Inc", 72670224 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 8, 1, 44, 26, 888, DateTimeKind.Local).AddTicks(1894), "Nienow LLC", 36340910 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 27, 22, 57, 48, 751, DateTimeKind.Local).AddTicks(5750), "Haley, Connelly and Schinner", 64175881 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Fiat", "10041-8672", "Grand Caravan", "Coupe" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Maserati", "24179-5252", "LeBaron", "Coupe" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Bentley", "78645", "XTS", "Crew Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Bugatti", "05168", "A8", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LicensePlate", "Model", "Type" },
                values: new object[] { "45006-6480", "Alpine", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Chevrolet", "60607", "Focus", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Dodge", "42236-5264", "A8", "Coupe" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Chrysler", "73719-0788", "A4", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Nissan", "19802-6480", "Model T", "Passenger Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Fiat", "96358", "Sentra", "Crew Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 7, 13, 30, 9, 955, DateTimeKind.Local).AddTicks(2215), "D'Amore - Oberbrunner", 36447411 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 13, 12, 27, 49, 741, DateTimeKind.Local).AddTicks(8828), "Murazik Group", 32324037 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 14, 47, 915, DateTimeKind.Local).AddTicks(1367), "McKenzie, Schroeder and Stamm", 39957757 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 26, 18, 57, 51, 32, DateTimeKind.Local).AddTicks(7101), "Orn - Rodriguez", 16962484 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 11, 7, 0, 0, 499, DateTimeKind.Local).AddTicks(8002), "Corwin, Romaguera and Okuneva", 57680187 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 7, 16, 33, 4, 230, DateTimeKind.Local).AddTicks(8947), "Jacobs LLC", 54164840 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 12, 12, 32, 20, 627, DateTimeKind.Local).AddTicks(8135), "Beer - Oberbrunner", 26530871 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 11, 9, 19, 2, 920, DateTimeKind.Local).AddTicks(5015), "Powlowski Group", 48185578 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 14, 12, 9, 26, 31, DateTimeKind.Local).AddTicks(333), "Pfeffer and Sons", 33107462 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 20, 0, 41, 3, 333, DateTimeKind.Local).AddTicks(7133), "Fritsch - Mills", 3248799 });
        }
    }
}
