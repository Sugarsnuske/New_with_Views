using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using New_with_Views.Models;

namespace New_with_Views.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20170616184756_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("New_with_Views.Models.Entities.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ActorID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("New_with_Views.Models.Entities.InMovies", b =>
                {
                    b.Property<int>("InMoviesID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActorID");

                    b.Property<int>("MovieItemID");

                    b.HasKey("InMoviesID");

                    b.HasIndex("ActorID");

                    b.HasIndex("MovieItemID");

                    b.ToTable("InMovies");
                });

            modelBuilder.Entity("New_with_Views.Models.Entities.Movie", b =>
                {
                    b.Property<int>("MovieItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Director");

                    b.Property<string>("Genre");

                    b.Property<string>("MovieLength");

                    b.Property<string>("MoviePlot");

                    b.Property<string>("MovieTitle")
                        .IsRequired();

                    b.Property<int>("Rating");

                    b.Property<int>("YearPublished");

                    b.HasKey("MovieItemID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("New_with_Views.Models.Entities.InMovies", b =>
                {
                    b.HasOne("New_with_Views.Models.Entities.Actor", "Actor")
                        .WithMany("InMovies")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("New_with_Views.Models.Entities.Movie", "Movie")
                        .WithMany("InMovies")
                        .HasForeignKey("MovieItemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
