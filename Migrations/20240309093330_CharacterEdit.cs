using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RickNMortyDotnetApi.Migrations
{
    /// <inheritdoc />
    public partial class CharacterEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EpisodeId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EpisodeId",
                table: "Characters");
        }
    }
}
