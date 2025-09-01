using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPVDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class add_crash_count : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CrashCount",
                table: "CompletedRuns",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrashCount",
                table: "CompletedRuns");
        }
    }
}
