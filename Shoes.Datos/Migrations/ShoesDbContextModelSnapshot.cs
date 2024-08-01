﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shoes.Datos;

#nullable disable

namespace Shoes.Datos.Migrations
{
    [DbContext(typeof(ShoesDbContext))]
    partial class ShoesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shoes.Entidades.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BrandId");

                    b.HasIndex("BrandName")
                        .IsUnique();

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Shoes.Entidades.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"));

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ColorId");

                    b.HasIndex("ColorName")
                        .IsUnique();

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            ColorName = "Azul"
                        },
                        new
                        {
                            ColorId = 2,
                            ColorName = "Blanco"
                        },
                        new
                        {
                            ColorId = 3,
                            ColorName = "Negro"
                        },
                        new
                        {
                            ColorId = 4,
                            ColorName = "Rojo"
                        });
                });

            modelBuilder.Entity("Shoes.Entidades.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GnereName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GenreId");

                    b.HasIndex("GnereName")
                        .IsUnique();

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Shoes.Entidades.Shoe", b =>
                {
                    b.Property<int>("ShoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeId"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("Decimal(10,2)");

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.HasKey("ShoeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.HasIndex("GenreId");

                    b.HasIndex("SportId");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("Shoes.Entidades.ShoeSize", b =>
                {
                    b.Property<int>("ShoeSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeSizeId"));

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<int>("ShoeId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("ShoeSizeId");

                    b.HasIndex("SizeId");

                    b.HasIndex("ShoeId", "SizeId")
                        .IsUnique();

                    b.ToTable("ShoeSizes");
                });

            modelBuilder.Entity("Shoes.Entidades.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"));

                    b.Property<decimal>("SizeNumber")
                        .HasColumnType("decimal(3,1)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Shoes.Entidades.Sport", b =>
                {
                    b.Property<int>("SportiD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SportiD"));

                    b.Property<string>("SportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SportiD");

                    b.HasIndex("SportName")
                        .IsUnique();

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("Shoes.Entidades.Shoe", b =>
                {
                    b.HasOne("Shoes.Entidades.Brand", "Brand")
                        .WithMany("Shoes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shoes.Entidades.Color", "ColorN")
                        .WithMany("Shoes")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shoes.Entidades.Genre", "Genre")
                        .WithMany("Shoes")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shoes.Entidades.Sport", "Sport")
                        .WithMany("Shoes")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("ColorN");

                    b.Navigation("Genre");

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("Shoes.Entidades.ShoeSize", b =>
                {
                    b.HasOne("Shoes.Entidades.Shoe", "ShoeN")
                        .WithMany("ShoesSizes")
                        .HasForeignKey("ShoeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shoes.Entidades.Size", "SizeN")
                        .WithMany("ShoesSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoeN");

                    b.Navigation("SizeN");
                });

            modelBuilder.Entity("Shoes.Entidades.Brand", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("Shoes.Entidades.Color", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("Shoes.Entidades.Genre", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("Shoes.Entidades.Shoe", b =>
                {
                    b.Navigation("ShoesSizes");
                });

            modelBuilder.Entity("Shoes.Entidades.Size", b =>
                {
                    b.Navigation("ShoesSizes");
                });

            modelBuilder.Entity("Shoes.Entidades.Sport", b =>
                {
                    b.Navigation("Shoes");
                });
#pragma warning restore 612, 618
        }
    }
}
