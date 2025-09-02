using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPVDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class add_drone_owner_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Drones",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "CompletedRuns",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<int>(
                name: "CrashCount",
                table: "CompletedRuns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Drones_UserID",
                table: "Drones",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Drones_Users_UserID",
                table: "Drones",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drones_Users_UserID",
                table: "Drones");

            migrationBuilder.DropIndex(
                name: "IX_Drones_UserID",
                table: "Drones");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Drones");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "CompletedRuns",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CrashCount",
                table: "CompletedRuns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
