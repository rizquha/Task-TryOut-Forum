using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Try_Out_Forum.Migrations
{
    public partial class addbanuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ban",
                table: "users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ban",
                table: "users");
        }
    }
}
