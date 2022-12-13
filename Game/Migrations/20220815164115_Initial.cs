using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    GoldCost = table.Column<int>(type: "INTEGER", nullable: true),
                    MaterialsCost = table.Column<int>(type: "INTEGER", nullable: true),
                    HumanCost = table.Column<int>(type: "INTEGER", nullable: true),
                    FoodCost = table.Column<int>(type: "INTEGER", nullable: true),
                    GoldAdd = table.Column<int>(type: "INTEGER", nullable: true),
                    MaterialsAdd = table.Column<int>(type: "INTEGER", nullable: true),
                    HumanAdd = table.Column<int>(type: "INTEGER", nullable: true),
                    FoodAdd = table.Column<int>(type: "INTEGER", nullable: true),
                    Nextlevel = table.Column<string>(type: "TEXT", nullable: true),
                    GoldModificator = table.Column<double>(type: "REAL", nullable: true),
                    MaterialsModificator = table.Column<double>(type: "REAL", nullable: true),
                    HumanModificator = table.Column<double>(type: "REAL", nullable: true),
                    FoodModificator = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}
