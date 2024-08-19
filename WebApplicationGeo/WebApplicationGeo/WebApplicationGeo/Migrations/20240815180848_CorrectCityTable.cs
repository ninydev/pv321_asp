using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationGeo.Migrations
{
    /// <inheritdoc />
    public partial class CorrectCityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Areas_AreaModelId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_AreaModelId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "AreaModelId",
                table: "Cities");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_AreaId",
                table: "Cities",
                column: "AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Areas_AreaId",
                table: "Cities",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Areas_AreaId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_AreaId",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "Area",
                table: "Cities",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaModelId",
                table: "Cities",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_AreaModelId",
                table: "Cities",
                column: "AreaModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Areas_AreaModelId",
                table: "Cities",
                column: "AreaModelId",
                principalTable: "Areas",
                principalColumn: "Id");
        }
    }
}
