using Microsoft.EntityFrameworkCore.Migrations;

namespace ADETQ2_Brand_X.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "list",
                columns: table => new
                {
                    studentinfo = table.Column<string>(nullable: false),
                    studentname = table.Column<string>(nullable: false),
                    studentno = table.Column<string>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_list", x => x.studentinfo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "list");
        }
    }
}
