using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AikaSeggs.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddMostCharacterDBFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AbilityLevel1",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AbilityLevel2",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AbilityLevel3",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BattleCount",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExceedLimit",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExceedLimitExp",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Exp",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsProtect",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevel",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbilityLevel1",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AbilityLevel2",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AbilityLevel3",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BattleCount",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ExceedLimit",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ExceedLimitExp",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Exp",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsProtect",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "Characters");
        }
    }
}
