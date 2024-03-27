using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KidsFlixSystem.Data.Migrations
{
    public partial class connectMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 17, 16, 18, 297, DateTimeKind.Utc).AddTicks(3061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 18, 6, 27, 783, DateTimeKind.Utc).AddTicks(2352));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 18, 6, 27, 783, DateTimeKind.Utc).AddTicks(2352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 17, 16, 18, 297, DateTimeKind.Utc).AddTicks(3061));
        }
    }
}
