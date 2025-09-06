using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPVDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class add_course : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedRuns_Maps_MapID",
                table: "CompletedRuns");

            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "UsedID",
                table: "Drones");

            migrationBuilder.DropColumn(
                name: "CrashCount",
                table: "CompletedRuns");

            migrationBuilder.RenameColumn(
                name: "MapID",
                table: "CompletedRuns",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_CompletedRuns_MapID",
                table: "CompletedRuns",
                newName: "IX_CompletedRuns_CourseID");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    MapID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Courses_Maps_MapID",
                        column: x => x.MapID,
                        principalTable: "Maps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_MapID",
                table: "Courses",
                column: "MapID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedRuns_Courses_CourseID",
                table: "CompletedRuns",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedRuns_Courses_CourseID",
                table: "CompletedRuns");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "CompletedRuns",
                newName: "MapID");

            migrationBuilder.RenameIndex(
                name: "IX_CompletedRuns_CourseID",
                table: "CompletedRuns",
                newName: "IX_CompletedRuns_MapID");

            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsedID",
                table: "Drones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CrashCount",
                table: "CompletedRuns",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedRuns_Maps_MapID",
                table: "CompletedRuns",
                column: "MapID",
                principalTable: "Maps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
