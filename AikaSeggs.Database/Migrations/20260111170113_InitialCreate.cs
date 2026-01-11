using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AikaSeggs.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    UserCd = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    UserNameTextId = table.Column<string>(type: "TEXT", nullable: false),
                    UserNameStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Exp = table.Column<int>(type: "INTEGER", nullable: false),
                    FreeGem = table.Column<int>(type: "INTEGER", nullable: false),
                    PaidGem = table.Column<int>(type: "INTEGER", nullable: false),
                    SeVolume = table.Column<int>(type: "INTEGER", nullable: false),
                    BgmVolume = table.Column<int>(type: "INTEGER", nullable: false),
                    VoiceVolume = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxStamina = table.Column<int>(type: "INTEGER", nullable: false),
                    StaminaValue = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxBattlePoint = table.Column<int>(type: "INTEGER", nullable: false),
                    BattlePointValue = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemMaxCount = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterMaxCount = table.Column<int>(type: "INTEGER", nullable: false),
                    EquipmentMaxCount = table.Column<int>(type: "INTEGER", nullable: false),
                    SystemDate = table.Column<string>(type: "TEXT", nullable: false),
                    UserText = table.Column<string>(type: "TEXT", nullable: false),
                    PlayerType = table.Column<int>(type: "INTEGER", nullable: false),
                    BattleSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    IsBgmMute = table.Column<int>(type: "INTEGER", nullable: false),
                    IsSeMute = table.Column<int>(type: "INTEGER", nullable: false),
                    IsVoiceMute = table.Column<int>(type: "INTEGER", nullable: false),
                    IsSkillAuto = table.Column<int>(type: "INTEGER", nullable: false),
                    TutorialStep = table.Column<int>(type: "INTEGER", nullable: false),
                    TutorialEndDate = table.Column<string>(type: "TEXT", nullable: false),
                    RegisterDate = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.UniqueConstraint("AK_Accounts_UserCd", x => x.UserCd);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCd = table.Column<string>(type: "TEXT", nullable: false),
                    CharacterCd = table.Column<string>(type: "TEXT", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    RegisterDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Accounts_UserCd",
                        column: x => x.UserCd,
                        principalTable: "Accounts",
                        principalColumn: "UserCd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Email",
                table: "Accounts",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserCd_CharacterCd",
                table: "Characters",
                columns: new[] { "UserCd", "CharacterCd" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
