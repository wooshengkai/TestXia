using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestXia.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumn_20240102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewColumn2",
                table: "TestCreateTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewColumn2",
                table: "TestCreateTable");
        }
    }
}
