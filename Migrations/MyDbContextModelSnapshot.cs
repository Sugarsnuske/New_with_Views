using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using New_with_Views.Models;

namespace New_with_Views.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

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
        }
    }
}
