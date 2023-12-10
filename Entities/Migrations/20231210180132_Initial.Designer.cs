﻿// <auto-generated />
using System;
using Entities.Data_Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231210180132_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Data_Model.Appointments", b =>
                {
                    b.Property<int>("Appointments_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Appointments_Id"));

                    b.Property<DateTime?>("AppointmentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorUser_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Appointments_Id");

                    b.HasIndex("DoctorUser_Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Entities.Data_Model.Booking", b =>
                {
                    b.Property<int>("Booking_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Booking_Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DiscountAdded")
                        .HasColumnType("bit");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("DoctorUser_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<string>("Patient_UserUser_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isConfirmed")
                        .HasColumnType("bit");

                    b.HasKey("Booking_Id");

                    b.HasIndex("DoctorUser_Id");

                    b.HasIndex("Patient_UserUser_Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Entities.Data_Model.User", b =>
                {
                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.HasKey("User_Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Entities.Data_Model.Doctor", b =>
                {
                    b.HasBaseType("Entities.Data_Model.User");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("Entities.Data_Model.Appointments", b =>
                {
                    b.HasOne("Entities.Data_Model.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorUser_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Entities.Data_Model.Booking", b =>
                {
                    b.HasOne("Entities.Data_Model.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorUser_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Data_Model.User", "Patient_User")
                        .WithMany()
                        .HasForeignKey("Patient_UserUser_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient_User");
                });

            modelBuilder.Entity("Entities.Data_Model.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
