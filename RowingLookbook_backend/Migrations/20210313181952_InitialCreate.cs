using Microsoft.EntityFrameworkCore.Migrations;

namespace RowingLookbook_backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BoatID = table.Column<int>(type: "INTEGER", nullable: false),
                    TourStartPlace = table.Column<string>(type: "TEXT", nullable: true),
                    TourStopPlace = table.Column<string>(type: "TEXT", nullable: true),
                    BoatDriverID = table.Column<int>(type: "INTEGER", nullable: false),
                    MemberOne = table.Column<string>(type: "TEXT", nullable: true),
                    MemberTwo = table.Column<string>(type: "TEXT", nullable: true),
                    MemberThree = table.Column<string>(type: "TEXT", nullable: true),
                    MemberFour = table.Column<string>(type: "TEXT", nullable: true),
                    MemberFive = table.Column<string>(type: "TEXT", nullable: true),
                    MemberSix = table.Column<string>(type: "TEXT", nullable: true),
                    MemberSeven = table.Column<string>(type: "TEXT", nullable: true),
                    MemberEight = table.Column<string>(type: "TEXT", nullable: true),
                    MemberNine = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
