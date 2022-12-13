using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game.Migrations
{
    public partial class NewRequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValueRequirement",
                table: "Buildings",
                newName: "ValueRequirement3");

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Buildings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValueRequirement1",
                table: "Buildings",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValueRequirement2",
                table: "Buildings",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "ValueRequirement1",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "ValueRequirement2",
                table: "Buildings");

            migrationBuilder.RenameColumn(
                name: "ValueRequirement3",
                table: "Buildings",
                newName: "ValueRequirement");
        }
    }
}
