using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AikaSeggs.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialStoryDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCd = table.Column<string>(type: "TEXT", nullable: false),
                    StoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsRead = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stories_Accounts_UserCd",
                        column: x => x.UserCd,
                        principalTable: "Accounts",
                        principalColumn: "UserCd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_UserCd_StoryId",
                table: "Stories",
                columns: new[] { "UserCd", "StoryId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stories");
        }
    }
}
