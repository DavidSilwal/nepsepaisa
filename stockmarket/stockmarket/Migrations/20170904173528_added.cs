using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace stockmarket.Migrations
{
    public partial class added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
