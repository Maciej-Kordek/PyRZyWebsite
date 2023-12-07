using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Migrations
{
    /// <inheritdoc />
    public partial class MovedtoPyRZyDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempCommands");

            migrationBuilder.CreateTable(
                name: "ChannelCommands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
                    Timer = table.Column<int>(type: "int", nullable: false),
                    TimesUsed = table.Column<int>(type: "int", nullable: false),
                    Cooldown = table.Column<int>(type: "int", nullable: false),
                    LastUsed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameSpecific = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsComplex = table.Column<bool>(type: "bit", nullable: false),
                    ToDisplay = table.Column<bool>(type: "bit", nullable: false),
                    ParentCommand = table.Column<int>(type: "int", nullable: false),
                    EditLevel = table.Column<int>(type: "int", nullable: false),
                    Deletable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelCommands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChannelInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChannelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BotColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommandSymbol = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ChatFeedback = table.Column<int>(type: "int", nullable: false),
                    BotProtection = table.Column<int>(type: "int", nullable: false),
                    IsStreaming = table.Column<bool>(type: "bit", nullable: false),
                    PointsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RedeemOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuelsPlayed = table.Column<int>(type: "int", nullable: false),
                    AttackersWin = table.Column<int>(type: "int", nullable: false),
                    DefendersWin = table.Column<int>(type: "int", nullable: false),
                    Game = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelInfo", x => x.Id);
                    table.UniqueConstraint("AK_ChannelInfo_ChannelId", x => x.ChannelId);
                });

            migrationBuilder.CreateTable(
                name: "GlobalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TwitchId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuelsPlayed = table.Column<int>(type: "int", nullable: false),
                    DuelsWon = table.Column<int>(type: "int", nullable: false),
                    MaxDuelBet = table.Column<int>(type: "int", nullable: false),
                    AcceptsDuels = table.Column<bool>(type: "bit", nullable: false),
                    ToRank = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalUsers", x => x.Id);
                    table.UniqueConstraint("AK_GlobalUsers_TwitchId", x => x.TwitchId);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aliases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommandId = table.Column<int>(type: "int", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aliases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aliases_ChannelCommands_CommandId",
                        column: x => x.CommandId,
                        principalTable: "ChannelCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChannelLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkRequesterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LinkRequesterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkTargetId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkTargetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChannelLinks_ChannelInfo_LinkRequesterId",
                        column: x => x.LinkRequesterId,
                        principalTable: "ChannelInfo",
                        principalColumn: "ChannelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TwitchId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsWatching = table.Column<bool>(type: "bit", nullable: false),
                    JoinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Watchtime = table.Column<int>(type: "int", nullable: false),
                    MessagesSent = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    DuelsPlayed = table.Column<int>(type: "int", nullable: false),
                    DuelsWon = table.Column<int>(type: "int", nullable: false),
                    Streak = table.Column<int>(type: "int", nullable: false),
                    MaxWinStreak = table.Column<int>(type: "int", nullable: false),
                    MaxLoseStreak = table.Column<int>(type: "int", nullable: false),
                    DuelId = table.Column<int>(type: "int", nullable: false),
                    LastDuel = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatUsers_GlobalUsers_TwitchId",
                        column: x => x.TwitchId,
                        principalTable: "GlobalUsers",
                        principalColumn: "TwitchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aliases_CommandId",
                table: "Aliases",
                column: "CommandId");

            migrationBuilder.CreateIndex(
                name: "IX_ChannelLinks_LinkRequesterId",
                table: "ChannelLinks",
                column: "LinkRequesterId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatUsers_TwitchId",
                table: "ChatUsers",
                column: "TwitchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aliases");

            migrationBuilder.DropTable(
                name: "ChannelLinks");

            migrationBuilder.DropTable(
                name: "ChatUsers");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "ChannelCommands");

            migrationBuilder.DropTable(
                name: "ChannelInfo");

            migrationBuilder.DropTable(
                name: "GlobalUsers");

            migrationBuilder.CreateTable(
                name: "TempCommands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempCommands", x => x.Id);
                });
        }
    }
}
