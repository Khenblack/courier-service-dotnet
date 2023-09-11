using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierServiceDotnet.Migrations
{
    /// <inheritdoc />
    public partial class AuthTableMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auth",
                schema: "CouriersSchema",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FK_Auth_User = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Auth_User_FK_Auth_User",
                        column: x => x.FK_Auth_User,
                        principalSchema: "CouriersSchema",
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auth_FK_Auth_User",
                schema: "CouriersSchema",
                table: "Auth",
                column: "FK_Auth_User",
                unique: true,
                filter: "[FK_Auth_User] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auth",
                schema: "CouriersSchema");
        }
    }
}
