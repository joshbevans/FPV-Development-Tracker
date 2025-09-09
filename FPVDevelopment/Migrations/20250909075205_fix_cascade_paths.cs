using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPVDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class fix_cascade_paths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedRuns_Courses_CourseID",
                table: "CompletedRuns");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Maps_MapID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Drones_Sims_SimID",
                table: "Drones");

            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Sims_SimID",
                table: "Maps");

            migrationBuilder.AddColumn<int>(
                name: "UserLevel",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SimID",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Maps",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SimID",
                table: "Drones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Maps_UserID",
                table: "Maps",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserID",
                table: "Courses",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedRuns_Courses_CourseID",
                table: "CompletedRuns",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Maps_MapID",
                table: "Courses",
                column: "MapID",
                principalTable: "Maps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UserID",
                table: "Courses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Users_UserID",
                table: "Maps",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedRuns_Courses_CourseID",
                table: "CompletedRuns");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Maps_MapID",
                table: "Courses");

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

            migrationBuilder.DropIndex(
                name: "IX_Maps_UserID",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UserID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserLevel",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "SimID",
                table: "Maps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SimID",
                table: "Drones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedRuns_Courses_CourseID",
                table: "CompletedRuns",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Maps_MapID",
                table: "Courses",
                column: "MapID",
                principalTable: "Maps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Drones_Sims_SimID",
                table: "Drones",
                column: "SimID",
                principalTable: "Sims",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Sims_SimID",
                table: "Maps",
                column: "SimID",
                principalTable: "Sims",
                principalColumn: "ID");
        }
    }
}
