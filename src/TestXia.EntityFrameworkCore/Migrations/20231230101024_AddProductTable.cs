using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestXia.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "AbpPermissions",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "TargetNotifiers",
                table: "AbpNotificationSubscriptions",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "AbpFeatures",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "TestCreateTable",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decimal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Integer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCreateTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestCreateTable2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decimal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCreateTable2", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestCreateTable");

            migrationBuilder.DropTable(
                name: "TestCreateTable2");

            migrationBuilder.DropColumn(
                name: "TargetNotifiers",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "AbpPermissions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "AbpFeatures",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);
        }
    }
}
