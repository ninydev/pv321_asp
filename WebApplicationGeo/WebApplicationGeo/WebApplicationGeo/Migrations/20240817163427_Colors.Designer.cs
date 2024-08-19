﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationGeo.Data;

#nullable disable

namespace WebApplicationGeo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240817163427_Colors")]
    partial class Colors
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("AreaModelRegionModel", b =>
                {
                    b.Property<int>("AreasId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RegionsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AreasId", "RegionsId");

                    b.HasIndex("RegionsId");

                    b.ToTable("AreaModelRegionModel");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Cars.Toyota.ColorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RGB")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.AreaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.CityModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.CountryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CapitalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CapitalId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.RegionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("AreaModelRegionModel", b =>
                {
                    b.HasOne("WebApplicationGeo.Models.Entities.Geo.AreaModel", null)
                        .WithMany()
                        .HasForeignKey("AreasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationGeo.Models.Entities.Geo.RegionModel", null)
                        .WithMany()
                        .HasForeignKey("RegionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.AreaModel", b =>
                {
                    b.HasOne("WebApplicationGeo.Models.Entities.Geo.CountryModel", "Country")
                        .WithMany("Areas")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.CityModel", b =>
                {
                    b.HasOne("WebApplicationGeo.Models.Entities.Geo.AreaModel", "Area")
                        .WithMany("Cities")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.CountryModel", b =>
                {
                    b.HasOne("WebApplicationGeo.Models.Entities.Geo.CityModel", "Capital")
                        .WithMany()
                        .HasForeignKey("CapitalId");

                    b.Navigation("Capital");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.AreaModel", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("WebApplicationGeo.Models.Entities.Geo.CountryModel", b =>
                {
                    b.Navigation("Areas");
                });
#pragma warning restore 612, 618
        }
    }
}
