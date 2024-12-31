﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhotoChallengeAPI.Data;

#nullable disable

namespace PhotoChallengeApi.Migrations
{
    [DbContext(typeof(PhotoChallengeAPIContext))]
    partial class PhotoChallengeAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("PhotoChallengeAPI.Models.PhotoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Approved")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Challenge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PhotoItem");
                });

            modelBuilder.Entity("PhotoChallengeAPI.Models.PhotoSpecialItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Challenge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.PrimitiveCollection<string>("Voters")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PhotoSpecialItem");
                });
#pragma warning restore 612, 618
        }
    }
}
