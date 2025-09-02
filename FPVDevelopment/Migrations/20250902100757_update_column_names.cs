using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPVDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class update_column_names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "MapName",
                table: "Maps",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MapDifficulty",
                table: "Maps",
                newName: "Difficulty");

            migrationBuilder.RenameColumn(
                name: "DroneSize",
                table: "Drones",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "DroneName",
                table: "Drones",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DroneID",
                table: "Drones",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CompletedRunTime",
                table: "CompletedRuns",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "CompletedRunDate",
                table: "CompletedRuns",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CompletedRunID",
                table: "CompletedRuns",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Maps",
                newName: "MapName");

            migrationBuilder.RenameColumn(
                name: "Difficulty",
                table: "Maps",
                newName: "MapDifficulty");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Drones",
                newName: "DroneSize");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Drones",
                newName: "DroneName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Drones",
                newName: "DroneID");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "CompletedRuns",
                newName: "CompletedRunTime");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "CompletedRuns",
                newName: "CompletedRunDate");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CompletedRuns",
                newName: "CompletedRunID");
        }
    }
}
