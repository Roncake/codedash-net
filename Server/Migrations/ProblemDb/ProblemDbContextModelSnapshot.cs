﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using codedash.Shared;

#nullable disable

namespace codedash.Server.Migrations.ProblemDb
{
    [DbContext(typeof(ProblemDbContext))]
    partial class ProblemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("codedash.Shared.Problem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Chunks")
                        .HasColumnType("TEXT");

                    b.Property<int>("Difficulty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Problem");

                    b.HasData(
                        new
                        {
                            Id = "e9410cd7-c31d-4635-adcf-787c7e6f57b8",
                            Chunks = "print(\"Hi\")\nprint(0-1\"Hello, World!\"113)0-1",
                            Difficulty = 0,
                            Title = "Sample 0"
                        },
                        new
                        {
                            Id = "27aad10f-f8d2-4a4a-ab84-351eec0244e0",
                            Chunks = "for i in range(6):\n    print(0-1\"ay\"16, end='')\nprint('9')\n\nprint('ay' * 64 + '9')0-1",
                            Difficulty = 0,
                            Title = "Sample 1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
