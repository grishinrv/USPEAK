using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uspeak.Migrations
{
    public partial class EntityState_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Entities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusChangedTime",
                table: "Entities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Entities");

            migrationBuilder.DropColumn(
                name: "StatusChangedTime",
                table: "Entities");
        }
    }
}
