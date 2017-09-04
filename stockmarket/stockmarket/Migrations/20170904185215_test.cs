using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace stockmarket.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    DeadLine = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsExpired = table.Column<bool>(type: "INTEGER", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PublishedBy = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    adjClose = table.Column<string>(type: "TEXT", nullable: true),
                    close = table.Column<string>(type: "TEXT", nullable: true),
                    companyAbbr = table.Column<string>(type: "TEXT", nullable: true),
                    companyName = table.Column<string>(type: "TEXT", nullable: true),
                    date = table.Column<string>(type: "TEXT", nullable: true),
                    high = table.Column<string>(type: "TEXT", nullable: true),
                    low = table.Column<string>(type: "TEXT", nullable: true),
                    open = table.Column<string>(type: "TEXT", nullable: true),
                    volume = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    addedBy = table.Column<string>(type: "TEXT", nullable: true),
                    publishedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
