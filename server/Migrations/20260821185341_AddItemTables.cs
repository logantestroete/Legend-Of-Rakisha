using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class AddItemTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Affixs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AffixCategory = table.Column<string>(type: "text", nullable: false),
                    AffixType = table.Column<string>(type: "text", nullable: false),
                    ModifierType = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    MinValue = table.Column<int>(type: "integer", nullable: false),
                    MaxValue = table.Column<int>(type: "integer", nullable: false),
                    Stat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affixs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ItemType = table.Column<string>(type: "text", nullable: false),
                    ItemSubType = table.Column<string>(type: "text", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    NumSlots = table.Column<int>(type: "integer", nullable: false),
                    IsUnique = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseItemAffixPool",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    AffixId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseItemAffixPool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseItemAffixPool_Affixs_AffixId",
                        column: x => x.AffixId,
                        principalTable: "Affixs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseItemAffixPool_BaseItems_BaseItemId",
                        column: x => x.BaseItemId,
                        principalTable: "BaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaseItemModifiers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Stat = table.Column<string>(type: "text", nullable: false),
                    ModifierType = table.Column<string>(type: "text", nullable: false),
                    value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseItemModifiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseItemModifiers_BaseItems_BaseItemId",
                        column: x => x.BaseItemId,
                        principalTable: "BaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemInstances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Rarity = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemInstances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemInstances_BaseItems_BaseItemId",
                        column: x => x.BaseItemId,
                        principalTable: "BaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemInstanceAffixes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemInstanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    AffixId = table.Column<Guid>(type: "uuid", nullable: false),
                    RolledValue = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemInstanceAffixes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemInstanceAffixes_Affixs_AffixId",
                        column: x => x.AffixId,
                        principalTable: "Affixs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemInstanceAffixes_ItemInstances_ItemInstanceId",
                        column: x => x.ItemInstanceId,
                        principalTable: "ItemInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemAffixPool_AffixId",
                table: "BaseItemAffixPool",
                column: "AffixId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemAffixPool_BaseItemId",
                table: "BaseItemAffixPool",
                column: "BaseItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseItemModifiers_BaseItemId",
                table: "BaseItemModifiers",
                column: "BaseItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemInstanceAffixes_AffixId",
                table: "ItemInstanceAffixes",
                column: "AffixId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemInstanceAffixes_ItemInstanceId",
                table: "ItemInstanceAffixes",
                column: "ItemInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemInstances_BaseItemId",
                table: "ItemInstances",
                column: "BaseItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseItemAffixPool");

            migrationBuilder.DropTable(
                name: "BaseItemModifiers");

            migrationBuilder.DropTable(
                name: "ItemInstanceAffixes");

            migrationBuilder.DropTable(
                name: "Affixs");

            migrationBuilder.DropTable(
                name: "ItemInstances");

            migrationBuilder.DropTable(
                name: "BaseItems");
        }
    }
}
