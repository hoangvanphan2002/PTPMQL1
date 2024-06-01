using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class Disigner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DaiLy_HeThongPhanPhoi_MaHTPP",
                table: "DaiLy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DaiLy",
                table: "DaiLy");

            migrationBuilder.RenameTable(
                name: "DaiLy",
                newName: "Daily");

            migrationBuilder.RenameIndex(
                name: "IX_DaiLy_MaHTPP",
                table: "Daily",
                newName: "IX_Daily_MaHTPP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Daily",
                table: "Daily",
                column: "MaDaiLy");

            migrationBuilder.AddForeignKey(
                name: "FK_Daily_HeThongPhanPhoi_MaHTPP",
                table: "Daily",
                column: "MaHTPP",
                principalTable: "HeThongPhanPhoi",
                principalColumn: "MaHTPP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Daily_HeThongPhanPhoi_MaHTPP",
                table: "Daily");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Daily",
                table: "Daily");

            migrationBuilder.RenameTable(
                name: "Daily",
                newName: "DaiLy");

            migrationBuilder.RenameIndex(
                name: "IX_Daily_MaHTPP",
                table: "DaiLy",
                newName: "IX_DaiLy_MaHTPP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DaiLy",
                table: "DaiLy",
                column: "MaDaiLy");

            migrationBuilder.AddForeignKey(
                name: "FK_DaiLy_HeThongPhanPhoi_MaHTPP",
                table: "DaiLy",
                column: "MaHTPP",
                principalTable: "HeThongPhanPhoi",
                principalColumn: "MaHTPP");
        }
    }
}
