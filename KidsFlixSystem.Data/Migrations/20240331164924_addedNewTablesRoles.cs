using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KidsFlixSystem.Data.Migrations
{
    public partial class addedNewTablesRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 16, 49, 24, 305, DateTimeKind.Utc).AddTicks(2729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 17, 16, 18, 297, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 17, 16, 18, 297, DateTimeKind.Utc).AddTicks(3061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 16, 49, 24, 305, DateTimeKind.Utc).AddTicks(2729));
        }
    }
}
