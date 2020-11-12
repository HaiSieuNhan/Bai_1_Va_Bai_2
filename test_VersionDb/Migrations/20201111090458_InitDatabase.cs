using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test_VersionDb.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "test_Versions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    VersionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test_Versions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "test_Versions");
        }
    }
}
