﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("Domain.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAndHour")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShopId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("ShopId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 3,
                            DateAndHour = new DateTime(2024, 9, 13, 16, 8, 51, 918, DateTimeKind.Local).AddTicks(6926),
                            Duration = new TimeSpan(0, 0, 30, 0, 0),
                            EmployeeId = 2,
                            ServiceId = 1,
                            ShopId = 1,
                            Status = 0
                        });
                });

            modelBuilder.Entity("Domain.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Day")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShopId")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShopId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Day = 1,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            ShopId = 1,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            Day = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            ShopId = 1,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            Day = 3,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            ShopId = 1,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            Day = 4,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            ShopId = 1,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            Day = 5,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            ShopId = 1,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            Day = 1,
                            EmployeeId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            Day = 2,
                            EmployeeId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            Day = 3,
                            EmployeeId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            Day = 4,
                            EmployeeId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            Day = 5,
                            EmployeeId = 2,
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ServiceType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A standard haircut service.",
                            Duration = new TimeSpan(0, 0, 30, 0, 0),
                            Name = "Haircut",
                            Price = 20.00m,
                            ServiceType = 0,
                            Status = 0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "Full hair coloring service.",
                            Duration = new TimeSpan(0, 1, 0, 0, 0),
                            Name = "Hair Color",
                            Price = 60.00m,
                            ServiceType = 4,
                            Status = 0,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            Email = "contact@beautysalon.com",
                            Name = "Beauty Salon",
                            Phone = "555-1234",
                            Status = 0,
                            Type = 3
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShopId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john@example.com",
                            Name = "John Doe",
                            Password = "password123",
                            ShopId = 1,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 2,
                            Email = "employee@example.com",
                            Name = "Employee User",
                            Password = "password123",
                            Status = 0,
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Email = "client@example.com",
                            Name = "Client User",
                            Password = "password123",
                            Status = 0,
                            Type = 0
                        },
                        new
                        {
                            Id = 4,
                            Email = "sysadmin@example.com",
                            Name = "SysAdmin User",
                            Password = "password123",
                            Status = 0,
                            Type = 3
                        });
                });

            modelBuilder.Entity("Domain.Entities.Appointment", b =>
                {
                    b.HasOne("Domain.Entities.User", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Shop", "Shop")
                        .WithMany("Appointments")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");

                    b.Navigation("Service");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Domain.Entities.Schedule", b =>
                {
                    b.HasOne("Domain.Entities.User", "Employee")
                        .WithMany("WorkSchedules")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Domain.Entities.Shop", "Shop")
                        .WithMany("Schedules")
                        .HasForeignKey("ShopId");

                    b.Navigation("Employee");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Domain.Entities.Service", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany("Services")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Shop", "Shop")
                        .WithMany("Employees")
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Domain.Entities.Shop", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Employees");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Services");

                    b.Navigation("WorkSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
