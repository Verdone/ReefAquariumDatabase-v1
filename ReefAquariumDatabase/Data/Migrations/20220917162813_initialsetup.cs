using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReefAquariumDatabase.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salinity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinTankSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceRange = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");
        }
    }
}
