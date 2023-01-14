﻿// <auto-generated />
using System;
using HSForumAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HSForumAPI.Infrastructure.Migrations
{
    [DbContext(typeof(HSForumContext))]
    [Migration("20230114134011_PostAddedUpdatedAt")]
    partial class PostAddedUpdatedAt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.12");

            modelBuilder.Entity("HSForumAPI.Domain.Models.LocalUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2023, 1, 14, 15, 40, 11, 342, DateTimeKind.Local).AddTicks(6240),
                            Email = "admin@hsforum.lt",
                            PasswordHash = new byte[] { 18, 34, 181, 66, 55, 217, 63, 31, 36, 99, 199, 97, 124, 53, 22, 244, 70, 61, 99, 43, 97, 105, 220, 178, 65, 54, 131, 242, 176, 128, 1, 164 },
                            PasswordSalt = new byte[] { 59, 178, 26, 240, 147, 28, 10, 42, 13, 31, 82, 129, 11, 249, 114, 142, 206, 68, 65, 227, 111, 201, 205, 70, 97, 242, 17, 154, 193, 182, 171, 29, 85, 231, 18, 130, 148, 103, 105, 11, 52, 195, 131, 12, 251, 230, 117, 131, 95, 135, 191, 187, 167, 69, 222, 1, 30, 252, 55, 182, 183, 97, 21, 79 },
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PostId");

                    b.HasIndex("PostTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.PostReply", b =>
                {
                    b.Property<int>("ReplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReplyId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostReplies");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.PostType", b =>
                {
                    b.Property<int>("PostTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PostTypeId");

                    b.ToTable("PostTypes");

                    b.HasData(
                        new
                        {
                            PostTypeId = 1,
                            Type = "News"
                        });
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPositive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RatingId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Name = "User"
                        },
                        new
                        {
                            RoleId = 2,
                            Name = "Admin"
                        },
                        new
                        {
                            RoleId = 3,
                            Name = "Moderator"
                        });
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserRoleId = 1,
                            RoleId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.Post", b =>
                {
                    b.HasOne("HSForumAPI.Domain.Models.PostType", "PostType")
                        .WithMany("Posts")
                        .HasForeignKey("PostTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HSForumAPI.Domain.Models.LocalUser", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PostType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.PostReply", b =>
                {
                    b.HasOne("HSForumAPI.Domain.Models.Post", "Post")
                        .WithMany("Replies")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HSForumAPI.Domain.Models.LocalUser", "User")
                        .WithMany("Replies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.Rating", b =>
                {
                    b.HasOne("HSForumAPI.Domain.Models.Post", "Post")
                        .WithMany("Ratings")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HSForumAPI.Domain.Models.LocalUser", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.UserRole", b =>
                {
                    b.HasOne("HSForumAPI.Domain.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HSForumAPI.Domain.Models.LocalUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.LocalUser", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("Ratings");

                    b.Navigation("Replies");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.Post", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Replies");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.PostType", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("HSForumAPI.Domain.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
