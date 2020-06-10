﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserInfra.Contexts;

namespace UserInfra.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200609135528_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UserDomain.Models.AddressType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressTypeId")
                        .HasColumnType("int");

                    b.Property<string>("AddressTypeName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("AddressType");
                });

            modelBuilder.Entity("UserDomain.Models.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContactTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ContactTypeName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ContactType");
                });

            modelBuilder.Entity("UserDomain.Models.EmailType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmailTypeId")
                        .HasColumnType("int");

                    b.Property<string>("EmailTypeName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("EmailType");
                });

            modelBuilder.Entity("UserDomain.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UserBirthDate")
                        .HasColumnType("Date");

                    b.Property<string>("UserCpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("UserDeletedDate")
                        .HasColumnType("Date");

                    b.Property<long?>("UserDeletedUser")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UserFirstLoginDate")
                        .HasColumnType("Date");

                    b.Property<string>("UserGender")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<string>("UserMainEmail")
                        .IsRequired()
                        .HasColumnType("varchar(254)")
                        .IsUnicode(true);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("UserStatusId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserStatusId")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("UserDomain.Models.UserAddress", b =>
                {
                    b.Property<long>("UserAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("AddressTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("UserCity")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserComplement")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("UserCountry")
                        .HasColumnType("varchar(50)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserNeighborhood")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserState")
                        .HasColumnType("char(2)");

                    b.Property<string>("UserStreetName")
                        .HasColumnType("varchar(150)");

                    b.Property<int>("UserStreetNumber")
                        .HasColumnType("int(4)");

                    b.Property<int>("UserZipCode")
                        .HasColumnType("int(11)");

                    b.HasKey("UserAddressId");

                    b.HasIndex("AddressTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("UserDomain.Models.UserContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContactTypeId")
                        .HasColumnType("int");

                    b.Property<long>("UserContactId")
                        .HasColumnType("bigint");

                    b.Property<int>("UserCountryRegion")
                        .HasColumnType("int");

                    b.Property<int>("UserDDD")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<int>("UserPhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContactTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserContact");
                });

            modelBuilder.Entity("UserDomain.Models.UserEmail", b =>
                {
                    b.Property<long>("UserEmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("EmailTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserMail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserEmailId");

                    b.HasIndex("EmailTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserEmail");
                });

            modelBuilder.Entity("UserDomain.Models.UserStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserStatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserStatusName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserStatus");
                });

            modelBuilder.Entity("UserDomain.Models.User", b =>
                {
                    b.HasOne("UserDomain.Models.UserStatus", null)
                        .WithOne("User")
                        .HasForeignKey("UserDomain.Models.User", "UserStatusId")
                        .IsRequired();
                });

            modelBuilder.Entity("UserDomain.Models.UserAddress", b =>
                {
                    b.HasOne("UserDomain.Models.AddressType", "AddressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeId")
                        .IsRequired();

                    b.HasOne("UserDomain.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .IsRequired();
                });

            modelBuilder.Entity("UserDomain.Models.UserContact", b =>
                {
                    b.HasOne("UserDomain.Models.ContactType", "ContactType")
                        .WithMany()
                        .HasForeignKey("ContactTypeId")
                        .IsRequired();

                    b.HasOne("UserDomain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired();
                });

            modelBuilder.Entity("UserDomain.Models.UserEmail", b =>
                {
                    b.HasOne("UserDomain.Models.EmailType", "EmailType")
                        .WithMany()
                        .HasForeignKey("EmailTypeId")
                        .IsRequired();

                    b.HasOne("UserDomain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}