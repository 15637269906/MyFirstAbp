using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstAbp.Migrations
{
    public partial class Add_TaskInfo3_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TaskInfo",
                newName: "Title22");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title22",
                table: "TaskInfo",
                newName: "Title");
        }
    }
}
