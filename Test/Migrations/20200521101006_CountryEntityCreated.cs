using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class CountryEntityCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CountryCode = table.Column<string>(type: "varchar(2)", nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CountryName", "DateAdded", "DateModified" },
                values: new object[] { 1L, "SG", "Singapore", new DateTime(2020, 5, 21, 18, 10, 6, 433, DateTimeKind.Local).AddTicks(6202), new DateTime(2020, 5, 21, 18, 10, 6, 434, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CountryName", "DateAdded", "DateModified" },
                values: new object[] { 2L, "SL", "Sri Lanka", new DateTime(2020, 5, 21, 18, 10, 6, 434, DateTimeKind.Local).AddTicks(6485), new DateTime(2020, 5, 21, 18, 10, 6, 434, DateTimeKind.Local).AddTicks(6501) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
