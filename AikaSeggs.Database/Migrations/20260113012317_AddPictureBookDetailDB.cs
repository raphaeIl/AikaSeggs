using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AikaSeggs.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddPictureBookDetailDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PictureBookDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCd = table.Column<string>(type: "TEXT", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    Friendship = table.Column<int>(type: "INTEGER", nullable: false),
                    ExceedLimit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureBookDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PictureBookDetails_Accounts_UserCd",
                        column: x => x.UserCd,
                        principalTable: "Accounts",
                        principalColumn: "UserCd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PictureBookDetails_UserCd_CharacterId",
                table: "PictureBookDetails",
                columns: new[] { "UserCd", "CharacterId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PictureBookDetails");
        }
    }
}
