using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationGeo.Migrations
{
    /// <inheritdoc />
    public partial class CreateGeoTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AreaModelRegionModel",
                columns: table => new
                {
                    AreasId = table.Column<int>(type: "INTEGER", nullable: false),
                    RegionsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaModelRegionModel", x => new { x.AreasId, x.RegionsId });
                    table.ForeignKey(
                        name: "FK_AreaModelRegionModel_Regions_RegionsId",
                        column: x => x.RegionsId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AreaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Area = table.Column<int>(type: "INTEGER", nullable: false),
                    AreaModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Areas_AreaModelId",
                        column: x => x.AreaModelId,
                        principalTable: "Areas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    CapitalId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Cities_CapitalId",
                        column: x => x.CapitalId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaModelRegionModel_RegionsId",
                table: "AreaModelRegionModel",
                column: "RegionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_CountryId",
                table: "Areas",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_AreaModelId",
                table: "Cities",
                column: "AreaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CapitalId",
                table: "Countries",
                column: "CapitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_AreaModelRegionModel_Areas_AreasId",
                table: "AreaModelRegionModel",
                column: "AreasId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Countries_CountryId",
                table: "Areas",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Areas_AreaModelId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "AreaModelRegionModel");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
