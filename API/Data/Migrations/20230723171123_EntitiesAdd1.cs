using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesAdd1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "AppUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PreferredCampus",
                table: "AppUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Campuses",
                columns: table => new
                {
                    CampusId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CampusName = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    StateProvince = table.Column<string>(type: "TEXT", nullable: true),
                    Latitude = table.Column<int>(type: "INTEGER", nullable: false),
                    Longitude = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campuses", x => x.CampusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CampusId",
                table: "Posts",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_CampusId",
                table: "AppUsers",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Campuses_CampusId",
                table: "AppUsers",
                column: "CampusId",
                principalTable: "Campuses",
                principalColumn: "CampusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Campuses_CampusId",
                table: "Posts",
                column: "CampusId",
                principalTable: "Campuses",
                principalColumn: "CampusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Campuses_CampusId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Campuses_CampusId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Campuses");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CampusId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_CampusId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "PreferredCampus",
                table: "AppUsers");
        }
    }
}
