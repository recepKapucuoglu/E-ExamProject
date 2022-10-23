using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlınanPuan",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "BaşarılıMı",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlınanPuan",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BaşarılıMı",
                table: "User");
        }
    }
}
