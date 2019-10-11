using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) {
            
            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Dni = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Driver", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "Driver");
        }
    }
}
