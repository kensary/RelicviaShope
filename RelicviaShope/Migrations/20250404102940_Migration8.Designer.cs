﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelicviaShope;

#nullable disable

namespace RelicviaShope.Migrations;

[DbContext(typeof(DataBaseContext))]
[Migration("20250404102940_Migration8")]
partial class Migration8
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "9.0.3")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("RelicviaShope.Models.HelpTraders", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("INN")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("HelpTraders");
            });

        modelBuilder.Entity("RelicviaShope.Models.ShopingCard", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Quantity")
                    .HasColumnType("int");

                b.Property<int>("TovarId")
                    .HasColumnType("int");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("TovarId");

                b.HasIndex("UserId");

                b.ToTable("ShopingCards");
            });

        modelBuilder.Entity("RelicviaShope.Models.Tovar", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Price")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("TraderId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Tovars");
            });

        modelBuilder.Entity("RelicviaShope.Models.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int?>("HelpTradersId")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("HelpTradersId");

                b.ToTable("Users");

                b.UseTptMappingStrategy();
            });

        modelBuilder.Entity("RelicviaShope.Models.Admin", b =>
            {
                b.HasBaseType("RelicviaShope.Models.User");

                b.ToTable("Admins");
            });

        modelBuilder.Entity("RelicviaShope.Models.Trader", b =>
            {
                b.HasBaseType("RelicviaShope.Models.User");

                b.Property<string>("Inn")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.ToTable("Traders");
            });

        modelBuilder.Entity("RelicviaShope.Models.ShopingCard", b =>
            {
                b.HasOne("RelicviaShope.Models.Tovar", "Tovar")
                    .WithMany("ShopingCards")
                    .HasForeignKey("TovarId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("RelicviaShope.Models.User", "User")
                    .WithMany("ShopingCards")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Tovar");

                b.Navigation("User");
            });

        modelBuilder.Entity("RelicviaShope.Models.User", b =>
            {
                b.HasOne("RelicviaShope.Models.HelpTraders", null)
                    .WithMany("Users")
                    .HasForeignKey("HelpTradersId");
            });

        modelBuilder.Entity("RelicviaShope.Models.Admin", b =>
            {
                b.HasOne("RelicviaShope.Models.User", null)
                    .WithOne()
                    .HasForeignKey("RelicviaShope.Models.Admin", "Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("RelicviaShope.Models.Trader", b =>
            {
                b.HasOne("RelicviaShope.Models.User", null)
                    .WithOne()
                    .HasForeignKey("RelicviaShope.Models.Trader", "Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("RelicviaShope.Models.HelpTraders", b =>
            {
                b.Navigation("Users");
            });

        modelBuilder.Entity("RelicviaShope.Models.Tovar", b =>
            {
                b.Navigation("ShopingCards");
            });

        modelBuilder.Entity("RelicviaShope.Models.User", b =>
            {
                b.Navigation("ShopingCards");
            });
#pragma warning restore 612, 618
    }
}
