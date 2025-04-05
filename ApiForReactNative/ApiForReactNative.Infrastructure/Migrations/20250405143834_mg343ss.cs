using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiForReactNative.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg343ss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileData",
                table: "TableOnes",
                newName: "DosyaYukle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DosyaYukle",
                table: "TableOnes",
                newName: "FileData");
        }
    }
}
