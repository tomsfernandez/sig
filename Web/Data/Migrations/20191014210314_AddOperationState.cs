using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class AddOperationState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationState",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RemittanceState = table.Column<string>(nullable: true),
                    MerchandiseState = table.Column<string>(nullable: true),
                    RemittanceId = table.Column<long>(nullable: false),
                    EntryId = table.Column<long>(nullable: false),
                    DockId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationState_Dock_DockId",
                        column: x => x.DockId,
                        principalTable: "Dock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationState_Entry_EntryId",
                        column: x => x.EntryId,
                        principalTable: "Entry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationState_Remittance_RemittanceId",
                        column: x => x.RemittanceId,
                        principalTable: "Remittance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperationState_DockId",
                table: "OperationState",
                column: "DockId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationState_EntryId",
                table: "OperationState",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationState_RemittanceId",
                table: "OperationState",
                column: "RemittanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationState");
        }
    }
}
