using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class CorrectProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Actors",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "MyProperty");
        }
    }
}
