﻿// <auto-generated />
using System;
using GifteeAngular.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace GifteeAngular.Migrations
{
    [DbContext(typeof(GifteeDbContext))]
    partial class GifteeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GifteeAngular.Core.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("EventName")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.EventGift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("GiftId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("GiftId");

                    b.ToTable("EventsGifts");
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("StoreLink");

                    b.HasKey("Id");

                    b.ToTable("Gifts");
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.Giftee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(64);

                    b.Property<string>("FirstName")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .HasMaxLength(255);

                    b.Property<string>("NickName")
                        .HasMaxLength(255);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Giftees");
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.GifteeEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("GifteeId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("GifteeId");

                    b.ToTable("GifteesEvents");
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.Wishlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GiftId");

                    b.Property<int>("GifteeId");

                    b.HasKey("Id");

                    b.HasIndex("GiftId");

                    b.HasIndex("GifteeId");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.EventGift", b =>
                {
                    b.HasOne("GifteeAngular.Core.Models.Event", "Event")
                        .WithMany("EventGifts")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GifteeAngular.Core.Models.Gift", "Gift")
                        .WithMany("EventGifts")
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.Giftee", b =>
                {
                    b.HasOne("GifteeAngular.Core.Models.User", "User")
                        .WithMany("Giftees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.GifteeEvent", b =>
                {
                    b.HasOne("GifteeAngular.Core.Models.Event", "Event")
                        .WithMany("GifteeEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GifteeAngular.Core.Models.Giftee", "Giftee")
                        .WithMany("GifteeEvents")
                        .HasForeignKey("GifteeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GifteeAngular.Core.Models.Wishlist", b =>
                {
                    b.HasOne("GifteeAngular.Core.Models.Gift", "Gift")
                        .WithMany("Wishlist")
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GifteeAngular.Core.Models.Giftee", "Giftee")
                        .WithMany("Wishlist")
                        .HasForeignKey("GifteeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
