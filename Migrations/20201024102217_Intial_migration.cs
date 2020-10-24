using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyProject.Migrations
{
    public partial class Intial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    dateOfBirth = table.Column<string>(nullable: false),
                    academicYear = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "academicYear", "dateOfBirth", "description", "name" },
                values: new object[,]
                {
                    { "1", "FirstYear", "2020-12-3", "First Year Student", "John" },
                    { "2", "SecondYear", "2020-12-3", "Second Year Student", "Sami" },
                    { "3", "ThirdYear", "2020-12-2", "Third Year Student", "Ahmed" },
                    { "4", "FourthYear", "2020-2-11", "Fourth Year Student", "Mostafa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
