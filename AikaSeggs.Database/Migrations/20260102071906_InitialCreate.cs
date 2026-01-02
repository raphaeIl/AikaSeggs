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
                    RegisterDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.UniqueConstraint("AK_Accounts_UserId", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    CharacterCd = table.Column<string>(type: "TEXT", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    Exp = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    AddHp = table.Column<int>(type: "INTEGER", nullable: false),
                    AddAtk = table.Column<int>(type: "INTEGER", nullable: false),
                    AddDef = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    AbilityLevel1 = table.Column<int>(type: "INTEGER", nullable: false),
                    AbilityLevel2 = table.Column<int>(type: "INTEGER", nullable: false),
                    AbilityLevel3 = table.Column<int>(type: "INTEGER", nullable: false),
                    ExceedLimit = table.Column<int>(type: "INTEGER", nullable: false),
                    ExceedLimitExp = table.Column<int>(type: "INTEGER", nullable: false),
                    IsProtect = table.Column<int>(type: "INTEGER", nullable: false),
                    RegisterDate = table.Column<string>(type: "TEXT", nullable: false),
                    EquipmentWeaponCds = table.Column<string>(type: "TEXT", nullable: false),
                    EquipmentProtectorCds = table.Column<string>(type: "TEXT", nullable: false),
                    AwakeIds = table.Column<string>(type: "TEXT", nullable: false),
                    BattleCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AddRarity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    DeckId = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterCds = table.Column<string>(type: "TEXT", nullable: false),
                    MemorialCd = table.Column<string>(type: "TEXT", nullable: false),
                    DeckName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decks_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    EquipmentCd = table.Column<string>(type: "TEXT", nullable: false),
                    EquipmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Exp = table.Column<int>(type: "INTEGER", nullable: false),
                    ExceedLimit = table.Column<int>(type: "INTEGER", nullable: false),
                    ExceedLimitExp = table.Column<int>(type: "INTEGER", nullable: false),
                    IsProtect = table.Column<int>(type: "INTEGER", nullable: false),
                    RegisterDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Count = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    MissionId = table.Column<int>(type: "INTEGER", nullable: false),
                    MissionCd = table.Column<string>(type: "TEXT", nullable: false),
                    MissionType = table.Column<int>(type: "INTEGER", nullable: false),
                    MissionGroupId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClearCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceiveCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Missions_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    QuestId = table.Column<int>(type: "INTEGER", nullable: false),
                    StageId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClearCount = table.Column<int>(type: "INTEGER", nullable: false),
                    IsUnlock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quests_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId_CharacterCd",
                table: "Characters",
                columns: new[] { "UserId", "CharacterCd" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Decks_UserId_DeckId",
                table: "Decks",
                columns: new[] { "UserId", "DeckId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_UserId_EquipmentCd",
                table: "Equipment",
                columns: new[] { "UserId", "EquipmentCd" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserId_ItemId",
                table: "Items",
                columns: new[] { "UserId", "ItemId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Missions_UserId_MissionId",
                table: "Missions",
                columns: new[] { "UserId", "MissionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quests_UserId_QuestId",
                table: "Quests",
                columns: new[] { "UserId", "QuestId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Quests");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
