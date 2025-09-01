using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPVDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class add_initial_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drones",
                columns: table => new
                {
                    DroneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DroneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DroneSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drones", x => x.DroneID);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    MapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MapDifficulty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.MapID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "CompletedRuns",
                columns: table => new
                {
                    CompletedRunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompletedRunTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MapID = table.Column<int>(type: "int", nullable: false),
                    DroneID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedRuns", x => x.CompletedRunID);
                    table.ForeignKey(
                        name: "FK_CompletedRuns_Drones_DroneID",
                        column: x => x.DroneID,
                        principalTable: "Drones",
                        principalColumn: "DroneID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompletedRuns_Maps_MapID",
                        column: x => x.MapID,
                        principalTable: "Maps",
                        principalColumn: "MapID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompletedRuns_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompletedRuns_DroneID",
                table: "CompletedRuns",
                column: "DroneID");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedRuns_MapID",
                table: "CompletedRuns",
                column: "MapID");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedRuns_UserID",
                table: "CompletedRuns",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedRuns");

            migrationBuilder.DropTable(
                name: "Drones");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
