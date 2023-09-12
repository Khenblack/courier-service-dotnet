using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierServiceDotnet.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CouriersSchema");

            migrationBuilder.CreateTable(
                name: "Courier",
                schema: "CouriersSchema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courier", x => x.Id);
                });

            // migrationBuilder.CreateTable(
            //     name: "User",
            //     schema: "CouriersSchema",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Active = table.Column<bool>(type: "bit", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_User", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Auth",
            //     schema: "CouriersSchema",
            //     columns: table => new
            //     {
            //         UserId = table.Column<int>(type: "int", nullable: false),
            //         PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
            //         PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Auth", x => x.UserId);
            //         table.ForeignKey(
            //             name: "FK_Auth_User_UserId",
            //             column: x => x.UserId,
            //             principalSchema: "CouriersSchema",
            //             principalTable: "User",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "Auth",
            //     schema: "CouriersSchema");

            migrationBuilder.DropTable(
                name: "Courier",
                schema: "CouriersSchema");

            // migrationBuilder.DropTable(
            //     name: "User",
            //     schema: "CouriersSchema");
        }
    }
}
