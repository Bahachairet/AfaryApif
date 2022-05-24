using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AfaryApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategImg = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Categdes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    CliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CliFname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CliLname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CliEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CliPw = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.CliId);
                });

            migrationBuilder.CreateTable(
                name: "Freelancers",
                columns: table => new
                {
                    FreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreeFname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FreeLname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FreeEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FreePw = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancers", x => x.FreeId);
                });

            migrationBuilder.CreateTable(
                name: "Gigs",
                columns: table => new
                {
                    GigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GigTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GigDisc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    GigDetail = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    GigPhoto = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    GigPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gigs", x => x.GigId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Freelancers");

            migrationBuilder.DropTable(
                name: "Gigs");
        }
    }
}
