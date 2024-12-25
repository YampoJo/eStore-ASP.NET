using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Data.Migrations
{
    public partial class IsFullLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFull",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFull",
                table: "AspNetUsers");
        }
    }
}
