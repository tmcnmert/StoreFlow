using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreFlow.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DadeTime",
                table: "Messages",
                newName: "DateTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Messages",
                newName: "DadeTime");
        }
    }
}
