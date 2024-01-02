using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthorizationDemo.Migrations
{
    public partial class UpdatePrivilegeAndHead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Privileges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Privileges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "HeadPrivileges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "HeadPrivileges");
        }
    }
}
