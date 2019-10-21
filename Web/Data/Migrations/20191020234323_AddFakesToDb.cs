using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddFakesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 1L, "West Zena", "Egypt", "Kulas Squares", "86495" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 9L, "Port Brain", "El Salvador", "Zelda Drive", "30491" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 8L, "East Webster", "Poland", "Adela Neck", "030" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 7L, "West Verona", "Bahrain", "Novella Station", "8428" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 6L, "South Patrickstad", "Slovakia (Slovak Republic)", "Fatima Dale", "85874" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 10L, "Port Scottieview", "Bahrain", "Clay Wall", "7388" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 4L, "Port Christyside", "Argentina", "Homenick Locks", "8345" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 3L, "East Gregoria", "Montserrat", "Ullrich Dale", "5029" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 2L, "West Lenoreton", "Solomon Islands", "Abbott Light", "63198" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "StreetHeight" },
                values: new object[] { 5L, "New Coraliemouth", "Switzerland", "Schoen Prairie", "9962" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 9L, "75.49.118.190", "Donnelly", "Cordie" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 1L, "58.33.185.22", "Langworth", "Corbin" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 2L, "128.57.223.34", "Mosciski", "Corrine" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 3L, "137.173.17.236", "Moore", "Maida" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 4L, "158.16.21.138", "Leffler", "Emil" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 5L, "183.25.181.243", "O'Kon", "Abigale" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 6L, "234.157.236.18", "Donnelly", "Hanna" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 7L, "213.114.167.71", "Hermann", "Dayne" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 8L, "222.34.41.136", "Lind", "Solon" });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "Dni", "LastName", "Name" },
                values: new object[] { 10L, "240.175.208.50", "Brekke", "Garnet" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 1L, 1L, "Lang, Hammes and Becker", "44466060" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 2L, 2L, "McLaughlin - Parker", "29854073" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 3L, 3L, "Brakus LLC", "27101452" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 4L, 4L, "Lynch Group", "36090570" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 5L, 5L, "Hansen - Sipes", "20657697" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 6L, 6L, "Kessler, Schultz and Heidenreich", "64686332" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 7L, 7L, "Dooley - Krajcik", "48625883" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 8L, 8L, "Walsh - Haley", "17241069" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 9L, 9L, "Lynch LLC", "87757231" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "AddressId", "BusinessName", "Cuit" },
                values: new object[] { 10L, 10L, "Keeling Inc", "31138208" });
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
        }
    }
}
