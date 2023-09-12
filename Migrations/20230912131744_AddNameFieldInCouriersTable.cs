using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierServiceDotnet.Migrations
{
    /// <inheritdoc />
    public partial class AddNameFieldInCouriersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "CouriersSchema",
                table: "Courier",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                schema: "CouriersSchema",
                table: "Courier");
        }
    }
}
