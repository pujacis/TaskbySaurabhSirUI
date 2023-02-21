using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskbySaurabhSirUI.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RepoWithStates",
                table: "RepoWithStates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepoWithCountries",
                table: "RepoWithCountries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepoWithCities",
                table: "RepoWithCities");

            migrationBuilder.RenameTable(
                name: "RepoWithStates",
                newName: "State");

            migrationBuilder.RenameTable(
                name: "RepoWithCountries",
                newName: "country");

            migrationBuilder.RenameTable(
                name: "RepoWithCities",
                newName: "City");

            migrationBuilder.AddPrimaryKey(
                name: "PK_State",
                table: "State",
                column: "StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_country",
                table: "country",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_State",
                table: "State");

            migrationBuilder.DropPrimaryKey(
                name: "PK_country",
                table: "country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "State",
                newName: "RepoWithStates");

            migrationBuilder.RenameTable(
                name: "country",
                newName: "RepoWithCountries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "RepoWithCities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepoWithStates",
                table: "RepoWithStates",
                column: "StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepoWithCountries",
                table: "RepoWithCountries",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepoWithCities",
                table: "RepoWithCities",
                column: "CityId");
        }
    }
}
