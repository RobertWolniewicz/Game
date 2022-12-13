using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game.Migrations
{
    public partial class Requirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Requirement1",
                table: "Buildings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Requirement2",
                table: "Buildings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Requirement3",
                table: "Buildings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValueRequirement",
                table: "Buildings",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Requirement1",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Requirement2",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Requirement3",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "ValueRequirement",
                table: "Buildings");
        }
    }
}
