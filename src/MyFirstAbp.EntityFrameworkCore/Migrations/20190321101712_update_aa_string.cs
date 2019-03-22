using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstAbp.Migrations
{
    public partial class update_aa_string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "aa",
                table: "TaskInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aa",
                table: "TaskInfo");
        }
    }
}
