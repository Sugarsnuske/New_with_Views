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
                name: "Actors",
                columns: table => new
                {
                    ActorID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorID);
                });

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

            migrationBuilder.CreateTable(
                name: "InMovies",
                columns: table => new
                {
                    InMoviesID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActorID = table.Column<int>(nullable: false),
                    MovieItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InMovies", x => x.InMoviesID);
                    table.ForeignKey(
                        name: "FK_InMovies_Actors_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InMovies_Movies_MovieItemID",
                        column: x => x.MovieItemID,
                        principalTable: "Movies",
                        principalColumn: "MovieItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InMovies_ActorID",
                table: "InMovies",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_InMovies_MovieItemID",
                table: "InMovies",
                column: "MovieItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InMovies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
