using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class sdfgsdfgsdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 1L, "Helenland", "Palestinian Territory", "Predovic Shoals", "842" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 2L, "East Nathanaelborough", "New Zealand", "Hagenes Hollow", "2938" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 3L, "New Newton", "Turks and Caicos Islands", "Hans Plaza", "82992" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 4L, "Thielland", "Armenia", "Barton Islands", "519" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 5L, "Reeceborough", "Antarctica (the territory South of 60 deg S)", "Adella Village", "3543" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 6L, "O'Reillybury", "Albania", "Volkman Spurs", "270" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 7L, "South Jazlyn", "Poland", "Una Alley", "116" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 8L, "New Edyth", "Suriname", "Shemar Greens", "6746" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 9L, "East Lukasport", "Albania", "Monserrate Garden", "268" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 10L, "Julianport", "Seychelles", "Hettinger Ramp", "1322" });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 10L, false });

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
                values: new object[] { 3L, false });

            migrationBuilder.InsertData(
                table: "Dock",
                columns: new[] { "Id", "Occupied" },
                values: new object[] { 4L, false });

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

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 7L, "230.159.80.131", "Hickle", "Felton" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 10L, "129.48.33.22", "Rogahn", "Orion" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 9L, "100.249.222.3", "Cormier", "Weldon" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 8L, "28.246.216.21", "Spencer", "Sonya" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 6L, "154.185.236.10", "Reichel", "Tom" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 5L, "182.227.144.199", "Spencer", "Seth" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 4L, "227.159.217.28", "Champlin", "Domingo" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 3L, "114.26.93.29", "Medhurst", "Zachery" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 2L, "122.80.72.84", "Carter", "Camron" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 1L, "77.102.55.124", "Wiegand", "Loy" });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 10L, new DateTime(2019, 12, 27, 22, 57, 48, 751, DateTimeKind.Local).AddTicks(5750), "Haley, Connelly and Schinner", 64175881 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 9L, new DateTime(2020, 8, 8, 1, 44, 26, 888, DateTimeKind.Local).AddTicks(1894), "Nienow LLC", 36340910 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 7L, new DateTime(2020, 2, 21, 6, 44, 37, 896, DateTimeKind.Local).AddTicks(8448), "Maggio - Schulist", 51919368 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 6L, new DateTime(2020, 9, 15, 13, 26, 22, 296, DateTimeKind.Local).AddTicks(3334), "Lockman and Sons", 54783126 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 8L, new DateTime(2020, 10, 15, 12, 2, 51, 167, DateTimeKind.Local).AddTicks(9624), "Donnelly Inc", 72670224 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 4L, new DateTime(2019, 12, 7, 20, 48, 53, 112, DateTimeKind.Local).AddTicks(3876), "Wisoky - Cremin", 1829235 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 3L, new DateTime(2020, 6, 28, 23, 33, 14, 247, DateTimeKind.Local).AddTicks(557), "Maggio Group", 87607000 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 2L, new DateTime(2020, 4, 17, 5, 5, 17, 586, DateTimeKind.Local).AddTicks(6890), "Schuster, Williamson and Satterfield", 72119129 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 1L, new DateTime(2020, 9, 13, 21, 32, 8, 597, DateTimeKind.Local).AddTicks(9018), "Huels Group", 30255388 });

            migrationBuilder.InsertData(
                table: "TrailerInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 5L, new DateTime(2020, 6, 1, 6, 20, 37, 516, DateTimeKind.Local).AddTicks(7334), "Satterfield - Prosacco", 59367819 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 9L, new DateTime(2020, 10, 14, 12, 9, 26, 31, DateTimeKind.Local).AddTicks(333), "Pfeffer and Sons", 33107462 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 1L, new DateTime(2020, 1, 7, 13, 30, 9, 955, DateTimeKind.Local).AddTicks(2215), "D'Amore - Oberbrunner", 36447411 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 2L, new DateTime(2020, 7, 13, 12, 27, 49, 741, DateTimeKind.Local).AddTicks(8828), "Murazik Group", 32324037 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 3L, new DateTime(2020, 5, 16, 15, 14, 47, 915, DateTimeKind.Local).AddTicks(1367), "McKenzie, Schroeder and Stamm", 39957757 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 4L, new DateTime(2020, 7, 26, 18, 57, 51, 32, DateTimeKind.Local).AddTicks(7101), "Orn - Rodriguez", 16962484 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 5L, new DateTime(2020, 2, 11, 7, 0, 0, 499, DateTimeKind.Local).AddTicks(8002), "Corwin, Romaguera and Okuneva", 57680187 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 6L, new DateTime(2020, 7, 7, 16, 33, 4, 230, DateTimeKind.Local).AddTicks(8947), "Jacobs LLC", 54164840 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 7L, new DateTime(2019, 12, 12, 12, 32, 20, 627, DateTimeKind.Local).AddTicks(8135), "Beer - Oberbrunner", 26530871 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 8L, new DateTime(2020, 4, 11, 9, 19, 2, 920, DateTimeKind.Local).AddTicks(5015), "Powlowski Group", 48185578 });

            migrationBuilder.InsertData(
                table: "VehicleInsurance",
                columns: new[] { "Id", "ExpirationDate", "InsuranceBusinessName", "PolicyNumber" },
                values: new object[] { 10L, new DateTime(2020, 6, 20, 0, 41, 3, 333, DateTimeKind.Local).AddTicks(7133), "Fritsch - Mills", 3248799 });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 1L, 1L, "O'Kon - Treutel", "57135663" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 2L, 2L, "Goyette - Gutmann", "48389471" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 3L, 3L, "Graham, Osinski and Hessel", "89200452" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 4L, 4L, "Walsh, Stamm and Will", "38701221" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 5L, 5L, "Wisoky Inc", "22879349" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 6L, 6L, "Koch, Armstrong and Gottlieb", "95788340" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 7L, 7L, "Braun LLC", "34545195" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 8L, 8L, "Lang LLC", "97256328" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 9L, 9L, "Carroll Inc", "94863291" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 10L, 10L, "Heathcote Group", "70868739" });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 10L, "27226-6780", 10L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 9L, "45652-9734", 9L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 8L, "73716-4145", 8L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 7L, "24362-0805", 7L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 6L, "54189-1486", 6L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 5L, "11424-1217", 5L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 4L, "16698", 4L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 3L, "27382", 3L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 2L, "17566-9167", 2L });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "LicensePlate", "TrailerInsuranceId" },
                values: new object[] { 1L, "47332", 1L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 1L, "Fiat", "10041-8672", "Grand Caravan", "Coupe", 1L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 2L, "Maserati", "24179-5252", "LeBaron", "Coupe", 2L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 3L, "Bentley", "78645", "XTS", "Crew Cab Pickup", 3L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 4L, "Bugatti", "05168", "A8", "Extended Cab Pickup", 4L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 5L, "Lamborghini", "45006-6480", "Alpine", "Extended Cab Pickup", 5L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 6L, "Chevrolet", "60607", "Focus", "Sedan", 6L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 7L, "Dodge", "42236-5264", "A8", "Coupe", 7L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 8L, "Chrysler", "73719-0788", "A4", "Sedan", 8L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 9L, "Nissan", "19802-6480", "Model T", "Passenger Van", 9L });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Brand", "LicensePlate", "Model", "Type", "VehicleInsuranceId" },
                values: new object[] { 10L, "Fiat", "96358", "Sentra", "Crew Cab Pickup", 10L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 1L, 1L, new DateTime(2020, 5, 11, 15, 20, 48, 513, DateTimeKind.Local).AddTicks(6832), 1L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 2L, 2L, new DateTime(2020, 10, 10, 1, 6, 48, 348, DateTimeKind.Local).AddTicks(8749), 2L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 9L, 9L, new DateTime(2020, 7, 25, 16, 7, 5, 984, DateTimeKind.Local).AddTicks(9060), 9L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 3L, 3L, new DateTime(2020, 10, 16, 12, 19, 59, 378, DateTimeKind.Local).AddTicks(954), 3L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 4L, 4L, new DateTime(2020, 2, 10, 19, 40, 51, 366, DateTimeKind.Local).AddTicks(7987), 4L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 8L, 8L, new DateTime(2020, 8, 27, 16, 49, 38, 815, DateTimeKind.Local).AddTicks(8393), 8L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 5L, 5L, new DateTime(2020, 6, 29, 7, 36, 25, 539, DateTimeKind.Local).AddTicks(9373), 5L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 10L, 10L, new DateTime(2020, 3, 4, 1, 10, 7, 197, DateTimeKind.Local).AddTicks(6991), 10L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 6L, 6L, new DateTime(2019, 12, 15, 12, 23, 17, 352, DateTimeKind.Local).AddTicks(6440), 6L });

            migrationBuilder.InsertData(
                table: "DriverPermit",
                columns: new[] { "Id", "DriverId", "ExpirationDate", "VehicleId" },
                values: new object[] { 7L, 7L, new DateTime(2020, 7, 19, 22, 20, 14, 475, DateTimeKind.Local).AddTicks(1861), 7L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 9L, "Ministerio de Transporte", new DateTime(2020, 9, 25, 5, 45, 37, 521, DateTimeKind.Local).AddTicks(2586), 9L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 8L, "Ministerio de Transporte", new DateTime(2020, 6, 27, 1, 22, 37, 451, DateTimeKind.Local).AddTicks(8634), 8L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 7L, "Ministerio de Transporte", new DateTime(2020, 1, 7, 19, 20, 38, 765, DateTimeKind.Local).AddTicks(9139), 7L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 5L, "Ministerio de Transporte", new DateTime(2019, 12, 8, 18, 32, 13, 867, DateTimeKind.Local).AddTicks(4843), 5L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 4L, "Ministerio de Transporte", new DateTime(2020, 5, 30, 4, 8, 29, 511, DateTimeKind.Local).AddTicks(9850), 4L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 3L, "Ministerio de Transporte", new DateTime(2019, 12, 3, 21, 52, 42, 785, DateTimeKind.Local).AddTicks(6660), 3L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 2L, "Ministerio de Transporte", new DateTime(2020, 1, 27, 20, 44, 30, 481, DateTimeKind.Local).AddTicks(4441), 2L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 1L, "Ministerio de Transporte", new DateTime(2020, 3, 11, 21, 19, 9, 20, DateTimeKind.Local).AddTicks(4802), 1L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 6L, "Ministerio de Transporte", new DateTime(2020, 10, 11, 21, 11, 37, 410, DateTimeKind.Local).AddTicks(9498), 6L });

            migrationBuilder.InsertData(
                table: "RTO",
                columns: new[] { "Id", "CertifiedBy", "ExpirationDate", "VehicleId" },
                values: new object[] { 10L, "Ministerio de Transporte", new DateTime(2019, 12, 24, 12, 31, 54, 163, DateTimeKind.Local).AddTicks(2211), 10L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 10L);

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
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Driver",
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
        }
    }
}
