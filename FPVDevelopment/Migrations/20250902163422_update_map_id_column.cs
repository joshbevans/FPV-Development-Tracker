using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPVDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class update_map_id_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MapID",
                table: "Maps",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Maps",
                newName: "MapID");
        }
    }
}
