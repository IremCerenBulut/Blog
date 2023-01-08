using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7533), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7568), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7570), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7571), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7573), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7575), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7576), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7578), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7579), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7581), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7583), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7584), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7586), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7587), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7589), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7592), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7593), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7594), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7595), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7598), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7601), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7603), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7606), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7607), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7611), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7616), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7617), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7618), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7621), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7622), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7623), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7625), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7626), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7652), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7654), new DateTime(2023, 1, 9, 1, 3, 3, 38, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "CategoryPost",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    PostsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPost", x => new { x.CategoriesId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_CategoryPost_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPost_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7335), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7368), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7372), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7373), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7382), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7387), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7417), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7421), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7422), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7424), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7425), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7428), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7430), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7431), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7432), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7439), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "DateOfUpdate" },
                values: new object[] { new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 1, 4, 23, 25, 27, 140, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPost_PostsId",
                table: "CategoryPost",
                column: "PostsId");
        }
    }
}
