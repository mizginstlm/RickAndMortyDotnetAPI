using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RickNMortyDotnetApi.Migrations
{
    /// <inheritdoc />
    public partial class CharacterEdit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEpisode_Episode_EpisodesId",
                table: "CharacterEpisode");

            migrationBuilder.DropColumn(
                name: "EpisodeId",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "EpisodesId",
                table: "CharacterEpisode",
                newName: "EpisodeId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterEpisode_EpisodesId",
                table: "CharacterEpisode",
                newName: "IX_CharacterEpisode_EpisodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEpisode_Episode_EpisodeId",
                table: "CharacterEpisode",
                column: "EpisodeId",
                principalTable: "Episode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEpisode_Episode_EpisodeId",
                table: "CharacterEpisode");

            migrationBuilder.RenameColumn(
                name: "EpisodeId",
                table: "CharacterEpisode",
                newName: "EpisodesId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterEpisode_EpisodeId",
                table: "CharacterEpisode",
                newName: "IX_CharacterEpisode_EpisodesId");

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEpisode_Episode_EpisodesId",
                table: "CharacterEpisode",
                column: "EpisodesId",
                principalTable: "Episode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
