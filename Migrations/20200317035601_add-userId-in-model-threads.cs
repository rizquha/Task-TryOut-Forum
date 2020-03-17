using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Try_Out_Forum.Migrations
{
    public partial class adduserIdinmodelthreads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "threads",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "threads",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "threads");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "threads");
        }
    }
}
