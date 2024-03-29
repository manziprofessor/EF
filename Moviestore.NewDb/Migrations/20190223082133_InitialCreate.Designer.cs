﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviestoreApp.NewDb;

namespace MovieApp.NewDb.Migrations
{
    [DbContext(typeof(MoviestoreContext))]
    [Migration("20190223082133_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviestoreApp.NewDb.Moviestoretbl", b =>
                {
                    b.Property<int>("MoviestoreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category_name");

                    b.Property<string>("title");

                    b.Property<string>("year");

                    b.HasKey("MoviestoreId");

                    b.ToTable("Moviestores");
                });
#pragma warning restore 612, 618
        }
    }
}
