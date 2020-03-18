using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Try_Out_Forum.Migrations
{
    public partial class changemodelcomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForUserId",
                table: "comments");

            migrationBuilder.AddColumn<string>(
                name: "User_Name",
                table: "comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Name",
                table: "comments");

            migrationBuilder.AddColumn<int>(
                name: "ForUserId",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
