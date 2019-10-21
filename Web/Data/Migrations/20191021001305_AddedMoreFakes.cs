using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddedMoreFakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 9L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 8L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 7L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 6L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 10L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 4L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 3L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 2L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 1L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 5L, false });

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

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 9L, new DateTime(2020, 2, 24, 17, 26, 13, 497, DateTimeKind.Local).AddTicks(1866), "Kovacek and Sons", 46345257 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 8L, new DateTime(2020, 2, 7, 4, 26, 24, 375, DateTimeKind.Local).AddTicks(6366), "Hand LLC", 49482515 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 10L, new DateTime(2020, 6, 12, 22, 10, 25, 901, DateTimeKind.Local).AddTicks(26), "Casper, Osinski and Beier", 61226104 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 7L, new DateTime(2020, 1, 5, 2, 5, 59, 746, DateTimeKind.Local).AddTicks(7211), "Mayer and Sons", 17635820 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 6L, new DateTime(2020, 4, 2, 11, 21, 9, 896, DateTimeKind.Local).AddTicks(1135), "Hilpert, Walker and Pfeffer", 58311868 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 3L, new DateTime(2020, 3, 17, 4, 2, 41, 457, DateTimeKind.Local).AddTicks(770), "Treutel - Zulauf", 35507802 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 4L, new DateTime(2020, 8, 24, 6, 10, 56, 804, DateTimeKind.Local).AddTicks(9412), "Dietrich Inc", 85956674 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 2L, new DateTime(2020, 7, 3, 2, 53, 55, 374, DateTimeKind.Local).AddTicks(4244), "Hills - Heathcote", 3672914 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 1L, new DateTime(2020, 9, 22, 23, 1, 9, 49, DateTimeKind.Local).AddTicks(762), "Romaguera, Maggio and Glover", 69838194 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 5L, new DateTime(2020, 1, 19, 21, 36, 17, 688, DateTimeKind.Local).AddTicks(4948), "Watsica, Boehm and Goldner", 30039803 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 9L, new DateTime(2020, 6, 28, 8, 40, 39, 712, DateTimeKind.Local).AddTicks(152), "Nader, Steuber and White", 48448949 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 1L, new DateTime(2020, 4, 7, 8, 34, 43, 342, DateTimeKind.Local).AddTicks(351), "Kunze Inc", 10168516 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 2L, new DateTime(2020, 4, 3, 20, 41, 29, 716, DateTimeKind.Local).AddTicks(1308), "Hammes and Sons", 26542966 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 3L, new DateTime(2020, 5, 21, 10, 27, 18, 161, DateTimeKind.Local).AddTicks(5341), "Thompson, Kuhic and Berge", 42254768 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 4L, new DateTime(2020, 9, 23, 20, 13, 49, 363, DateTimeKind.Local).AddTicks(1261), "Gleason - Daugherty", 15380098 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 5L, new DateTime(2020, 6, 24, 0, 34, 24, 739, DateTimeKind.Local).AddTicks(1377), "Johnson Group", 81602124 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 6L, new DateTime(2020, 1, 4, 20, 15, 37, 346, DateTimeKind.Local).AddTicks(6009), "Hand - Wolff", 69321467 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 7L, new DateTime(2020, 1, 10, 21, 37, 47, 799, DateTimeKind.Local).AddTicks(2981), "Will - Dibbert", 4981510 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 8L, new DateTime(2020, 7, 25, 18, 12, 7, 625, DateTimeKind.Local).AddTicks(6037), "Fahey - Nolan", 23476479 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 10L, new DateTime(2020, 4, 3, 1, 2, 42, 922, DateTimeKind.Local).AddTicks(8143), "Stracke and Sons", 12149711 });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 1L, "31007", 1L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 9L, "03008", 9L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 8L, "17795", 8L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 7L, "08936-4387", 7L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 6L, "59629-4992", 6L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 10L, "54351-5400", 10L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 4L, "40806", 4L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 3L, "13624-8577", 3L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 2L, "55378", 2L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 5L, "01645-1506", 5L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 9L, "Lamborghini", "69332", "Impala", "Sedan", 9L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 1L, "Maserati", "43183", "Malibu", "SUV", 1L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 2L, "Maserati", "00306", "A8", "Coupe", 2L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 3L, "Audi", "32599", "Aventador", "SUV", 3L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 4L, "Hyandai", "64042", "Mercielago", "Hatchback", 4L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 5L, "Rolls Royce", "25973-9161", "Malibu", "Cargo Van", 5L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 6L, "Fiat", "08785", "A4", "Hatchback", 6L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 7L, "BMW", "88318", "Charger", "Extended Cab Pickup", 7L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 8L, "Hyandai", "75572-1586", "Grand Caravan", "SUV", 8L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 10L, "Fiat", "64061-4112", "CTS", "Convertible", 10L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 1L, 1L, new DateTime(2020, 6, 4, 21, 7, 7, 945, DateTimeKind.Local).AddTicks(7413), 1L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 2L, 2L, new DateTime(2020, 3, 2, 6, 17, 40, 957, DateTimeKind.Local).AddTicks(4432), 2L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 9L, 9L, new DateTime(2020, 7, 20, 7, 18, 30, 730, DateTimeKind.Local).AddTicks(2160), 9L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 3L, 3L, new DateTime(2020, 5, 29, 0, 41, 29, 335, DateTimeKind.Local).AddTicks(8504), 3L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 4L, 4L, new DateTime(2020, 8, 20, 15, 43, 57, 388, DateTimeKind.Local).AddTicks(8658), 4L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 8L, 8L, new DateTime(2020, 7, 9, 22, 1, 29, 517, DateTimeKind.Local).AddTicks(703), 8L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 5L, 5L, new DateTime(2020, 8, 15, 18, 0, 49, 369, DateTimeKind.Local).AddTicks(6351), 5L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 10L, 10L, new DateTime(2020, 3, 7, 17, 53, 26, 402, DateTimeKind.Local).AddTicks(5398), 10L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 6L, 6L, new DateTime(2020, 1, 29, 10, 28, 21, 564, DateTimeKind.Local).AddTicks(9537), 6L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 7L, 7L, new DateTime(2020, 7, 3, 7, 31, 58, 78, DateTimeKind.Local).AddTicks(6014), 7L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 9L, "Ministerio de Transporte", new DateTime(2019, 12, 20, 6, 45, 47, 871, DateTimeKind.Local).AddTicks(124), 9L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 8L, "Ministerio de Transporte", new DateTime(2020, 9, 3, 7, 27, 7, 853, DateTimeKind.Local).AddTicks(4572), 8L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 7L, "Ministerio de Transporte", new DateTime(2020, 3, 3, 13, 43, 19, 485, DateTimeKind.Local).AddTicks(6941), 7L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 5L, "Ministerio de Transporte", new DateTime(2019, 12, 19, 2, 46, 46, 383, DateTimeKind.Local).AddTicks(5923), 5L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 4L, "Ministerio de Transporte", new DateTime(2020, 5, 30, 3, 10, 40, 169, DateTimeKind.Local).AddTicks(1364), 4L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 3L, "Ministerio de Transporte", new DateTime(2020, 9, 24, 14, 18, 18, 920, DateTimeKind.Local).AddTicks(82), 3L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 2L, "Ministerio de Transporte", new DateTime(2020, 8, 6, 13, 0, 54, 967, DateTimeKind.Local).AddTicks(9230), 2L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 1L, "Ministerio de Transporte", new DateTime(2020, 9, 13, 11, 28, 15, 714, DateTimeKind.Local).AddTicks(4659), 1L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 6L, "Ministerio de Transporte", new DateTime(2019, 12, 10, 14, 22, 19, 256, DateTimeKind.Local).AddTicks(4673), 6L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 10L, "Ministerio de Transporte", new DateTime(2020, 8, 5, 11, 33, 18, 79, DateTimeKind.Local).AddTicks(8896), 10L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Dock",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "DriverPermit",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "RTO",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "TrailerInsurance",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "VehicleInsurance",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "West Zena", "Egypt", "Kulas Squares", "86495" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "West Lenoreton", "Solomon Islands", "Abbott Light", "63198" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "East Gregoria", "Montserrat", "Ullrich Dale", "5029" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Port Christyside", "Argentina", "Homenick Locks", "8345" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "New Coraliemouth", "Switzerland", "Schoen Prairie", "9962" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "South Patrickstad", "Slovakia (Slovak Republic)", "Fatima Dale", "85874" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "West Verona", "Bahrain", "Novella Station", "8428" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "East Webster", "Poland", "Adela Neck", "030" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Port Brain", "El Salvador", "Zelda Drive", "30491" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "City", "Country", "Street", "StreetHeight" },
                values: new object[] { "Port Scottieview", "Bahrain", "Clay Wall", "7388" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Lang, Hammes and Becker", "44466060" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "McLaughlin - Parker", "29854073" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Brakus LLC", "27101452" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Lynch Group", "36090570" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Hansen - Sipes", "20657697" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Kessler, Schultz and Heidenreich", "64686332" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Dooley - Krajcik", "48625883" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Walsh - Haley", "17241069" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Lynch LLC", "87757231" });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BusinessName", "Cuit" },
                values: new object[] { "Keeling Inc", "31138208" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "58.33.185.22", "Langworth", "Corbin" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "128.57.223.34", "Mosciski", "Corrine" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "137.173.17.236", "Moore", "Maida" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "158.16.21.138", "Leffler", "Emil" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "183.25.181.243", "O'Kon", "Abigale" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "234.157.236.18", "Donnelly", "Hanna" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "213.114.167.71", "Hermann", "Dayne" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "222.34.41.136", "Lind", "Solon" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "75.49.118.190", "Donnelly", "Cordie" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Dni", "LastName", "Name" },
                values: new object[] { "240.175.208.50", "Brekke", "Garnet" });
        }
    }
}
