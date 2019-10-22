using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class NoseQueEstoyMigrando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "North Nadiaview", "Republic of Korea", "Hills Streets", "9737" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Lake Eulahbury", "Poland", "McDermott Turnpike", "923" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Hicklemouth", "Djibouti", "Esperanza Lights", "8238" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Weimannton", "Austria", "Littel Islands", "7943" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "East Lucystad", "Albania", "Lyric Fall", "377" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "North Mafalda", "Lesotho", "Tara Summit", "79159" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "West Katarina", "Seychelles", "Mayert Shores", "9521" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Nolanstad", "Greece", "Adeline Terrace", "20247" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Breitenbergberg", "Greece", "Cole Canyon", "719" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Destinfort", "Benin", "Hansen Brook", "855" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Monahan LLC", "92374089" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Funk, Quigley and O'Hara", "13324063" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Goldner, Kub and Rolfson", "02805610" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Sanford, Turcotte and O'Keefe", "02830780" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Schulist - Abshire", "03163610" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Jenkins - Kub", "31111836" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Dickinson - Pagac", "49742145" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Blick Group", "87679960" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Cormier - Beahan", "04343905" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Effertz - Dibbert", "34215159" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "182.115.58.51", "Hegmann", "Ara" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "117.168.140.109", "Fadel", "Harley" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "62.30.250.87", "Oberbrunner", "Burley" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "4.144.84.41", "Boyer", "Donavon" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "203.216.227.146", "Kunde", "Hassie" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "137.41.205.88", "Veum", "Woodrow" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "235.216.245.16", "Rowe", "Talia" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "196.139.166.99", "Bernier", "Walter" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "104.17.37.125", "Metz", "Kian" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "58.141.46.33", "Fay", "Hailee" });

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 2, 10, 25, 28, 503, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 4, 11, 6, 57, 43, 260, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2020, 4, 2, 23, 33, 47, 193, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 16, 15, 10, 53, 296, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 15, 13, 5, 41, 367, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 19, 8, 26, 38, 694, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 2, 10, 16, 15, 19, 207, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 31, 23, 1, 54, 500, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 20, 22, 12, 29, 520, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 2, 18, 21, 33, 59, 717, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 24, 16, 28, 28, 790, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 7, 21, 59, 36, 865, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 5, 10, 45, 54, 91, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 27, 7, 16, 50, 694, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2020, 10, 5, 16, 6, 26, 771, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 17, 4, 38, 1, 171, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 31, 10, 35, 45, 683, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2019, 10, 29, 19, 17, 4, 952, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 14, 23, 40, 4, 917, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 4, 2, 34, 46, 202, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LicensePlate",
                value: "05711");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LicensePlate",
                value: "49386");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LicensePlate",
                value: "71484-8184");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4L,
                column: "LicensePlate",
                value: "82339-6246");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5L,
                column: "LicensePlate",
                value: "67519-5201");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6L,
                column: "LicensePlate",
                value: "65059-0836");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7L,
                column: "LicensePlate",
                value: "70946");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8L,
                column: "LicensePlate",
                value: "78287");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9L,
                column: "LicensePlate",
                value: "29106-3996");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10L,
                column: "LicensePlate",
                value: "69932");

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 3, 27, 5, 19, 0, 86, DateTimeKind.Local).AddTicks(3810), "Hills - Hand", 69340543 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 10, 3, 23, 42, 3, 187, DateTimeKind.Local).AddTicks(3725), "Lakin, Jenkins and Paucek", 62364683 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 7, 12, 35, 29, 415, DateTimeKind.Local).AddTicks(6576), "Keebler - Schaden", 88848822 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 25, 2, 58, 24, 612, DateTimeKind.Local).AddTicks(8103), "Volkman Group", 8989451 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 10, 25, 3, 7, 21, 58, DateTimeKind.Local).AddTicks(9706), "Quigley - Denesik", 71390109 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 14, 6, 29, 8, 458, DateTimeKind.Local).AddTicks(8240), "Turcotte Inc", 94610574 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 26, 10, 43, 26, 617, DateTimeKind.Local).AddTicks(5807), "Crona, Runte and Williamson", 2858814 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 13, 11, 47, 28, 78, DateTimeKind.Local).AddTicks(4896), "Blick, Balistreri and Bashirian", 7197031 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 11, 16, 23, 3, 8, 649, DateTimeKind.Local).AddTicks(2635), "Daniel Group", 52749476 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 2, 17, 40, 44, 57, DateTimeKind.Local).AddTicks(1962), "Fisher Inc", 531375 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Aston Martin", "00508-0209", "Escalade", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Aston Martin", "60851-6092", "Model T", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Lamborghini", "97776", "Cruze", "Minivan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Nissan", "75000", "Grand Caravan", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Maserati", "05832-1247", "Mercielago", "Minivan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Lamborghini", "34504", "Prius", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Toyota", "25133-4062", "Impala", "Wagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Kia", "05656", "Camry", "Cargo Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Volkswagen", "66425-5046", "Volt", "Minivan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Honda", "21988", "Civic", "Coupe" });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 8, 1, 54, 38, 788, DateTimeKind.Local).AddTicks(7809), "Cole, Bergstrom and Johnston", 48208246 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2019, 12, 21, 19, 24, 53, 685, DateTimeKind.Local).AddTicks(4968), "Swift - Schuppe", 69653742 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 31, 6, 35, 45, 971, DateTimeKind.Local).AddTicks(7923), "Schamberger, Kessler and Rempel", 33052144 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 9, 6, 17, 59, 989, DateTimeKind.Local).AddTicks(2669), "Hauck, O'Connell and Stanton", 5763900 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 13, 6, 55, 24, 319, DateTimeKind.Local).AddTicks(9532), "Nienow - Raynor", 69614606 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 23, 8, 11, 52, 786, DateTimeKind.Local).AddTicks(582), "Stokes - Willms", 78627635 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 20, 22, 2, 54, 385, DateTimeKind.Local).AddTicks(2165), "Simonis, Prohaska and Kunze", 60600479 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 5, 11, 56, 27, 332, DateTimeKind.Local).AddTicks(1747), "Witting - Hackett", 92422148 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 2, 14, 31, 47, 458, DateTimeKind.Local).AddTicks(417), "Yundt Group", 8772299 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 26, 23, 20, 25, 753, DateTimeKind.Local).AddTicks(6351), "Towne, Dickinson and Emard", 36436552 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Lake Adolphusmouth", "Monaco", "Cedrick Isle", "87820" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "New Toy", "Chad", "Deborah Expressway", "881" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Port Talon", "Seychelles", "Curt Junctions", "894" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "West Armand", "South Africa", "Winifred Mount", "185" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Port Frederichaven", "Congo", "Sauer Meadow", "29959" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "New Lauretta", "Swaziland", "Tianna Lake", "16251" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "East Salvatorefurt", "Singapore", "Kiel Passage", "013" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "West Lillyberg", "United States Minor Outlying Islands", "Lesch Spur", "15838" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "New Tayaville", "French Polynesia", "Eldora Knolls", "213" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Aaronborough", "Sudan", "Horacio Neck", "57049" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Schmitt, Abbott and Orn", "62482387" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Schuster Group", "03215852" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Satterfield, Steuber and Walker", "03131121" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Hilll and Sons", "44258849" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Morar - King", "26521596" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Bins, Haley and Senger", "01759341" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Fay LLC", "04459958" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Watsica, Beahan and Kshlerin", "14647918" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Farrell - Fisher", "90642593" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Lemke, Yost and Gleichner", "37210618" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "153.108.75.35", "Heathcote", "Dino" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "219.188.16.31", "King", "Damaris" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "78.129.0.104", "Jacobs", "Ansley" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "221.22.186.114", "Sipes", "Joanny" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "103.15.54.200", "King", "Leola" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "81.166.69.13", "Schmidt", "Adolf" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "242.204.201.74", "Leffler", "Leola" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "115.224.162.21", "Rowe", "Marilie" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "97.99.42.193", "Lynch", "Danielle" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "106.38.235.117", "Doyle", "Myriam" });

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 6, 4, 21, 7, 7, 945, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 2, 6, 17, 40, 957, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 29, 0, 41, 29, 335, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 20, 15, 43, 57, 388, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 15, 18, 0, 49, 369, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2020, 1, 29, 10, 28, 21, 564, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 3, 7, 31, 58, 78, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 9, 22, 1, 29, 517, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2020, 7, 20, 7, 18, 30, 730, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 7, 17, 53, 26, 402, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 13, 11, 28, 15, 714, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 6, 13, 0, 54, 967, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 24, 14, 18, 18, 920, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ExpirationDate",
                value: new DateTime(2020, 5, 30, 3, 10, 40, 169, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 19, 2, 46, 46, 383, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 6L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 10, 14, 22, 19, 256, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ExpirationDate",
                value: new DateTime(2020, 3, 3, 13, 43, 19, 485, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 8L,
                column: "ExpirationDate",
                value: new DateTime(2020, 9, 3, 7, 27, 7, 853, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 9L,
                column: "ExpirationDate",
                value: new DateTime(2019, 12, 20, 6, 45, 47, 871, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 10L,
                column: "ExpirationDate",
                value: new DateTime(2020, 8, 5, 11, 33, 18, 79, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LicensePlate",
                value: "31007");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LicensePlate",
                value: "55378");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LicensePlate",
                value: "13624-8577");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4L,
                column: "LicensePlate",
                value: "40806");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5L,
                column: "LicensePlate",
                value: "01645-1506");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6L,
                column: "LicensePlate",
                value: "59629-4992");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7L,
                column: "LicensePlate",
                value: "08936-4387");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8L,
                column: "LicensePlate",
                value: "17795");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9L,
                column: "LicensePlate",
                value: "03008");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10L,
                column: "LicensePlate",
                value: "54351-5400");

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 22, 23, 1, 9, 49, DateTimeKind.Local).AddTicks(762), "Romaguera, Maggio and Glover", 69838194 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 3, 2, 53, 55, 374, DateTimeKind.Local).AddTicks(4244), "Hills - Heathcote", 3672914 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 3, 17, 4, 2, 41, 457, DateTimeKind.Local).AddTicks(770), "Treutel - Zulauf", 35507802 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 8, 24, 6, 10, 56, 804, DateTimeKind.Local).AddTicks(9412), "Dietrich Inc", 85956674 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 19, 21, 36, 17, 688, DateTimeKind.Local).AddTicks(4948), "Watsica, Boehm and Goldner", 30039803 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 2, 11, 21, 9, 896, DateTimeKind.Local).AddTicks(1135), "Hilpert, Walker and Pfeffer", 58311868 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 5, 2, 5, 59, 746, DateTimeKind.Local).AddTicks(7211), "Mayer and Sons", 17635820 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 7, 4, 26, 24, 375, DateTimeKind.Local).AddTicks(6366), "Hand LLC", 49482515 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 2, 24, 17, 26, 13, 497, DateTimeKind.Local).AddTicks(1866), "Kovacek and Sons", 46345257 });

            migrationBuilder.UpdateData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 12, 22, 10, 25, 901, DateTimeKind.Local).AddTicks(26), "Casper, Osinski and Beier", 61226104 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Maserati", "43183", "Malibu", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Maserati", "00306", "A8", "Coupe" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Audi", "32599", "Aventador", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Hyandai", "64042", "Mercielago", "Hatchback" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Rolls Royce", "25973-9161", "Malibu", "Cargo Van" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Fiat", "08785", "A4", "Hatchback" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "BMW", "88318", "Charger", "Extended Cab Pickup" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Hyandai", "75572-1586", "Grand Caravan", "SUV" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Lamborghini", "69332", "Impala", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Brand", "LicensePlate", "Model", "Type" },
                values: new object[] { "Fiat", "64061-4112", "CTS", "Convertible" });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 7, 8, 34, 43, 342, DateTimeKind.Local).AddTicks(351), "Kunze Inc", 10168516 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 3, 20, 41, 29, 716, DateTimeKind.Local).AddTicks(1308), "Hammes and Sons", 26542966 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 5, 21, 10, 27, 18, 161, DateTimeKind.Local).AddTicks(5341), "Thompson, Kuhic and Berge", 42254768 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 9, 23, 20, 13, 49, 363, DateTimeKind.Local).AddTicks(1261), "Gleason - Daugherty", 15380098 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 24, 0, 34, 24, 739, DateTimeKind.Local).AddTicks(1377), "Johnson Group", 81602124 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 4, 20, 15, 37, 346, DateTimeKind.Local).AddTicks(6009), "Hand - Wolff", 69321467 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 1, 10, 21, 37, 47, 799, DateTimeKind.Local).AddTicks(2981), "Will - Dibbert", 4981510 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 7, 25, 18, 12, 7, 625, DateTimeKind.Local).AddTicks(6037), "Fahey - Nolan", 23476479 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 6, 28, 8, 40, 39, 712, DateTimeKind.Local).AddTicks(152), "Nader, Steuber and White", 48448949 });

            migrationBuilder.UpdateData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { new DateTime(2020, 4, 3, 1, 2, 42, 922, DateTimeKind.Local).AddTicks(8143), "Stracke and Sons", 12149711 });
        }
    }
}
