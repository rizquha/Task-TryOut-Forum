using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Try_Out_Forum.Migrations
{
    public partial class addverificationstatususer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Verification",
                table: "users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Verification",
                table: "users");
        }
    }
}
