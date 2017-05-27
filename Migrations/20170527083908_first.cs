using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace New_with_Views.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieItemID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Director = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    MovieLength = table.Column<string>(nullable: true),
                    MoviePlot = table.Column<string>(nullable: true),
                    MovieTitle = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    YearPublished = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
