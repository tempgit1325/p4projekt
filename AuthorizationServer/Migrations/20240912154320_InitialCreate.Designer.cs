﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuthorizationServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240912154320_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IdentityService.DataBase.AddToFriendList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FriendEmail")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("RequestedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RequesterEmail")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("FriendEmail");

                    b.HasIndex("RequesterEmail");

                    b.ToTable("AddToFriendList");
                });

            modelBuilder.Entity("IdentityService.DataBase.ChatData", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MessageId"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverEmail")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.Property<string>("SenderEmail")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MessageId");

                    b.HasIndex("ReceiverEmail");

                    b.HasIndex("SenderEmail");

                    b.ToTable("ChatData");
                });

            modelBuilder.Entity("IdentityService.DataBase.Key", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorizationKey")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("Expire")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("uuid");

                    b.Property<string>("UserRegisterEmail")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserRegisterEmail");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("boolean");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserEmail");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("UserLoginData", b =>
                {
                    b.Property<int>("IdLogin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdLogin"));

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Email1")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Email2")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("ResponseType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("UserRegisterEmail")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.HasKey("IdLogin");

                    b.HasIndex("UserRegisterEmail");

                    b.ToTable("UserLoginData");
                });

            modelBuilder.Entity("UserRegisterData", b =>
                {
                    b.Property<int>("IdRegister")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdRegister"));

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("CodeChallenge")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("CodeChallengeMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("RedirectUri")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ResponseType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("IdRegister");

                    b.HasIndex("Email");

                    b.ToTable("UserRegisterData");
                });

            modelBuilder.Entity("IdentityService.DataBase.AddToFriendList", b =>
                {
                    b.HasOne("UserLoginData", "Friend")
                        .WithMany("ReceivedFriendRequests")
                        .HasForeignKey("FriendEmail")
                        .HasPrincipalKey("Email2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("UserLoginData", "Requester")
                        .WithMany("SentFriendRequests")
                        .HasForeignKey("RequesterEmail")
                        .HasPrincipalKey("Email1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Friend");

                    b.Navigation("Requester");
                });

            modelBuilder.Entity("IdentityService.DataBase.ChatData", b =>
                {
                    b.HasOne("UserLoginData", "Receiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverEmail")
                        .HasPrincipalKey("Email2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("UserLoginData", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderEmail")
                        .HasPrincipalKey("Email1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("IdentityService.DataBase.Key", b =>
                {
                    b.HasOne("UserRegisterData", "UserRegisterData")
                        .WithMany("Keys")
                        .HasForeignKey("UserRegisterEmail")
                        .HasPrincipalKey("Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRegisterData");
                });

            modelBuilder.Entity("RefreshToken", b =>
                {
                    b.HasOne("UserRegisterData", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserEmail")
                        .HasPrincipalKey("Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserLoginData", b =>
                {
                    b.HasOne("UserRegisterData", "Userregisterdata")
                        .WithMany("Userlogindata")
                        .HasForeignKey("UserRegisterEmail")
                        .HasPrincipalKey("Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Userregisterdata");
                });

            modelBuilder.Entity("UserLoginData", b =>
                {
                    b.Navigation("ReceivedFriendRequests");

                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentFriendRequests");

                    b.Navigation("SentMessages");
                });

            modelBuilder.Entity("UserRegisterData", b =>
                {
                    b.Navigation("Keys");

                    b.Navigation("RefreshTokens");

                    b.Navigation("Userlogindata");
                });
#pragma warning restore 612, 618
        }
    }
}
