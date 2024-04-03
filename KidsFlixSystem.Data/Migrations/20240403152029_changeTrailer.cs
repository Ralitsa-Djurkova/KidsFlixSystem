using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KidsFlixSystem.Data.Migrations
{
    public partial class changeTrailer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 15, 20, 28, 894, DateTimeKind.Utc).AddTicks(810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 16, 49, 24, 305, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "TrailerUrl",
                value: "https://static.tvtropes.org/pmwiki/pub/images/ratatouille_dvd.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrailerUrl",
                value: "https://www.ft.com/__origami/service/image/v2/images/raw/http%3A%2F%2Fcom.ft.imagepublish.upp-prod-eu.s3.amazonaws.com%2Fafd7ab32-5517-11e6-9664-e0bdc13c3bef?source=next-article&fit=scale-down&quality=highest&width=700&dpr=1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 16, 49, 24, 305, DateTimeKind.Utc).AddTicks(2729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 15, 20, 28, 894, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "TrailerUrl",
                value: "https://www.imdb.com/title/tt0382932/");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrailerUrl",
                value: "https://www.imdb.com/title/tt2948356/");
        }
    }
}
