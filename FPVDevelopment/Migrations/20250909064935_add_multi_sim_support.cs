using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPVDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class add_multi_sim_support : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserLevel",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SimID",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Maps",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SimID",
                table: "Drones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sims", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maps_SimID",
                table: "Maps",
                column: "SimID");

            migrationBuilder.CreateIndex(
                name: "IX_Maps_UserID",
                table: "Maps",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Drones_SimID",
                table: "Drones",
                column: "SimID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserID",
                table: "Courses",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UserID",
                table: "Courses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Drones_Sims_SimID",
                table: "Drones",
                column: "SimID",
                principalTable: "Sims",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Sims_SimID",
                table: "Maps",
                column: "SimID",
                principalTable: "Sims",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Users_UserID",
                table: "Maps",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UserID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Drones_Sims_SimID",
                table: "Drones");

            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Sims_SimID",
                table: "Maps");

            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Users_UserID",
                table: "Maps");

            migrationBuilder.DropTable(
                name: "Sims");

            migrationBuilder.DropIndex(
                name: "IX_Maps_SimID",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Maps_UserID",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Drones_SimID",
                table: "Drones");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UserID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserLevel",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SimID",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "SimID",
                table: "Drones");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Courses");
        }
    }
}
