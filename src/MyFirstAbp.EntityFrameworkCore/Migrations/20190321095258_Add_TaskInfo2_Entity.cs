﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstAbp.Migrations
{
    public partial class Add_TaskInfo2_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "jieshao",
                table: "TaskInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "jieshao",
                table: "TaskInfo",
                nullable: true);
        }
    }
}
