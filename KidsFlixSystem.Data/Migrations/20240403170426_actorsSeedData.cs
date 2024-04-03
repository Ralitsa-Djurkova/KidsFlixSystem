using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KidsFlixSystem.Data.Migrations
{
    public partial class actorsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 17, 4, 26, 606, DateTimeKind.Utc).AddTicks(1874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 15, 20, 28, 894, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "FullName", "PhotoUrl" },
                values: new object[,]
                {
                    { 1, "Brat Garett", "https://www.imdb.com/name/nm0004951/mediaviewer/rm733221376/?ref_=nm_ov_ph" },
                    { 2, "Lou Romano", "https://www.imdb.com/name/nm0738918/mediaviewer/rm3395136000/?ref_=nm_ov_ph" },
                    { 3, "Patton Oswalt", "https://www.imdb.com/name/nm0652663/mediaviewer/rm532898048/?ref_=nm_ov_ph" },
                    { 5, "Ginnifer Goodwin", "https://www.imdb.com/name/nm0329481/mediaviewer/rm1880188672/?ref_=nm_ov_ph" },
                    { 6, "Jason Bateman", "https://www.imdb.com/name/nm0000867/mediaviewer/rm2064810496/?ref_=nm_ov_ph" },
                    { 7, "Idris Elba", "https://www.imdb.com/name/nm0252961/mediaviewer/rm1950723072/?ref_=nm_ov_ph" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 15, 20, 28, 894, DateTimeKind.Utc).AddTicks(810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 17, 4, 26, 606, DateTimeKind.Utc).AddTicks(1874));
        }
    }
}
