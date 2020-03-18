using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Try_Out_Forum.Migrations
{
    public partial class addthreadId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "threads");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "threads");

            migrationBuilder.AddColumn<int>(
                name: "ThreadId",
                table: "threads",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThreadId",
                table: "threads");

            migrationBuilder.AddColumn<int>(
                name: "Comment",
                table: "threads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "threads",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
