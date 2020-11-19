using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCaNhan.Data.Migrations
{
    public partial class tao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "The Loai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_The Loai", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_The Loai_URL",
                table: "The Loai",
                column: "URL",
                unique: true,
                filter: "[URL] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "The Loai");
        }
    }
}
