using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7335), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7347), "Sample Text 1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7368), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7368), "Sample Text 2" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7369), "Sample Text 3" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7371), "Sample Text 4" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7372), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7372), "Sample Text 5" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7373), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7373), "Sample Text 6" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7375), "Sample Text 7" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7376), "Sample Text 8" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7377), "Sample Text 9" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7378), "Sample Text 10" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7380), "Sample Text 11" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7381), "Sample Text 12" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7382), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7382), "Sample Text 13" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7383), "Sample Text 14" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7384), "Sample Text 15" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7385), "Sample Text 16" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7386), "Sample Text 17" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7387), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7388), "Sample Text 18" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7389), "Sample Text 19" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7390), "Sample Text 20" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7410), "Sample Text 21" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7411), "Sample Text 22" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7413), "Sample Text 23" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7414), "Sample Text 24" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7415), "Sample Text 25" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7416), "Sample Text 26" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7417), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7417), "Sample Text 27" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7419), "Sample Text 28" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7420), "Sample Text 29" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7421), "Sample Text 30" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7421), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7422), "Sample Text 31" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7422), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7423), "Sample Text 32" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7424), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7424), "Sample Text 33" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7425), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7425), "Sample Text 34" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7426), "Sample Text 35" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7427), "Sample Text 36" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7428), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7428), "Sample Text 37" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7429), "Sample Text 38" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7430), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7430), "Sample Text 39" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7431), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7432), "Sample Text 40" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7432), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7433), "Sample Text 41" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7434), "Sample Text 42" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7435), "Sample Text 43" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7436), "Sample Text 44" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7437), "Sample Text 45" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7438), "Sample Text 46" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7439), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7439), "Sample Text 47" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7440), "Sample Text 48" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3399), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3410), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3412), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3412), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3413), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3414), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3415), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3415), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3416), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3417), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3418), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3418), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3418), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3419), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3420), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3421), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3422), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3423), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3423), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3424), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3425), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3425), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3426), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3426), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3427), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3428), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3428), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3428), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3429), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3430), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3430), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3430), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3431), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3431), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3431), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3432), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3433), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3433), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3433), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3434), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3434), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3434), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3435), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3436), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3437), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3437), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3438), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3438), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3438), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3439), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3439), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3439), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3440), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3440), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3441), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3441), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3441), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3442), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3442), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3443), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3444), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3444), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3445), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3446), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3447), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3447), "Sample Text" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "DateOfUpdate", "Title" },
                values: new object[] { new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 1, 4, 22, 17, 45, 427, DateTimeKind.Local).AddTicks(3448), "Sample Text" });
        }
    }
}
