using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class RemittanceNowsOperationState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OperationState_RemittanceId",
                table: "OperationState");

            migrationBuilder.AddColumn<DateTime>(
                name: "DownloadFinishedAt",
                table: "OperationState",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DownloadStartedAt",
                table: "OperationState",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_OperationState_RemittanceId",
                table: "OperationState",
                column: "RemittanceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OperationState_RemittanceId",
                table: "OperationState");

            migrationBuilder.DropColumn(
                name: "DownloadFinishedAt",
                table: "OperationState");

            migrationBuilder.DropColumn(
                name: "DownloadStartedAt",
                table: "OperationState");
            

            migrationBuilder.CreateIndex(
                name: "IX_OperationState_RemittanceId",
                table: "OperationState",
                column: "RemittanceId");
        }
    }
}
